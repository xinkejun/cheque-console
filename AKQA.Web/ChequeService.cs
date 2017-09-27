using System.IO;
using System.Net;
using System.Web;

namespace AKQA.Web
{
    public class ChequeService
    {
        protected string BaseUrl = string.Empty;

        public ChequeService()
        {
            var request = HttpContext.Current.Request;
            BaseUrl = request.Url.Scheme + "://" + request.Url.Authority;
        }

        public ChequeService(string baseUrl)
        {
            this.BaseUrl = baseUrl;
        }

        public string GetChequeAmountText(double amount)
        {
            var text = Get(BaseUrl + "/api/cheque/getchequeamounttext/" + amount + "/");
            return text.Replace("\"", string.Empty);
        }

        static string Get(string requestUrl)
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
    }
}