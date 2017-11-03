using System.Web;

namespace UnityProofOfConcept.App
{
    public class HttpContextBaseWrapper : IHttpContextBaseWrapper
    {
        public HttpRequestBase Request => new HttpRequestWrapper(HttpContext.Current.Request);

        public HttpResponseBase Response => new HttpResponseWrapper(HttpContext.Current.Response);
        
        public HttpContextBase Context => new HttpContextWrapper(HttpContext.Current);
    }
}