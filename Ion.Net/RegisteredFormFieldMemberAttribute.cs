using System;

namespace Ion.Net
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RegisteredFormFieldMemberAttribute: Attribute
    {
        public RegisteredFormFieldMemberAttribute(string memberName)
        {
            this.MemberName = memberName;
        }

        public string MemberName { get; set; }
    }
}
