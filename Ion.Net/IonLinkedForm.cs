using Newtonsoft.Json;

namespace Ion.Net
{
    /// <summary>
    /// Represents a linked form.
    /// </summary>
    public class IonLinkedForm : IonForm, IIonLink
    {
        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        [JsonProperty("href")]
        public Iri Href { get; set; }
    }
}
