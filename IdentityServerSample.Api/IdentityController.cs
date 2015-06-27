using System.Linq;
using System.Security.Claims;
using System.Web.Http;

namespace IdentityServerSample.Api
{
    [Route("claims")]
    [Authorize]
    public class IdentityController : ApiController
    {
        public IHttpActionResult Get()
        {
            var user = User as ClaimsPrincipal;
            var claims = user.Claims.Select(x => new {type = x.Type, value = x.Value});

            return Json(claims);
        }
    }
}
