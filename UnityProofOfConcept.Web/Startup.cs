using Microsoft.Owin;
using Owin;
using UnityProofOfConcept.Web;

[assembly: OwinStartup(typeof(Startup))]

namespace UnityProofOfConcept.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWebApi(WebApiConfig.Register());
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888

        }
    }
}
