using Newtonsoft.Json;

namespace Ion.Net
{
    /// <summary>
    /// An Ion Link.
    /// </summary>
    public interface IIonLink
    {
        /// <summary>
        /// Gets or sets the href value.
        /// </summary>
        [JsonProperty("href")]
        Iri Href { get; set; }
    }
}
