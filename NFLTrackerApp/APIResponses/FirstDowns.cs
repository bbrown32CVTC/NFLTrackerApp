using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLTrackerApp.APIResponses
{
    public class FirstDowns
    {
        public int total { get; set; }
        public int passing { get; set; }
        public int rushing { get; set; }
        public int from_penalties { get; set; }
        public string third_down_efficiency { get; set; }
        public string fourth_down_efficiency { get; set; }
    }
}
