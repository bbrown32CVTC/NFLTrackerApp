using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFLTrackerApp
{
    public partial class DivisionForm : Form
    {
        // Global Variables
        private int apiNum = 0;
        private string teamName = "";


        public DivisionForm()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display support contact information
            MessageBox.Show("ProSync CS LLC \n\n1212 Sugar Blvd \nEau Claire, WI 54703 \n\n715-555-5525", "Contact Support");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the instructions and details for operating this form
            MessageBox.Show("Clicking on a team's logo will bring you to the Team form for the selected team, which will display their data. " +
                "The Team form will allow you to view their current roster, schedule, and information for a game they are currently playing.",
                "Division Window Instructions");
        }

        private void lvrPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 1;
            this.teamName = "Las Vegas Raiders";
            displayTeam();
        }

        private void jjPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 2;
            this.teamName = "Jacksonville Jaguars";
            displayTeam();
        }

        private void nepPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 3;
            this.teamName = "New England Patriots";
            displayTeam();
        }

        private void nygPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 4;
            this.teamName = "New York Giants";
            displayTeam();
        }

        private void brPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 5;
            this.teamName = "Baltimore Ravens";
            displayTeam();
        }

        private void ttPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 6;
            this.teamName = "Tennessee Titans";
            displayTeam();
        }

        private void dlPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 7;
            this.teamName = "Detroit Lions";
            displayTeam();
        }

        private void afPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 8;
            this.teamName = "Atlanta Falcons";
            displayTeam();
        }

        private void cbroPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 9;
            this.teamName = "Cleveland Browns";
            displayTeam();
        }

        private void cbenPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 10;
            this.teamName = "Cincinnati Bengals";
            displayTeam();
        }

        private void acPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 11;
            this.teamName = "Arizona Cardinals";
            displayTeam();
        }

        private void pePB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 12;
            this.teamName = "Philadelphia Eagles";
            displayTeam();
        }

        private void nyjPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 13;
            this.teamName = "New York Jets";
            displayTeam();
        }

        private void sfPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 14;
            this.teamName = "San Francisco 49ers";
            displayTeam();
        }

        private void gbpPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 15;
            this.teamName = "Green Bay Packers";
            displayTeam();
        }

        private void cbearPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 16;
            this.teamName = "Chicago Bears";
            displayTeam();
        }

        private void kccPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 17;
            this.teamName = "Kansas City Chiefs";
            displayTeam();
        }

        private void wcPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 18;
            this.teamName = "Washington Commanders";
            displayTeam();
        }

        private void cpPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 19;
            this.teamName = "Carolina Panthers";
            displayTeam();
        }

        private void bbPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 20;
            this.teamName = "Buffalo Bills";
            displayTeam();
        }

        private void icPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 21;
            this.teamName = "Indianapolis Colts";
            displayTeam();
        }

        private void psPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 22;
            this.teamName = "Pittsburgh Steelers";
            displayTeam();
        }

        private void ssPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 23;
            this.teamName = "Seattle Seahawks";
            displayTeam();
        }

        private void tbbPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 24;
            this.teamName = "Tampa Bay Buccaneers";
            displayTeam();
        }

        private void mdPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 25;
            this.teamName = "Miami Dolphins";
            displayTeam();
        }

        private void htPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 26;
            this.teamName = "Houston Texans";
            displayTeam();
        }

        private void nosPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 27;
            this.teamName = "New Orleans Saints";
            displayTeam();
        }

        private void dbPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 28;
            this.teamName = "Denver Broncos";
            displayTeam();
        }

        private void dcPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 29;
            this.teamName = "Dallas Cowboys";
            displayTeam();
        }

        private void lacPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 30;
            this.teamName = "Los Angeles Chargers";
            displayTeam();
        }

        private void larPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 31;
            this.teamName = "Los Angeles Rams";
            displayTeam();
        }

        private void mvPB_Click(object sender, EventArgs e)
        {
            // Set up team information for team form
            this.apiNum = 32;
            this.teamName = "Minnesota Vikings";
            displayTeam();
        }

        private void displayTeam()
        {
            TeamForm tf = new TeamForm(this.apiNum, this.teamName);
            tf.Show(this);
            tf.errorCheck();

            if (tf.DialogResult != DialogResult.OK)
            {
                MessageBox.Show("Error: Unable to retrieve data from API. Try again or contact IT support.");
                this.Close();
            }
        }
    }
}
