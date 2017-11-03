﻿using System.Collections.Specialized;
using System.Web;

namespace UnityProofOfConcept.App
{
    public interface IHttpContextBaseWrapper
    {
        HttpRequestBase Request { get; }
        HttpResponseBase Response { get; }
        HttpContextBase Context { get; }
        NameValueCollection QueryString { get; }
    }
}