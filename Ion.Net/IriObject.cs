using Newtonsoft.Json;
using System.Collections.Generic;

namespace Ion.Net
{
    public class IriObject : IJsonable
    {
        public IriObject(string uri)
        {
            this.Href = new Iri(uri);
        }

        public IriObject(Iri iri)
        {
            this.Href = iri;
        }

        [JsonProperty("href")]
        public Iri Href { get; set; }

        public string ToJson(bool pretty)
        {
            return JsonExtensions.ToJson(this, pretty);
        }

        public string ToJson()
        {
            return this.ToJson(false);
        }

        public static IriObject Read(string iriJson)
        {
            Dictionary<string, object> keyValuePairs = JsonConvert.DeserializeObject<Dictionary<string, object>>(iriJson);
            return new IriObject(keyValuePairs["href"].ToString());
        }
    }
}
