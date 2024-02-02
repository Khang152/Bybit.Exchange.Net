using Bybit.Exchange.Net.Extensions;
using Bybit.Exchange.Net.Models.Common;
using System.Security.Cryptography;
using System.Text;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Library
{
    public static class Utils
    {
        public static async Task<BybitResponse> PostData(BybitRestOptions options, string url, object? requestData = null, bool useAPIKey = true, int retry = 0)
        {
            string jsonPayload = requestData?.ToJsonString() ?? string.Empty;
            using var client = new HttpClient();
            HttpRequestMessage request = new(HttpMethod.Post, url)
            {
                Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json")
            };

            if (useAPIKey && !string.IsNullOrEmpty(options.Credentials.Key))
            {
                string timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
                string signature = GeneratePostSignature(options, timestamp, requestData);
                request.Headers.Add("X-BAPI-API-KEY", options.Credentials.Key);
                request.Headers.Add("X-BAPI-SIGN", signature);
                request.Headers.Add("X-BAPI-SIGN-TYPE", "2");
                request.Headers.Add("X-BAPI-TIMESTAMP", timestamp);
                request.Headers.Add("X-BAPI-RECV-WINDOW", options.RecvWindow);
            }

            var response = await client.SendAsync(request);
            var results = new BybitResponse();
            results.Request = jsonPayload;
            results.Response = await response.Content.ReadAsStringAsync();
            results.Header = response.Headers.ToDictionary(a => a.Key, a => a.Value);

            if (string.IsNullOrEmpty(results.Response))
            {
                results.Response = response.ToJsonString();
                return results;
            }

            if (results.Response.Contains("retCode") && results.Response.Contains(":10004") && retry < 5)
            {
                await Task.Delay(200);
                retry += 1;
                results = await PostData(options, url, requestData, useAPIKey, retry);
            }

            return results;
        }

        public static async Task<BybitResponse> GetData(BybitRestOptions options, string url, object? requestData = null, bool useAPIKey = true, int retry = 0)
        {
            string queryString = GenerateQueryString(requestData);
            using var client = new HttpClient();
            var requestUrl = !string.IsNullOrEmpty(queryString) ? $"{url}?{queryString}" : url;
            var request = new HttpRequestMessage(HttpMethod.Get, requestUrl);

            if (useAPIKey && !string.IsNullOrEmpty(options.Credentials.Key))
            {
                string timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
                string signature = GenerateGetSignature(options, timestamp, requestData);
                request.Headers.Add("X-BAPI-API-KEY", options.Credentials.Key);
                request.Headers.Add("X-BAPI-SIGN", signature);
                request.Headers.Add("X-BAPI-SIGN-TYPE", "2");
                request.Headers.Add("X-BAPI-TIMESTAMP", timestamp);
                request.Headers.Add("X-BAPI-RECV-WINDOW", options.RecvWindow);
            }

            var response = await client.SendAsync(request);
            var results = new BybitResponse();
            results.Request = queryString;
            results.Response = await response.Content.ReadAsStringAsync();
            results.Header = response.Headers.ToDictionary(a => a.Key, a => a.Value);

            if (string.IsNullOrEmpty(results.Response))
            {
                results.Response = response.ToJsonString();
                return results;
            }

            if (results.Response.Contains("retCode") && results.Response.Contains(":10004") && retry < 5)
            {
                await Task.Delay(200);
                retry += 1;
                results = await GetData(options, url, requestData, useAPIKey, retry);
            }

            return results;
        }

        public static string GeneratePostSignature(BybitRestOptions options, string timestamp, IDictionary<string, object> parameters)
        {
            string paramJson = parameters.ToJsonString();
            string rawData = timestamp + options.Credentials.Key + options.RecvWindow + paramJson;

            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(options.Credentials.Secret));
            var signature = hmac.ComputeHash(Encoding.UTF8.GetBytes(rawData));
            return BitConverter.ToString(signature).Replace("-", "").ToLower();
        }

        public static string GeneratePostSignature(BybitRestOptions options, string timestamp, object? parameters)
        {
            if (parameters == null)
                return string.Empty;

            string paramJson = parameters.ToJsonString();
            string rawData = timestamp + options.Credentials.Key + options.RecvWindow + paramJson;

            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(options.Credentials.Secret));
            var signature = hmac.ComputeHash(Encoding.UTF8.GetBytes(rawData));
            return BitConverter.ToString(signature).Replace("-", "").ToLower();
        }

        public static string GenerateGetSignature(BybitRestOptions options, string timestamp, Dictionary<string, object> parameters)
        {
            string queryString = GenerateQueryString(parameters);
            string rawData = timestamp + options.Credentials.Key + options.RecvWindow + queryString;
            return ComputeSignature(options, rawData);
        }

        public static string GenerateGetSignature<T>(BybitRestOptions options, string timestamp, T data)
        {
            string queryString = GenerateQueryString(data);
            string rawData = timestamp + options.Credentials.Key + options.RecvWindow + queryString;
            return ComputeSignature(options, rawData);
        }

        public static string ComputeSignature(BybitRestOptions options, string data)
        {
            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(options.Credentials.Secret));
            byte[] signature = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
            return BitConverter.ToString(signature).Replace("-", "").ToLower();
        }

        public static string GenerateQueryString(Dictionary<string, object>? parameters = null)
        {
            if (parameters == null)
                return string.Empty;

            return string.Join("&", parameters.Select(p => $"{p.Key}={p.Value}"));
        }

        public static string GenerateQueryString(object? data)
        {
            if (data == null)
                return string.Empty;

            var dictionary = data.ToObject<Dictionary<string, object>>();
            return GenerateQueryString(dictionary);
        }

        public static string GetUrl(BybitRestOptions options, string url)
        {
            var env = options.Environment == BybitEnvironment.Live ?
                !string.IsNullOrEmpty(options.MainnetBaseURL) ? options.MainnetBaseURL : BybitBaseUrl.Mainnet :
                !string.IsNullOrEmpty(options.TestnetBaseURL) ? options.TestnetBaseURL : BybitBaseUrl.Testnet;

            var requestUrl = env + url;
            return requestUrl;
        }

        public static BybitResponse<T> GetResponse<T>(BybitResponse response)
        {
            var results = new BybitResponse<T>();

            try
            {
                results = response.Response?.ToJsonObject<BybitResponse<T>>();
                results ??= new BybitResponse<T>();
                results.Infomation = response.ToObject<BybitResponse>();
            }
            catch (Exception ex)
            {
                results ??= new BybitResponse<T>();
                results.Exceptions ??= new Exceptions();
                results.Exceptions.Message = ex.Message;
                results.Exceptions.StackTrace = ex.StackTrace;
            }

            return results;
        }
    }
}