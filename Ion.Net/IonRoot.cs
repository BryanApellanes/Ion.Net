using System.Collections.Generic;

namespace Ion.Net
{
    public class IonRoot
    {
        public IonRoot()
        {
            Data = new Dictionary<string, IonObject>();
        }

        public Dictionary<string, IonObject> Data { get; set; }
    }
}
