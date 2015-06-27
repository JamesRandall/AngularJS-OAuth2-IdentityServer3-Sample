using System.Collections.Generic;
using Thinktecture.IdentityServer.Core.Models;

namespace IdentityServerSample.STS.Configuration
{
    static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new[]
            {
                new Client
                {
                    Enabled = true,
                    ClientName = "Sample API Client",
                    ClientId = "sampleapiclient",
                    Flow = Flows.Implicit,

                    RedirectUris = new List<string>
                    {
                        "https://localhost:44309/",
                        "http://localhost:9000"
                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        "https://localhost:44309/",
                        "http://localhost:9000"
                    }
                }
            };
        }
    }
}
