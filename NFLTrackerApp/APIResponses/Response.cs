using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace NFLTrackerApp.APIResponses
{
    public class Response
    {
        // Holds data from API response
        public int id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string city { get; set; }
        public string coach { get; set; }
        public string owner { get; set; }
        public string stadium { get; set; }
        public int established { get; set; }
        public string conference { get; set; }
        public string division { get; set; }
        public int position { get; set; }
        public Team team { get; set; }
        public int won { get; set; }
        public int lost { get; set; }
        public int ties { get; set; }
        public Records records { get; set; }
        public string streak { get; set; }
        public int age { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string college { get; set; }
        public string group { get; set; }
        public string playerPosition { get; set; }
        public int number { get; set; }
        public string salary { get; set; }
        public int experience { get; set; }
        public string image { get; set; }
        public Game game { get; set; }
        public Teams teams { get; set; }
        public Scores scores { get; set; }
        public Statistics statistics { get; set; }
        public Player player { get; set; }
        public List<Teams> playerTeams { get; set; }
    }
}
