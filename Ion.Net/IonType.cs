using Newtonsoft.Json;
using System;
using YamlDotNet.Serialization;

namespace Ion.Net
{
    public abstract class IonType 
    {
        public IonType()
        {
            TypeContextKind = TypeContextKind.TypeName;
        }
        
        [YamlIgnore]
        [JsonIgnore]
        public TypeContextKind TypeContextKind
        {
            get;
            set;
        }
        
        private Type _type;
        /// <summary>
        /// Gets or sets the Type context.  Setting this value to a non null value causes IncludeTypeContext to return
        /// true regardless if the IncludeTypeContext value is explicitly set to false.
        /// </summary>
        [YamlIgnore]
        [JsonIgnore]
        public Type Type
        {
            get => _type;
            set
            {
                _type = value;
                SetTypeContext();
            }
        }

        public virtual string ToJson(bool pretty = false, NullValueHandling nullValueHandling = NullValueHandling.Ignore)
        {
            return JsonExtensions.ToJson(this, pretty, nullValueHandling);
        }

        protected abstract void SetTypeContext();
    }
}
