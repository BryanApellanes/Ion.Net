namespace Ion.Net
{
    public class Base64UrlEncodedByteArray
    {
        public Base64UrlEncodedByteArray() { }

        string _value;
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                _array = value.FromBase64UrlEncoded();
            }
        }

        byte[] _array;
        public byte[] Array
        {
            get
            {
                return _array;
            }
            set
            {
                _array = value;
                _value = value.ToBase64UrlEncoded();
            }
        }
    }
}
