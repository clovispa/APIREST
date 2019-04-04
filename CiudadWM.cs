using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIFINAL3.Models
{
    public class CiudadWM
    {

        public string city { get; set; }
        public List<string> coord { get; set; }
        public string country { get; set; }
        public string cod { get; set; }
        public string message { get; set; }
        public string cnt { get; set; }
        public List<string> list { get; set; }

        public List<string> weather { get; set; }
        public List<string> clouds { get; set; }
        public List<string> wind { get; set; }
        public List<string> sys { get; set; }
        public string dt_txt { get; set; }

    }
}