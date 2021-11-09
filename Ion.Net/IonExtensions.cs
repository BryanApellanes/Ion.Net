using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Ion.Net
{
    public static class IonExtensions
    {
        public static T ToInstance<T>(this IEnumerable<IonMember> ionMembers)
        {
            ConstructorInfo ctor = typeof(T).GetConstructor(Type.EmptyTypes);
            if (ctor == null)
            {
                throw new InvalidOperationException($"The specified type ({typeof(T).AssemblyQualifiedName}) does not have a parameterless constructor.");
            }
            T instance = (T)ctor.Invoke(null);
            foreach (IonMember ionMember in ionMembers)
            {
                ionMember.SetProperty(instance);
            }
            return instance;
        }

        public static bool IsJsonArray(this string jsonArray)
        {
            return IsJsonArray(jsonArray, out JArray ignore);
        }

        public static bool IsJsonArray(this string jsonArray, out JArray jArray)
        {
            return IsJsonArray(jsonArray, out jArray, out _);
        }

        public static bool IsJsonArray(this string jsonArray, out JArray jArray, out Exception exception)
        {
            exception = null;
            try
            {
                jArray = JArray.Parse(jsonArray);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                jArray = null;
                return false;
            }
        }

        public static bool IsJson(this string json)
        {
            return IsJson(json, out JObject ignore);
        }

        public static bool IsJson(this string json, out JObject jObject)
        {
            return IsJson(json, out jObject, out Exception ignore);
        }

        public static bool IsJson(this string json, out JObject jObject, out Exception exception)
        {
            exception = null;
            try
            {
                jObject = JObject.Parse(json);
                return true;
            }
            catch (JsonReaderException ex)
            {
                exception = ex;
                jObject = null;
                return false;
            }
        }
    }
}
