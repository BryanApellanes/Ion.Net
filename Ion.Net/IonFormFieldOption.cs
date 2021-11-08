using System.Collections.Generic;

namespace Ion.Net
{
    // https://ionspec.org/#form-field-option-members

    public class IonFormFieldOption : IonObject
    {

        static HashSet<string> _formFieldOptionMembers;
        static object _formFieldOptionMembersLock = new object();

        public static HashSet<string> FormFieldOptionMembers
        {
            get
            {
                if(_formFieldOptionMembers == null)
                {
                    lock(_formFieldOptionMembersLock)
                    {
                        if(_formFieldOptionMembers == null)
                        {
                            _formFieldOptionMembers = new HashSet<string>(new[]
                            {
                                "enabled",
                                "label",
                                "value"
                            });
                        }
                    }
                }
                return _formFieldOptionMembers;
            }
        }
    }
}
