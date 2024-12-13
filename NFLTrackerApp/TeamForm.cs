using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;
using NFLTrackerApp.APIResponses;
using RestSharp;

namespace NFLTrackerApp
{
    public partial class TeamForm : Form
    {
        // Global Variables
        private int teamNum = 0;
        private int year = 0;
        private bool errorFound = false;
        private string apiKey = NFLKey.getKey();
        private Schedule currentGame;
        private string homeOrAway = "";
        private string homeTeam = "";
        private int gameNum = 0;
        private int oppTeamNum = 0;


        public TeamForm(int teamNum, string teamName)
        {
            InitializeComponent();

            // Set the team's API number for API calls
            this.teamNum = teamNum;

            // Hide error message
            this.errorLabel.Hide();

            // Set the form and title to the team's name
            this.Text = teamName;
            this.teamNameLbl.Text = teamName;

            // Set the current year for API calls
            System.DateTime current = DateTime.Now;
            int month = current.Month;
            if (month > 2)
            {
                // Super Bowl has already happened and it's the start of a new NFL season year
                this.year = current.Year;
            }
            else
            {
                // Super Bowl has not already happened and it's still last year's NFL season year
                this.year = current.Year - 1;
            }

            // Get the selected team's image as a stream and set it to the picturebox
            Stream imgStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream($"NFLTrackerApp.Images.{teamNum}.png");
            this.teamPB.Image = new Bitmap(imgStream);

            if (teamNum == 13 || teamName.Equals("New York Jets"))
            {
                // Resize the image for New York Jets logo
                this.teamPB.SizeMode = PictureBoxSizeMode.AutoSize;
            }

            // Get and set the team's information from APIs
            getTeamInfo();
            getTeamStandings();
        }

        private void getTeamInfo()
        {

            try
            {
                RestClient client = new RestClient($"https://v1.american-football.api-sports.io/teams?id={this.teamNum}&league=1&season={this.year}"); // Sets API address
                RestRequest request = new RestRequest()  // Create GET request
                {
                    Method = Method.Get
                };
                request.AddHeader("x-rapidapi-key", this.apiKey);
                request.AddHeader("content-type", "application/json");
                RestResponse response = client.Execute(request);  // Submit Get request

                if (response.IsSuccessful && !response.Content.Contains("\"results\":0"))
                {
                    // Mark the dialog result as OK and deserialize the Json data
                    this.DialogResult = DialogResult.OK;
                    Team team = JsonConvert.DeserializeObject<Team>(response.Content);

                    // Set the form's text fields
                    this.establishedNumLbl.Text = team.response[0].established.ToString(); //Established Year
                    this.coachNameLbl.Text = team.response[0].coach.ToString(); // Current Coach's Name
                    this.ownerNameLbl.Text = team.response[0].owner.ToString(); // Current Owner's Name
                    this.stadiumNameLbl.Text = team.response[0].stadium.ToString(); // Current Stadium Name
                    this.stadLocName.Text = getStadiumLocation(team.response[0].id); // Current Stadium Location
                }
                else
                {
                    // Set error boolean and dialog result
                    apiErrorFallout();
                }

            }
            catch (Exception ex)
            {
                // Set error boolean and dialog result
                apiErrorFallout();
            }

        }

        private void getTeamStandings()
        {

            try
            {
                RestClient client = new RestClient($"https://v1.american-football.api-sports.io/standings?team={teamNum}&league=1&season={this.year}"); // Sets API address
                RestRequest request = new RestRequest()  // Create GET request
                {
                    Method = Method.Get
                };
                request.AddHeader("x-rapidapi-key", this.apiKey);
                request.AddHeader("content-type", "application/json");
                RestResponse response = client.Execute(request);  // Submit Get request

                if (response.IsSuccessful && !response.Content.Contains("\"results\":0"))
                {
                    // Mark the dialog result as OK and deserialize the Json data
                    this.DialogResult = DialogResult.OK;
                    Standings standings = JsonConvert.DeserializeObject<Standings>(response.Content);

                    // Set the form's text fields
                    this.winNumLbl.Text = standings.response[0].won.ToString(); // Total Wins for season
                    this.lossNumLbl.Text = standings.response[0].lost.ToString(); // Total Losses for season
                    this.tieNumLbl.Text = standings.response[0].ties.ToString(); // Total Ties for season
                    this.posNumLbl.Text = standings.response[0].position.ToString(); // Current Division Rank
                    this.homeNumLbl.Text = standings.response[0].records.home.ToString(); // Current record for home games
                    this.roadNumLbl.Text = standings.response[0].records.road.ToString(); // Current record for road games
                    this.confNumLbl.Text = standings.response[0].records.conference.ToString(); // Current conference standings for team
                    this.divNumLbl.Text = standings.response[0].records.division.ToString(); // Current division standings for team
                    this.streakNumLbl.Text = getCurrentStreak(standings.response[0].streak); // Current Win/Loss Streak
                }
                else
                {
                    // Set error boolean and dialog result
                    apiErrorFallout();
                }

            }
            catch (Exception ex)
            {
                // Set error boolean and dialog result
                apiErrorFallout();
            }

        }

        private string getCurrentStreak(string apiStreak)
        {
            // Break down the streak from the API and turn it into a new format
            string streak = "";

            if (apiStreak.Contains("W"))
            {
                apiStreak = apiStreak.Replace("W", "");
                streak = $"{apiStreak} Wins";
            }
            else if (apiStreak.Contains("L"))
            {
                apiStreak = apiStreak.Replace("L", "");
                streak = $"{apiStreak} Losses";
            }
            else
            {
                streak = "None";
            }

            return streak;
        }

        private void playerBtn_Click(object sender, EventArgs e)
        {
            //Hide error message if visible
            if (this.errorLabel.Visible)
            {
                this.errorLabel.Hide();
            }

            // Open and display player form for list of players
            PlayersForm pf = new PlayersForm(this.year, this.teamNum, this.Text);
            pf.ShowDialog();
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            //Hide error message if visible
            if (this.errorLabel.Visible)
            {
                this.errorLabel.Hide();
            }

            // Open and display schedule form for list of games
            ScheduleForm sf = new ScheduleForm(this.teamNum, this.Text, this.year);
            sf.ShowDialog();
        }

        private void currentGameBtn_Click(object sender, EventArgs e)
        {
            //Hide error message if visible
            if (this.errorLabel.Visible)
            {
                this.errorLabel.Hide();
            }

            // Check that a current game is being played and has data
            bool liveGame = getGameStats();

            if (liveGame)
            {
                // Create and display TeamGameStats form
                TeamGameStatsForm tgs = new TeamGameStatsForm(this.currentGame, this.teamNameLbl.Text, gameNum, this.teamNum, oppTeamNum, this.year, this.homeOrAway);
                tgs.ShowDialog();
            }

        }

        private bool getGameStats()
        {
            bool liveGame = false;

            try
            {
                RestClient client = new RestClient($"https://v1.american-football.api-sports.io/games?league=1&season={this.year}&team={this.teamNum}&live=all"); // Sets API address
                RestRequest request = new RestRequest()  // Create GET request
                {
                    Method = Method.Get
                };
                request.AddHeader("x-rapidapi-key", this.apiKey);
                request.AddHeader("content-type", "application/json");
                RestResponse response = client.Execute(request);  // Submit Get request

                if (response.IsSuccessful && !response.Content.Contains("\"results\":0"))
                {
                    // Update boolean that there is a game with data
                    liveGame = true;

                    // Manipulate Json fields for deserializing - Make null fields blank strings or 0 integers
                    response.Content = response.Content.Replace("\"timestamp\":null", "\"timestamp\":0")
                        .Replace("\"quarter_1\":null", "\"quarter_1\":0").Replace("\"quarter_2\":null", "\"quarter_2\":0")
                        .Replace("\"quarter_3\":null", "\"quarter_3\":0").Replace("\"quarter_4\":null", "\"quarter_4\":0")
                        .Replace("\"overtime\":null", "\"overtime\":0").Replace("\"total\":null", "\"total\":0");
                    response.Content = response.Content.Replace("\":null", "\":\"\"");

                    // Mark the dialog result as OK and deserialize the Json data
                    this.DialogResult = DialogResult.OK;
                    this.currentGame = JsonConvert.DeserializeObject<Schedule>(response.Content);

                    // Set the form's data grid fields
                    for (int i = 0; i < this.currentGame.response.Count; i++)
                    {
                        // Set variables for when we move over to the TeamGameStats Form
                        this.homeTeam = this.currentGame.response[i].teams.home.name.Trim();
                        this.gameNum = this.currentGame.response[i].game.id;
                        if (homeTeam.Equals(this.teamNameLbl.Text))
                        {
                            this.oppTeamNum = this.currentGame.response[i].teams.away.id;
                        }
                        else
                        {
                            this.oppTeamNum = this.currentGame.response[i].teams.home.id;
                        }

                        // Determine if our selected team is the home or away team
                        if (homeTeam.Equals(this.teamNameLbl.Text))
                        {
                            this.homeOrAway = "Home";
                        }
                        else
                        {
                            this.homeOrAway = "Away";
                        }

                    }

                }
                else
                {
                    // Display error and set the dialog result
                    this.errorLabel.Text = "Error: There is not a current game for this team.";
                    this.errorLabel.Show();
                    this.DialogResult = DialogResult.Cancel;
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Display error and set the dialog result
                this.errorLabel.Text = "Error: Issue occurred with API. Close the form and try again.";
                this.errorLabel.Show();
                this.DialogResult = DialogResult.Cancel;
            }

            return liveGame;
        }

        private string getStadiumLocation(int teamID)
        {
            // Get and return the state for the team's stadium
            string location = "";

            switch (teamID)
            {
                case 1:
                    location = "Paradise, NV";
                    break;

                case 2:
                    location = "Jacksonville, FL";
                    break;

                case 3:
                    location = "Foxborough, MA";
                    break;

                case 4:
                    location = "East Rutherford, NJ";
                    break;

                case 5:
                    location = "Baltimore, MD";
                    break;

                case 6:
                    location = "Nashville, TN";
                    break;

                case 7:
                    location = "Detroit, MI";
                    break;

                case 8:
                    location = "Atlanta, GA";
                    break;

                case 9:
                    location = "Cleveland, OH";
                    break;

                case 10:
                    location = "Cincinnati, OH";
                    break;

                case 11:
                    location = "Glendale, AZ";
                    break;

                case 12:
                    location = "Philadelphia, PA";
                    break;

                case 13:
                    location = "East Rutherford, NJ";
                    break;

                case 14:
                    location = "Santa Clara, CA";
                    break;

                case 15:
                    location = "Green Bay, WI";
                    break;

                case 16:
                    location = "Chicago, IL";
                    break;

                case 17:
                    location = "Kansas City, MO";
                    break;

                case 18:
                    location = "Landover, MD";
                    break;

                case 19:
                    location = "Charlotte, NC";
                    break;

                case 20:
                    location = "Orchard Park, NY";
                    break;

                case 21:
                    location = "Indianapolis, IN";
                    break;

                case 22:
                    location = "Pittsburgh, PA";
                    break;

                case 23:
                    location = "Seattle, WA";
                    break;

                case 24:
                    location = "Tampa, FL";
                    break;

                case 25:
                    location = "Miami Gardens, FL";
                    break;

                case 26:
                    location = "Houston, TX";
                    break;

                case 27:
                    location = "New Orleans, LA";
                    break;

                case 28:
                    location = "Denver, CO";
                    break;

                case 29:
                    location = "Arlington, TX";
                    break;

                case 30:
                    location = "Inglewood, CA";
                    break;

                case 31:
                    location = "Inglewood, CA";
                    break;

                case 32:
                    location = "Minneapolis, MN";
                    break;
            }

            return location;
        }

        private void apiErrorFallout()
        {
            // Set error received to being true for parent program to display
            errorFound = true;
            this.DialogResult = DialogResult.Cancel;
        }

        public void errorCheck()
        {
            if (this.errorFound)
            {
                this.Close();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display support contact information
            MessageBox.Show("ProSync CS LLC \n\n1212 Sugar Blvd \nEau Claire, WI 54703 \n\n715-555-5525", "Contact Support");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the instructions and details for operating this form
            MessageBox.Show("The selected team's basic information like rank, standing, coach, owner, stadium, etc. are displayed. \n\nClicking " +
                "on the 'Roster' button will bring you to the roster window. \n\nClicking on the 'Schedule' button will display the team's schedule " +
                "for the current season. \n\nClicking the 'Current Game' button will display the team's statistics for a current game if available.",
                "Team Window Instructions");
        }
    }
}
