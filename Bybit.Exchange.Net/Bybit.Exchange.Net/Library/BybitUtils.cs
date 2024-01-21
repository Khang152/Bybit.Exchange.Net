using Bybit.Exchange.Net.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;
using Bybit.Exchange.Net.Extensions;
using Microsoft.Extensions.Options;
using static Bybit.Exchange.Net.Data.Enums;
using Bybit.Exchange.Net.Models.V5.Trade;

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

        public async Task<string> PostData(string url, object? requestData = null, bool useAPIKey = true)
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
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetData(string url, object? requestData = null, bool useAPIKey = true)
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
            return await response.Content.ReadAsStringAsync();
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
            var env = options.Environment == BybitEnvironment.Live ? BybitBaseUrl.Mainnet : BybitBaseUrl.Testnet;
            var requestUrl = env + url;
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