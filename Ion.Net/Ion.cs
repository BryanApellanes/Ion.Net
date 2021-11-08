﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Ion.Net
{
    /// <summary>
    /// A convenience entry point to Ion functionality.
    /// </summary>
    public abstract class Ion
    {
        public static IonObjectTypes InferBaseType(string json)
        {
            Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            if (dictionary.ContainsKey("value"))
            {
                object value = dictionary["value"];
                if (value is JObject)
                {
                    return IonObjectTypes.Object;
                }

                if (value is JArray)
                {
                    return IonObjectTypes.Collection;
                }
            }
            return IonObjectTypes.Value;
        }

        public static bool IsLink(string json)
        {
            return IsLink(json, out IonLink ignore);
        }

        public static bool IsLink(string json, out IonLink ionLink)
        {
            return IonLink.IsValid(json, out ionLink);
        }



        public static bool IsFormField(string json)
        {
            return IsFormField(json, out IonFormField ignore);
        }

        public static bool IsFormField(string json, out IonFormField ionFormField)
        {
            return IonFormField.IsValid(json, out ionFormField);
        }

        public static bool IsForm(string json)
        {
            return IsForm(json, out IonFormValidationResult ignore);
        }

        /// <summary>
        /// Determines if the specified json is an ion form.
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static bool IsForm(string json, out IonFormValidationResult result)
        {
            result = IonForm.Validate(json);
            return result.Success;
        }
    }
}
