﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Ion.Net
{
    public static class JsonExtensions
    {
        public static bool TryFromJson<T>(this string json, out T instance)
        {
            return TryFromJson<T>(json, out instance, out Exception ignore);
        }

        public static bool TryFromJson<T>(this string json, out T instance, out Exception exception)
        {
            instance = default(T);
            exception = null;
            try
            {
                instance = FromJson<T>(json);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        /// <summary>
        /// Deserialize the current string as the specified
        /// generic type T.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T FromJson<T>(this string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string ToJson(this object value, bool pretty, NullValueHandling nullValueHandling = NullValueHandling.Ignore)
        {
            Formatting formatting = pretty ? Formatting.Indented : Formatting.None;
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Formatting = formatting,
                NullValueHandling = nullValueHandling
            };
            return value.ToJson(settings);
        }

        public static string ToJson(this object value, JsonSerializerSettings settings)
        {
            return JsonConvert.SerializeObject(value, settings);
        }

        public static string ToJson(this object value, params JsonConverter[] converters)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            if (converters != null && converters.Length > 0)
            {
                settings.Converters = new List<JsonConverter>(converters);
            }

            return JsonConvert.SerializeObject(value, settings);
        }
    }
}
