using Newtonsoft.Json;

namespace Ion.Net
{
    public class IonLinkedForm : IonForm, IIonLink
    {
        [JsonProperty("href")]
        public Iri Href { get; set; }
    }
}
