using Newtonsoft.Json;
using System.Web.Http;

namespace Iasset.Controllers
{
    [RoutePrefix("country")]
    public class CountryController : BaseController
    {
        private const string countryBaseUrl = "http://services.groupkt.com/country";

        [HttpGet]
        [Route("get/all")]
        public object GetAll()
        {
            var url = countryBaseUrl + "/get/all";
            return JsonConvert.DeserializeObject(Get(url));
        }

        [HttpGet]
        [Route("get/iso2code/{code}")]
        public object GetByIso2code(string code)
        {
            var url = countryBaseUrl + "/get/iso2code/" + code;
            return JsonConvert.DeserializeObject(Get(url));
        }

        [HttpGet]
        [Route("get/iso3code/{code}")]
        public object GetByIso3code(string code)
        {
            var url = countryBaseUrl + "/get/iso3code/" + code;
            return JsonConvert.DeserializeObject(Get(url));
        }

        [HttpGet]
        [Route("search")]
        public object Search(string text)
        {
            var url = countryBaseUrl + "/search?text=" + text;
            return JsonConvert.DeserializeObject(Get(url));
        }

    }
}