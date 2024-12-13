using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLTrackerApp.APIResponses
{
    public class Away
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
        public int quarter_1 { get; set; }
        public int quarter_2 { get; set; }
        public int quarter_3 { get; set; }
        public int quarter_4 { get; set; }
        public int overtime { get; set; }
        public int total { get; set; }
    }
}
