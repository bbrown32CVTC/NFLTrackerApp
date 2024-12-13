/*
 * Created by: Bruce Brown 
 * Date Created: 9/18/2024
 */


using System;

namespace NFLTrackerApp
{

    /// <summary>
    /// A C# WinForm application to display data for the current National Football League (NFL) season, teams, and players
    /// by using the API-AMERICAN-FOOTBALL (1.4.7) API from API-SPORTS (https://v1.american-football.api-sports.io). The api key used
    /// is associated with the Mega plan tier option that allows up to 150,000 calls to the API each day. There is an option to view
    /// a list of teams by division or conference, which allows the user to click on the team's image to get the team's data. On the team
    /// form there is information about the team and a few stats, as well as buttons to get the current roster, schedule, or current game
    /// data. There is error handling for when the API returns and error and when there is no data available for a team or player selected.
    /// Datagridviews are used to display the majority of the data and statistics received from the API calls. There is a help menu that 
    /// provides information to the user about how to use the different forms. A new developer cloning this application will need to get their
    /// own API key to use with the application, which will need to be inserted in the 'key' variable in the NFLKey.cs class.
    /// </summary>
    /// 

    public partial class NFLTrackerForm : Form
    {
        // Global Variables
        private string[] teamSelection;


        public NFLTrackerForm()
        {
            InitializeComponent();

            // Hide error message
            this.errorLabel.Hide();

            // Set up Team ComboBox and display first item
            setTeamCB();
            this.teamSelectCB.SelectedIndex = 0;
        }

        private void setTeamCB()
        {
            // Create team list and set it to the team selection combobox
            this.teamSelection = new string[] {"", "Las Vegas Raiders", "Jacksonville Jaguars", "New England Patriots", "New York Giants",
                "Baltimore Ravens", "Tennessee Titans", "Detroit Lions", "Atlanta Falcons", "Cleveland Browns", "Cincinnati Bengals",
                "Arizona Cardinals", "Philadelphia Eagles", "New York Jets", "San Francisco 49ers", "Green Bay Packers", "Chicago Bears",
                "Kansas City Chiefs", "Washington Commanders", "Carolina Panthers", "Buffalo Bills", "Indianapolis Colts", "Pittsburgh Steelers",
                "Seattle Seahawks", "Tampa Bay Buccaneers", "Miami Dolphins", "Houston Texans", "New Orleans Saints", "Denver Broncos",
                "Dallas Cowboys", "Los Angeles Chargers", "Los Angeles Rams", "Minnesota Vikings"};

            this.teamSelectCB.Items.AddRange(teamSelection);
        }

        private void getInfoBtn_Click(object sender, EventArgs e)
        {
            // Hide error message if displayed for new selection
            if (this.errorLabel.Visible)
            {
                this.errorLabel.Hide();
            }

            // Display error if invalid selection
            if (this.teamSelectCB.SelectedIndex == 0 || this.teamSelectCB.SelectedItem.Equals(""))
            {
                this.errorLabel.Text = "Error: Invalid team selection. Please try again.";
                this.errorLabel.Show();
            }
            else
            {
                // Open form for team selected using index number associated with team
                int apiNum = getApiNum(this.teamSelectCB.Text);
                TeamForm tf = new TeamForm(apiNum, this.teamSelectCB.Text);
                tf.Show(this);
                tf.errorCheck();

                if (tf.DialogResult != DialogResult.OK)
                {
                    this.errorLabel.Text = "Error: Unable to retrieve data from API. Try again or contact IT support.";
                    this.errorLabel.Show();
                }

            }

        }

        private void teamSelectCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide error message if displayed for new selection
            if (this.errorLabel.Visible)
            {
                this.errorLabel.Hide();
            }

        }

        private void conferenceBtn_Click(object sender, EventArgs e)
        {
            // Open and stay on Conference Form until closed
            ConferenceForm cf = new ConferenceForm();
            cf.ShowDialog();
        }

        private void divisionBtn_Click(object sender, EventArgs e)
        {
            // Open and stay on Division Form until closed
            DivisionForm df = new DivisionForm();
            df.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display support contact information
            MessageBox.Show("ProSync CS LLC \n\n1212 Sugar Blvd \nEau Claire, WI 54703 \n\n715-555-5525", "Contact Support");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the instructions and details for operating this form
            MessageBox.Show("Select the team you would like to view and click the 'Get Team Info' button, which will take you to the " +
                "Team window and display their information. \n\nClicking on the 'Divisions' button will display the Division window, which " +
                "will display each team and their logo by division. Clicking on the 'Conferences' button will display the Conference window, " +
                "which will display each team and their logo by conference. Each of these windows will allow you to click the logo to display " +
                "the team's information on the Team window. \n\nThe Team window will give you informational data about the team like their current " +
                "standings, coach, owner, and division rank. There are also buttons available to see their full schedule for this season, " +
                "current player roster, and stats for any current game being played by the team at the time the button is clicked. An error " +
                "message will display at the bottom if there are any errors due to data not being available.", "NFL Tracker Instructions");
        }

        private int getApiNum(string team)
        {
            // Get and return the API number for the selected team
            int apiNum = 0;

            switch (team.Trim())
            {
                case "Las Vegas Raiders":
                    apiNum = 1;
                    break;

                case "Jacksonville Jaguars":
                    apiNum = 2;
                    break;

                case "New England Patriots":
                    apiNum = 3;
                    break;

                case "New York Giants":
                    apiNum = 4;
                    break;

                case "Baltimore Ravens":
                    apiNum = 5;
                    break;

                case "Tennessee Titans":
                    apiNum = 6;
                    break;

                case "Detroit Lions":
                    apiNum = 7;
                    break;

                case "Atlanta Falcons":
                    apiNum = 8;
                    break;

                case "Cleveland Browns":
                    apiNum = 9;
                    break;

                case "Cincinnati Bengals":
                    apiNum = 10;
                    break;

                case "Arizona Cardinals":
                    apiNum = 11;
                    break;

                case "Philadelphia Eagles":
                    apiNum = 12;
                    break;

                case "New York Jets":
                    apiNum = 13;
                    break;

                case "San Francisco 49ers":
                    apiNum = 14;
                    break;

                case "Green Bay Packers":
                    apiNum = 15;
                    break;

                case "Chicago Bears":
                    apiNum = 16;
                    break;

                case "Kansas City Chiefs":
                    apiNum = 17;
                    break;

                case "Washington Commanders":
                    apiNum = 18;
                    break;

                case "Carolina Panthers":
                    apiNum = 19;
                    break;

                case "Buffalo Bills":
                    apiNum = 20;
                    break;

                case "Indianapolis Colts":
                    apiNum = 21;
                    break;

                case "Pittsburgh Steelers":
                    apiNum = 22;
                    break;

                case "Seattle Seahawks":
                    apiNum = 23;
                    break;

                case "Tampa Bay Buccaneers":
                    apiNum = 24;
                    break;

                case "Miami Dolphins":
                    apiNum = 25;
                    break;

                case "Houston Texans":
                    apiNum = 26;
                    break;

                case "New Orleans Saints":
                    apiNum = 27;
                    break;

                case "Denver Broncos":
                    apiNum = 28;
                    break;

                case "Dallas Cowboys":
                    apiNum = 29;
                    break;

                case "Los Angeles Chargers":
                    apiNum = 30;
                    break;

                case "Los Angeles Rams":
                    apiNum = 31;
                    break;

                case "Minnesota Vikings":
                    apiNum = 32;
                    break;

            }

            return apiNum;
        }
        
    }

}
