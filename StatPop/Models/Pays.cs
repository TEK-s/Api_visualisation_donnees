using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPopStat.Models
{
    public class Pays
    {
        public int id { get; set; }
        public string Country_Name { get; set; }
        public string Country_Code { get; set; }
        public string Region { get; set; }
        public string Income_Group { get; set; }

        public Pays()
        {

        }
    }
}
