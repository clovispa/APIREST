using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIFINAL3.Models
{
    public class RegionalBloc
    {
        public string acronym { get; set; }
        public string name { get; set; }
        public List<object> otherAcronyms { get; set; }
        public List<string> otherNames { get; set; }
    }
}