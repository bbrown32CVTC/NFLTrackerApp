using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLTrackerApp.APIResponses
{
    public class Group
    {
        public string name { get; set; }
        public List<Statistics> statistics { get; set; }
    }
}
