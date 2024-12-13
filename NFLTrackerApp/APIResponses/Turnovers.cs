using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLTrackerApp.APIResponses
{
    public class Turnovers
    {
        public int total { get; set; }
        public int lost_fumbles { get; set; }
        public int interceptions { get; set; }
    }
}
