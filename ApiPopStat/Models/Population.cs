using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPopStat.Models
{
    public class Population
    {
        public int id { get; set; }
        public string Country_Name { get; set; }
        public string Country_Code { get; set; }
        public string Indicator_Name { get; set; }
        public string Indicator_Code { get; set; }
        public List<double> Years { get; set; }
        
        public Population()
        {
            this.Years = new List<double>();
        }
    }
}
