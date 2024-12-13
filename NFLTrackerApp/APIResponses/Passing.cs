using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLTrackerApp.APIResponses
{
    public class Passing
    {
        public int total { get; set; }
        public string comp_att { get; set; }
        public string yards_per_pass { get; set; }
        public int interceptions_thrown { get; set; }
        public string sacks_yards_lost { get; set; }
    }
}
