using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Bybit.Exchange.Net.Extensions
{
    internal static class JsonExtension
    {
        public static string ToJsonString(this object obj)
        {
            var results = JsonConvert.SerializeObject(obj, JsonSettings());
            return results;
        }

        public static T? ToJsonObject<T>(this string obj)
        {
            var results = (T?)Activator.CreateInstance(typeof(T));
            if (string.IsNullOrEmpty(obj))
            {
                return results;
            }
            return JsonConvert.DeserializeObject<T>(obj, JsonSettings());
        }

        public static T ToObject<T>(this object obj)
        {
            var results = JsonConvert.SerializeObject(obj, JsonSettings());
            return JsonConvert.DeserializeObject<T>(results, JsonSettings()) ?? default(T)!;
        }

        public static JsonSerializerSettings JsonSettings()
        {
            var settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.PreserveReferencesHandling = PreserveReferencesHandling.None;
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            settings.Converters.Add(new StringEnumConverter());
            settings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
            settings.MissingMemberHandling = MissingMemberHandling.Ignore;
            settings.Formatting = Formatting.None;
            return settings;
        }
    }
}