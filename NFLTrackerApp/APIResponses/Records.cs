using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLTrackerApp.APIResponses
{
    public class Records
    {
        // Holds data from API response
        public string home { get; set; }
        public string road { get; set; }
        public string conference { get; set; }
        public string division { get; set; }
    }
}
