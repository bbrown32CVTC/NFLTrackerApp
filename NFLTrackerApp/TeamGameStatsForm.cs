using Newtonsoft.Json;
using NFLTrackerApp.APIResponses;
using RestSharp;
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
    public partial class TeamGameStatsForm : Form
    {

        // Global variables
        Scores currentGameScores;
        string oppTeamName;

        public TeamGameStatsForm(Schedule schedule, string selectedTeam, int gameNum, int teamNum, int oppTeamNum, int year, string homeOrAway)
        {
            InitializeComponent();

            // Get the selected teams' images as a stream and set it to the picturebox
            Stream imgStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream($"NFLTrackerApp.Images.{teamNum}.png");
            Stream imgStream2 = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream($"NFLTrackerApp.Images.{oppTeamNum}.png");

            this.teamPB.Image = new Bitmap(imgStream);
            this.teamPB2.Image = new Bitmap(imgStream2);

            if (teamNum == 13)
            {
                // Resize the image for New York Jets logo
                this.teamPB.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            if (oppTeamNum == 13)
            {
                // Resize the image for New York Jets logo
                this.teamPB2.SizeMode = PictureBoxSizeMode.AutoSize;
            }

            // Hide error message
            this.errorLabel.Hide();

            // Set labels for if the selected and opponent team are home or away
            if (homeOrAway.Equals("Home"))
            {
                this.hoaLbl.Text = "Home Team";
                this.hoaLbl2.Text = "Away Team";
            }
            else
            {
                this.hoaLbl2.Text = "Home Team";
                this.hoaLbl.Text = "Away Team";
            }

            // Get scores by quarter and opponent team's name from schedule object
            getQuarterScores(gameNum, schedule, homeOrAway);

            // Set form's text
            this.Text = $"{selectedTeam} vs. {this.oppTeamName}";

            // Display scores by quarter data
            displayQuarterScores(homeOrAway);

            // Get additional game stats
            getGameStats(gameNum, selectedTeam);
        }

        private void getGameStats(int gameID, string selectedTeam)
        {
            string apiKey = NFLKey.getKey();

            try
            {
                RestClient client = new RestClient($"https://v1.american-football.api-sports.io/games/statistics/teams?id={gameID}"); // Sets API address
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
                    GameStats stats = JsonConvert.DeserializeObject<GameStats>(response.Content);

                    // Set variables for both data grid views
                    int firstDowns = stats.response[0].statistics.first_downs.total;
                    int plays = stats.response[0].statistics.plays.total;
                    int yards = stats.response[0].statistics.yards.total;
                    string avgYards = stats.response[0].statistics.yards.yards_per_play.Trim();
                    int passYards = stats.response[0].statistics.passing.total;
                    string passComplete = stats.response[0].statistics.passing.comp_att.Trim();
                    int rushYards = stats.response[0].statistics.rushings.total;
                    int rushAttempts = stats.response[0].statistics.rushings.attempts;
                    int turnovers = stats.response[0].statistics.turnovers.total;
                    string possessionTime = stats.response[0].statistics.posession.total.Trim();
                    int interceptions = stats.response[0].statistics.interceptions.total;
                    int interceptionTDs = stats.response[0].statistics.int_touchdowns.total;
                    int fumblesRecovered = stats.response[0].statistics.fumbles_recovered.total;
                    int sacks = stats.response[0].statistics.sacks.total;
                    int safeties = stats.response[0].statistics.safeties.total;

                    int firstDowns2 = stats.response[1].statistics.first_downs.total;
                    int plays2 = stats.response[1].statistics.plays.total;
                    int yards2 = stats.response[1].statistics.yards.total;
                    string avgYards2 = stats.response[1].statistics.yards.yards_per_play.Trim();
                    int passYards2 = stats.response[1].statistics.passing.total;
                    string passComplete2 = stats.response[1].statistics.passing.comp_att.Trim();
                    int rushYards2 = stats.response[1].statistics.rushings.total;
                    int rushAttempts2 = stats.response[1].statistics.rushings.attempts;
                    int turnovers2 = stats.response[1].statistics.turnovers.total;
                    string possessionTime2 = stats.response[1].statistics.posession.total.Trim();
                    int interceptions2 = stats.response[1].statistics.interceptions.total;
                    int interceptionTDs2 = stats.response[1].statistics.int_touchdowns.total;
                    int fumblesRecovered2 = stats.response[1].statistics.fumbles_recovered.total;
                    int sacks2 = stats.response[1].statistics.sacks.total;
                    int safeties2 = stats.response[1].statistics.safeties.total;

                    // Set data grid view for selected team and opponent
                    if (selectedTeam.Equals(stats.response[0].team.name.Trim()))
                    {
                        // First response was for the selected team and second response was for opponent
                        this.selectedTeamDGV.Rows.Add(firstDowns, plays, yards, avgYards, passYards, passComplete, rushYards,
                            rushAttempts, turnovers, possessionTime, interceptions, interceptionTDs, fumblesRecovered, sacks,
                            safeties);
                        this.oppTeamDGV.Rows.Add(firstDowns2, plays2, yards2, avgYards2, passYards2, passComplete2, rushYards2, 
                            rushAttempts2, turnovers2, possessionTime2, interceptions2, interceptionTDs2, fumblesRecovered2, sacks2,
                            safeties2);
                    }
                    else
                    {
                        // Second response was for the selected team and first response was for opponent
                        this.selectedTeamDGV.Rows.Add(firstDowns2, plays2, yards2, avgYards2, passYards2, passComplete2, rushYards2,
                            rushAttempts2, turnovers2, possessionTime2, interceptions2, interceptionTDs2, fumblesRecovered2, sacks2,
                            safeties2);
                        this.oppTeamDGV.Rows.Add(firstDowns, plays, yards, avgYards, passYards, passComplete, rushYards,
                            rushAttempts, turnovers, possessionTime, interceptions, interceptionTDs, fumblesRecovered, sacks,
                            safeties);
                    }

                }
                else
                {
                    // Display error and set the dialog result
                    this.errorLabel.Text = "Error: No game data available to display. Close the form.";
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

        private void getQuarterScores(int gameNum, Schedule fullSchedule, string homeOrAway)
        {
            // Get scores per quarter from schedule and opponent team's name
            for (int i = 0; i < fullSchedule.response.Count; i++)
            {
                if (fullSchedule.response[i].game.id == gameNum)
                {
                    this.currentGameScores = fullSchedule.response[i].scores;

                    if (homeOrAway.Equals("Home"))
                    {
                        // Selected team is home team
                        this.oppTeamName = fullSchedule.response[i].teams.away.name.Trim();
                    }
                    else
                    {
                        // Selected team is away team
                        this.oppTeamName = fullSchedule.response[i].teams.home.name.Trim();
                    }
                    
                    break;
                }
            }

        }

        private void displayQuarterScores(string homeOrAway)
        {
            // Set the total score
            if (homeOrAway.Equals("Home"))
            {
                // Selected team is home team
                this.scoreLbl.Text = $"Score: {this.currentGameScores.home.total}";
                this.q1Lbl.Text = $"Q1: {this.currentGameScores.home.quarter_1} Points";
                this.q2Lbl.Text = $"Q2: {this.currentGameScores.home.quarter_2} Points";
                this.q3Lbl.Text = $"Q3: {this.currentGameScores.home.quarter_3} Points";
                this.q4Lbl.Text = $"Q4: {this.currentGameScores.home.quarter_4} Points";
                this.otLbl.Text = $"OT: {this.currentGameScores.home.overtime} Points";
                this.scoreLbl2.Text = $"Score: {this.currentGameScores.away.total}";
                this.q1Lbl2.Text = $"Q1: {this.currentGameScores.away.quarter_1} Points";
                this.q2Lbl2.Text = $"Q2: {this.currentGameScores.away.quarter_2} Points";
                this.q3Lbl2.Text = $"Q3: {this.currentGameScores.away.quarter_3} Points";
                this.q4Lbl2.Text = $"Q4: {this.currentGameScores.away.quarter_4} Points";
                this.otLbl2.Text = $"OT: {this.currentGameScores.away.overtime} Points";

            }
            else
            {
                // Selected team is away team
                this.scoreLbl.Text = $"Score: {this.currentGameScores.away.total}";
                this.q1Lbl.Text = $"Q1: {this.currentGameScores.away.quarter_1} Points";
                this.q2Lbl.Text = $"Q2: {this.currentGameScores.away.quarter_2} Points";
                this.q3Lbl.Text = $"Q3: {this.currentGameScores.away.quarter_3} Points";
                this.q4Lbl.Text = $"Q4: {this.currentGameScores.away.quarter_4} Points";
                this.otLbl.Text = $"OT: {this.currentGameScores.away.overtime} Points";
                this.scoreLbl2.Text = $"Score: {this.currentGameScores.home.total}";
                this.q1Lbl2.Text = $"Q1: {this.currentGameScores.home.quarter_1} Points";
                this.q2Lbl2.Text = $"Q2: {this.currentGameScores.home.quarter_2} Points";
                this.q3Lbl2.Text = $"Q3: {this.currentGameScores.home.quarter_3} Points";
                this.q4Lbl2.Text = $"Q4: {this.currentGameScores.home.quarter_4} Points";
                this.otLbl2.Text = $"OT: {this.currentGameScores.home.overtime} Points";
            }

        }
    }
}
