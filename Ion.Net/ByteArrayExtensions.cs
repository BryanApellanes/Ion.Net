using Microsoft.AspNetCore.WebUtilities;

namespace Ion.Net
{
    public static class ByteArrayExtensions
    {
        public static string ToBase64UrlEncoded(this byte[] data)
        {
            return WebEncoders.Base64UrlEncode(data);
        }
    }
}
