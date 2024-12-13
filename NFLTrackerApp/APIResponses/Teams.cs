using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFLTrackerApp.APIResponses
{
    public class Teams
    {
        public Home home { get; set; }
        public Away away { get; set; }
        public Team team { get; set; }
        public List<Group> groups { get; set; }
    }
}
