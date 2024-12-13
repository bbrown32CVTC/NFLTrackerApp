using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLTrackerApp.APIResponses
{
    public class Date
    {
        public string timezone { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public int timestamp { get; set; }
    }
}
