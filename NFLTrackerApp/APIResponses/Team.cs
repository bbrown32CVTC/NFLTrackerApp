using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLTrackerApp.APIResponses
{
    public class Team
    {
        // Holds data from API response
        public List<object> errors { get; set; }
        public List<Response> response { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
    }
}
