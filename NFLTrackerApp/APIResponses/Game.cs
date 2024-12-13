using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NFLTrackerApp.APIResponses
{
    public class Game
    {
        public int id { get; set; }
        public string stage { get; set; }
        public string week { get; set; }
        public Date date { get; set; }
        public Venue venue { get; set; }
        public Status status { get; set; }
    }
}
