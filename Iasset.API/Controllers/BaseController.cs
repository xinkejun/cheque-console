using System;
using System.Diagnostics;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace Iasset.Controllers
{
    public class BaseController : ApiController
    {
        #region Basic Http Method

        public string Get(string requestUrl)
        {
            var webRequest = WebRequest.Create(requestUrl) as HttpWebRequest;
            webRequest.Method = WebRequestMethods.Http.Get;
            webRequest.ContentType = "application/x-www-form-urlencoded";

            var webResponse = webRequest.GetResponse() as HttpWebResponse;
            if (webResponse != null)
            {
                try
                {
                    if (webResponse.StatusCode == HttpStatusCode.OK)
                    {
                        var srRes = new StreamReader(webResponse.GetResponseStream());
                        return srRes.ReadToEnd();
                    }
                }
                finally
                {
                    webResponse.Close();
                }
            }

            return string.Empty;
        }

        #endregion
    }
}
