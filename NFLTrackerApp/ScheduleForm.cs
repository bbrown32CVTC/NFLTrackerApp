using Newtonsoft.Json;
using NFLTrackerApp.APIResponses;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFLTrackerApp
{
    public partial class ScheduleForm : Form
    {
        // Global Variables 
        Schedule schedule;
        int teamNum = 0;
        int year = 0;

        public ScheduleForm(int teamNum, string teamName, int year)
        {
            InitializeComponent();

            // Set global variables
            this.teamNum = teamNum;
            this.year = year;

            // Set the form and title to the team's name
            this.Text = $"{teamName} Schedule";
            this.teamNameLbl.Text = teamName;

            // Hide error message
            this.errorLabel.Hide();

            // Get the selected team's image as a stream and set it to the picturebox
            Stream imgStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream($"NFLTrackerApp.Images.{teamNum}.png");
            this.teamPB.Image = new Bitmap(imgStream);
            if (teamNum == 13)
            {
                // Resize the image for New York Jets logo
                this.teamPB.SizeMode = PictureBoxSizeMode.AutoSize;
            }

            // Gather schedule information from API and display it
            displaySchedule(teamNum, year);
        }


        private void displaySchedule(int teamNum, int year)
        {
            string apiKey = NFLKey.getKey();

            try
            {
                RestClient client = new RestClient($"https://v1.american-football.api-sports.io/games?league=1&season={year}&team={teamNum}"); // Sets API address
                RestRequest request = new RestRequest()  // Create GET request
                {
                    Method = Method.Get
                };
                request.AddHeader("x-rapidapi-key", apiKey);
                request.AddHeader("content-type", "application/json");
                RestResponse response = client.Execute(request);  // Submit Get request

                if (response.IsSuccessful && !response.Content.Contains("\"results\":0"))
                {
                    // Manipulate Json fields for deserializing - Make null fields blank strings or 0 integers
                    response.Content = response.Content.Replace("\"timestamp\":null", "\"timestamp\":0")
                        .Replace("\"quarter_1\":null", "\"quarter_1\":0").Replace("\"quarter_2\":null", "\"quarter_2\":0")
                        .Replace("\"quarter_3\":null", "\"quarter_3\":0").Replace("\"quarter_4\":null", "\"quarter_4\":0")
                        .Replace("\"overtime\":null", "\"overtime\":0").Replace("\"total\":null", "\"total\":0");
                    response.Content = response.Content.Replace("\":null", "\":\"\"");

                    // Mark the dialog result as OK and deserialize the Json data
                    this.DialogResult = DialogResult.OK;
                    this.schedule = JsonConvert.DeserializeObject<Schedule>(response.Content);


                    // Set the form's data grid fields
                    for (int i = 0; i < this.schedule.response.Count; i++)
                    {
                        // Set variables for each scheduled game add
                        string date = convertDate(this.schedule.response[i].game.date.date.Trim());
                        string week = this.schedule.response[i].game.week.Trim();
                        string type = this.schedule.response[i].game.stage.Trim();
                        string homeTeam = this.schedule.response[i].teams.home.name.Trim();
                        string awayTeam = this.schedule.response[i].teams.away.name.Trim();
                        string stadium = this.schedule.response[i].game.venue.name.Trim();
                        string location = this.schedule.response[i].game.venue.city.Trim();
                        string status = this.schedule.response[i].game.status.@long.Trim();
                        string score = $"{this.schedule.response[i].scores.home.total} - {this.schedule.response[i].scores.away.total}";
                        string outcome = "TBD"; // Left as To Be Determined (TBD) if the game is not finished

                        if (status.Equals("Finished") || status.Equals("Final/OT") || status.Equals("After Over Time"))
                        {
                            // Get the outcome of the finished game for team originally selected
                            string homeOrAway;

                            if (homeTeam.Equals(this.teamNameLbl.Text))
                            {
                                homeOrAway = "Home";
                            }
                            else
                            {
                                homeOrAway = "Away";
                            }

                            outcome = getOutcome(homeOrAway, schedule.response[i].scores.home.total, schedule.response[i].scores.away.total);
                        }

                        // Set invisible columns for sending to game stats form
                        int gameNum = this.schedule.response[i].game.id;
                        int oppTeamNum = 0;
                        if (homeTeam.Equals(this.teamNameLbl.Text))
                        {
                            oppTeamNum = this.schedule.response[i].teams.away.id;
                        }
                        else
                        {
                            oppTeamNum = this.schedule.response[i].teams.home.id;
                        }

                        // Create and add new rows to roster data grid view
                        this.scheduleDGV.Rows.Add(date, week, type, homeTeam, awayTeam, stadium, location, status, score, outcome, gameNum, oppTeamNum);
                    }

                }
                else
                {
                    // Display error and set the dialog result
                    this.errorLabel.Text = "Error: Issue occurred with API. Close the form and try again.";
                    this.errorLabel.Show();
                    this.DialogResult = DialogResult.Cancel;
                }

            }
            catch (Exception ex)
            {
                // Display error and set the dialog result
                this.errorLabel.Text = "Error: Issue occurred with API. Close the form and try again.";
                this.errorLabel.Show();
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private string convertDate(string date)
        {
            // Convert the date from yyyy-MM-dd to MM-dd-yyyy and return
            string gameDate = "";
            string day = "";
            string month = "";
            string year = "";

            if (date != null && !date.Equals(""))
            {
                string[] dateSplit = date.Split("-");
                day = dateSplit[2];
                month = dateSplit[1];
                year = dateSplit[0];
                gameDate = $"{month}-{day}-{year}";
            }

            return gameDate;
        }

        private string getOutcome(string homeOrAway, int homePoints, int awayPoints)
        {
            // Determine whether the original team selected won or lost
            string outcome = "";

            if (homePoints == awayPoints)  // Tied game
            {
                return "Tie";
            }

            switch (homeOrAway)
            {
                case "Home":
                    if (homePoints > awayPoints)
                    {
                        outcome = "Won";
                    }
                    else
                    {
                        outcome = "Lost";
                    }
                    break;

                case "Away":
                    if (homePoints > awayPoints)
                    {
                        outcome = "Lost";
                    }
                    else
                    {
                        outcome = "Won";
                    }
                    break;
            }

            return outcome;
        }

        private void scheduleDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the game number and opponent's API number of the current game selected
            int gameNum = Convert.ToInt32(this.scheduleDGV.SelectedRows[0].Cells[10].Value);
            int oppTeamNum = Convert.ToInt32(this.scheduleDGV.SelectedRows[0].Cells[11].Value);

            // Determine if the selected team is home or away for selected game
            string homeOrAway = "";
            string selectedTeam = this.teamNameLbl.Text.Trim();
            string currentHomeTeam = this.scheduleDGV.SelectedRows[0].Cells[3].Value.ToString();

            if (selectedTeam.Equals(currentHomeTeam))
            {
                // Selected team is home team
                homeOrAway = "Home";
            }
            else
            {
                homeOrAway = "Away";
            }



            // Create and display team game stats form
            TeamGameStatsForm tgs = new TeamGameStatsForm(this.schedule, this.teamNameLbl.Text, gameNum, this.teamNum, oppTeamNum, this.year, homeOrAway);
            tgs.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display support contact information
            MessageBox.Show("ProSync CS LLC \n\n1212 Sugar Blvd \nEau Claire, WI 54703 \n\n715-555-5525", "Contact Support");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the instructions and details for operating this form
            MessageBox.Show("All current scheduled games for the selected team are displayed. Clicking on a date will bring you to a " +
                "new window that will display additional statistics available for that game.", "Schedule Window Instructions");
        }

    }

}
