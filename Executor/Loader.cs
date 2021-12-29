using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executor
{
    internal class Loader
    {
        public static byte[] LoadURL(string url)
        {
            System.Net.IWebProxy defaultWebProxy = System.Net.WebRequest.DefaultWebProxy;
            defaultWebProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            return Convert.FromBase64String((new System.Net.WebClient() { Proxy = defaultWebProxy }).DownloadString(url));
        }
    }
}
