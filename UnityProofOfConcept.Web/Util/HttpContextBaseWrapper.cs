using System.Collections.Specialized;
using System.Diagnostics;
using System.Web;
using UnityProofOfConcept.Core;
using UnityProofOfConcept.Core.Util;

namespace UnityProofOfConcept.Web.Util
{
    public class HttpContextBaseWrapper : IHttpContextBaseWrapper
    {
        private static int _instancesCreated;
        public HttpContextBaseWrapper()
        {
            Debug.WriteLine($"Creating the HttpContextBaseWrapper..({++_instancesCreated} instances)");
        }
        public HttpRequestBase Request
        {
            get
            {
                reportInstances();
                return new HttpRequestWrapper(HttpContext.Current.Request);
            }
        }

        public HttpResponseBase Response
        {
            get
            {
                reportInstances();
                return new HttpResponseWrapper(HttpContext.Current.Response); }
        }

        public HttpContextBase Context
        {
            get
            {
                reportInstances();
                return new HttpContextWrapper(HttpContext.Current);
            }
        }

        private void reportInstances()
        {
            Debug.WriteLine($"-- called ({_instancesCreated} instances)");
        }

        public NameValueCollection QueryString => Request.QueryString;
    }
}