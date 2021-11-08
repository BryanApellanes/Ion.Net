using Newtonsoft.Json;

namespace Ion.Net
{
    public interface IIonLink
    {
        [JsonProperty("href")]
        Iri Href { get; set; }
    }
}
