using Bybit.Exchange.Net.Extensions;
using Bybit.Exchange.Net.Models.Common;
using System.Security.Cryptography;
using System.Text;
using static Bybit.Exchange.Net.Data.Enums;

namespace Bybit.Exchange.Net.Library
{
    public class BybitUtils
    {
        private string ApiKey = string.Empty;
        private string ApiSecret = string.Empty;
        private string RecvWindow = string.Empty;

        public BybitUtils(BybitRestOptions options)
        {
            ApiKey = options.Credentials.Key;
            ApiSecret = options.Credentials.Secret;
            RecvWindow = options.RecvWindow;
        }

        public async Task<string> PostData(string url, object? requestData = null, bool useAPIKey = true, int retry = 0)
        {
            string jsonPayload = requestData?.ToJsonString() ?? string.Empty;
            using var client = new HttpClient();
            HttpRequestMessage request = new(HttpMethod.Post, url)
            {
                Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json")
            };

            if (useAPIKey)
            {
                string timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
                string signature = GeneratePostSignature(requestData);
                request.Headers.Add("X-BAPI-API-KEY", ApiKey);
                request.Headers.Add("X-BAPI-SIGN", signature);
                request.Headers.Add("X-BAPI-SIGN-TYPE", "2");
                request.Headers.Add("X-BAPI-TIMESTAMP", timestamp);
                request.Headers.Add("X-BAPI-RECV-WINDOW", RecvWindow);
            }

            var response = await client.SendAsync(request);
            var results = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(results))
            {
                results = response.ToJsonString();
                return results;
            }

            if (results.Contains("error sign! origin_string") && retry < 3)
            {
                await Task.Delay(200);
                retry += 1;
                results = await PostData(url, requestData, useAPIKey, retry);
            }

            return results;
        }

        public async Task<string> GetData(string url, object? requestData = null, bool useAPIKey = true, int retry = 0)
        {
            string queryString = GenerateQueryString(requestData);
            using var client = new HttpClient();
            url = !string.IsNullOrEmpty(queryString) ? $"{url}?{queryString}" : url;
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            if (useAPIKey)
            {
                string timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
                string signature = GenerateGetSignature(requestData);
                request.Headers.Add("X-BAPI-API-KEY", ApiKey);
                request.Headers.Add("X-BAPI-SIGN", signature);
                request.Headers.Add("X-BAPI-SIGN-TYPE", "2");
                request.Headers.Add("X-BAPI-TIMESTAMP", timestamp);
                request.Headers.Add("X-BAPI-RECV-WINDOW", RecvWindow);
            }

            var response = await client.SendAsync(request);
            var results = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(results))
            {
                results = response.ToJsonString();
                return results;
            }

            if (results.Contains("error sign! origin_string") && retry < 3)
            {
                await Task.Delay(200);
                retry += 1;
                results = await GetData(url, requestData, useAPIKey, retry);
            }

            return results;
        }

        public string GeneratePostSignature(IDictionary<string, object> parameters)
        {
            string Timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
            string paramJson = parameters.ToJsonString();
            string rawData = Timestamp + ApiKey + RecvWindow + paramJson;

            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(ApiSecret));
            var signature = hmac.ComputeHash(Encoding.UTF8.GetBytes(rawData));
            return BitConverter.ToString(signature).Replace("-", "").ToLower();
        }

        public string GeneratePostSignature(object? parameters)
        {
            if (parameters == null)
                return string.Empty;

            string Timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
            string paramJson = parameters.ToJsonString();
            string rawData = Timestamp + ApiKey + RecvWindow + paramJson;

            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(ApiSecret));
            var signature = hmac.ComputeHash(Encoding.UTF8.GetBytes(rawData));
            return BitConverter.ToString(signature).Replace("-", "").ToLower();
        }

        public string GenerateGetSignature(Dictionary<string, object> parameters)
        {
            string Timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
            string queryString = GenerateQueryString(parameters);
            string rawData = Timestamp + ApiKey + RecvWindow + queryString;

            return ComputeSignature(rawData);
        }

        public string GenerateGetSignature<T>(T data)
        {
            string Timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
            string queryString = GenerateQueryString(data);
            string rawData = Timestamp + ApiKey + RecvWindow + queryString;
            return ComputeSignature(rawData);
        }

        public string ComputeSignature(string data)
        {
            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(ApiSecret));
            byte[] signature = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
            return BitConverter.ToString(signature).Replace("-", "").ToLower();
        }

        public string GenerateQueryString(Dictionary<string, object>? parameters = null)
        {
            if (parameters == null)
                return string.Empty;

            return string.Join("&", parameters.Select(p => $"{p.Key}={p.Value}"));
        }

        public string GenerateQueryString(object? data)
        {
            if (data == null)
                return string.Empty;

            var dictionary = data.ToObject<Dictionary<string, object>>();
            return GenerateQueryString(dictionary);
        }

        public string GetUrl(string url, BybitRestOptions options)
        {
            var requestUrl = string.Empty;
            if (!string.IsNullOrEmpty(options.BaseURL))
            {
                requestUrl = options.BaseURL + url;
            }
            else
            {
                var env = options.Environment == BybitEnvironment.Live ? BybitBaseUrl.Mainnet : BybitBaseUrl.Testnet;
                requestUrl = env + url;
            }
            return requestUrl;
        }

        public BybitResponse<T> GetResponse<T>(string response)
        {
            var results = new BybitResponse<T>();

            try
            {
                results = response.ToJsonObject<BybitResponse<T>>();
                results ??= new BybitResponse<T>();
            }
            catch (Exception ex)
            {
                results ??= new BybitResponse<T>();
                results.Errors ??= new Errors();
                results.Errors.Message = ex.Message;
                results.Errors.StackTrace = ex.StackTrace;
            }

            results.Raw = response;
            return results;
        }
    }
}