using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace Bybit.Exchange.Net.Extensions
{
    public static class JsonExtension
    {
        /// <summary>
        /// [Library] Convert object to String
        /// </summary>
        /// <param name="obj">Current object</param>
        /// <returns></returns>
        public static string ToJsonString(this object obj)
        {
            var results = JsonConvert.SerializeObject(obj, JsonSettings());
            return results;
        }

        /// <summary>
        /// [Library] Convert string to object
        /// </summary>
        /// <typeparam name="T">Type of destination object</typeparam>
        /// <param name="obj">Current object</param>
        /// <returns></returns>
        public static T? ToJsonObject<T>(this string obj)
        {
            var results = (T?)Activator.CreateInstance(typeof(T));
            if (string.IsNullOrEmpty(obj))
            {
                return results;
            }
            return JsonConvert.DeserializeObject<T>(obj, JsonSettings());
        }

        /// <summary>
        /// [Library] Convert object to other object
        /// </summary>
        /// <typeparam name="T">Type of destination object</typeparam>
        /// <param name="obj">Current object</param>
        /// <returns></returns>
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

        public class LowercaseContractResolver : DefaultContractResolver
        {
            protected override string ResolvePropertyName(string propertyName)
            {
                return propertyName.ToLower();
            }
        }
    }
}