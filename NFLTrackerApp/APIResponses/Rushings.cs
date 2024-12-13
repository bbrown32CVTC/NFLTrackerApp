using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLTrackerApp.APIResponses
{
    public class Rushings
    {
        public int total { get; set; }
        public int attempts { get; set; }
        public string yards_per_rush { get; set; }
    }
}
