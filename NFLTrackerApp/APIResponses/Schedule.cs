using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLTrackerApp.APIResponses
{
    public class Schedule
    {
        public List<object> errors { get; set; }
        public int results { get; set; }
        public List<Response> response { get; set; }
    }
}
