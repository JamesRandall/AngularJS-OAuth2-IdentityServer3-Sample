using System.Web.Http;
using Microsoft.Owin.Cors;
using Owin;
using Thinktecture.IdentityServer.AccessTokenValidation;

namespace IdentityServerSample.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseIdentityServerBearerTokenAuthentication(new IdentityServerBearerTokenAuthenticationOptions
            {
                Authority = "https://localhost:44309/identity",
                RequiredScopes = new[] { "myWebApi" }
            });
            app.UseCors(CorsOptions.AllowAll);

            // web api configuration
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            app.UseWebApi(config);


        }
    }
}
