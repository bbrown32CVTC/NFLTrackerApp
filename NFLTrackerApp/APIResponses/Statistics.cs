using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLTrackerApp.APIResponses
{
    public class Statistics
    {
        public FirstDowns first_downs { get; set; }
        public Plays plays { get; set; }
        public Yards yards { get; set; }
        public Passing passing { get; set; }
        public Rushings rushings { get; set; }
        public RedZone red_zone { get; set; }
        public Penalties penalties { get; set; }
        public Turnovers turnovers { get; set; }
        public Posession posession { get; set; }
        public Interceptions interceptions { get; set; }
        public FumblesRecovered fumbles_recovered { get; set; }
        public Sacks sacks { get; set; }
        public Safeties safeties { get; set; }
        public IntTouchdowns int_touchdowns { get; set; }
        public PointsAgainst points_against { get; set; }
        public string name { get; set; }
        public string value { get; set; }
    }
}
