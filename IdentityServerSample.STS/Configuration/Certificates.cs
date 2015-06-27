using System.IO;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace IdentityServerSample.STS.Configuration
{
    static class Certificates
    {
        public static X509Certificate2 GetSigningCertificate()
        {
            using (Stream stream = typeof (Certificates).Assembly.GetManifestResourceStream("IdentityServerSample.STS.Configuration.idsrv3test.pfx"))
            {
                byte[] bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                return new X509Certificate2(bytes, "idsrv3test");
            }
        }
    }
}
