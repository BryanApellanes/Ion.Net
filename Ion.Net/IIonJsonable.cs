using Newtonsoft.Json;

namespace Ion.Net
{
    public interface IIonJsonable
    {
        string ToIonJson();
        string ToIonJson(bool pretty = false, NullValueHandling nullValueHandling = NullValueHandling.Ignore);
    }
}
