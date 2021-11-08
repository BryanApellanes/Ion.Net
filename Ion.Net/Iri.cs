using System;

namespace Ion.Net
{
    /// <summary>
    /// Represents an Iri, see https://tools.ietf.org/html/rfc3987.  This implementation should be considered a place holder for the extension defined in rfc3987;
    /// for now Iri extends Uri, in the future this will likely not be the case.
    /// </summary>
    public class Iri : Uri
    {
        public static implicit operator string(Iri iri)
        {
            return iri.ToString();
        }
        
        public static implicit operator Iri(string value)
        {
            return new Iri(value);
        }

        public Iri(string uriString) : base(uriString)
        {
        }

        public static bool IsIri(string url, out Iri iri, Action<Exception> exceptionHandler = null)
        {
            iri = null;
            try
            {
                iri = new Iri(url);
                return true;
            }
            catch (Exception ex)
            {
                if(exceptionHandler == null)
                {
                    exceptionHandler = (exception) => Console.WriteLine($"{exception.Message}:\r\n\t{exception.StackTrace}");
                }
                exceptionHandler(ex);
                return false;
            }
        }
    }
}
