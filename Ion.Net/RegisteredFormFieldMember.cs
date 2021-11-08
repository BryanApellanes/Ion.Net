using System.Collections.Generic;

namespace Ion.Net
{
    public class RegisteredFormFieldMember
    {
        public static HashSet<string> Names
        {
            get => IonFormFieldMember.RegisteredNames;
        }
    }
}
