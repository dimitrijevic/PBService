using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PBService.Controllers
{
    public class MobileController : ApiController
    {
        // GET: api/Mobile
        public string Get()
        {
            return "ERR";
        }

        // GET: api/Mobile?num=38165xxxxxxx
        public string Get(string num)
        {
            if (num.StartsWith("381") && num.Length > 5)
            {
                var httpClient = new HttpClient();
                string url = "http://www.prenesibroj.rs/operator.php?telbroj=" + num;
                string sResponse = httpClient.GetStringAsync(url).Result;   
                if (sResponse.Contains("Mt:s")) return "MTS";
                if (sResponse.Contains("Vip")) return "VIP";
                if (sResponse.Contains("Telenor")) return "TEL";
                switch (num.Substring(0, 5))
                {
                    case "38160": return "VIP";
                    case "38161": return "VIP";
                    case "38162": return "TEL";
                    case "38163": return "TEL";
                    case "38164": return "MTS";
                    case "38165": return "MTS";
                    case "38166": return "MTS";
                    case "38168": return "MAX";
                    case "38169": return "MTS";
                    default: return "ERR";
                }
            }
            else
            {
                return "ERR";
            }

        }
    }
}
