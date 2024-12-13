using Newtonsoft.Json;
using NFLTrackerApp.APIResponses;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace NFLTrackerApp
{
    public partial class PlayerStatsForm : Form
    {
        public PlayerStatsForm(string playerName, int playerID, string imageURL, int teamNum, int year)
        {
            InitializeComponent();

            // Hide error message
            this.errorLabel.Hide();

            // Update form and text to player's name
            this.Text = $"{playerName} - Statistics";
            this.playerNameLbl.Text = playerName;

            // Get the selected player's image and set it to the picturebox
            this.playerPB.Load(imageURL);

            // Resize the picturebox to the size of the player's image
            this.playerPB.SizeMode = PictureBoxSizeMode.AutoSize;

            // Get and display the players stats
            displayPlayerStats(playerID, teamNum, year);
        }

        private void displayPlayerStats(int playerID, int teamNum, int year)
        {
            string apiKey = NFLKey.getKey();

            try
            {
                RestClient client = new RestClient($"https://v1.american-football.api-sports.io/players/statistics?id={playerID}&season={year}&team={teamNum}"); // Sets API address
                RestRequest request = new RestRequest()  // Create GET request
                {
                    Method = Method.Get
                };
                request.AddHeader("x-rapidapi-key", apiKey);
                request.AddHeader("content-type", "application/json");
                RestResponse response = client.Execute(request);  // Submit Get request

                if (response.IsSuccessful && !response.Content.Contains("\"results\":0"))
                {
                    // Manipulate Json fields for deserializing - Make null fields blank strings and set "teams" to "playerTeams
                    response.Content = response.Content.Replace("\":null", "\":\"\"").Replace("\"teams\":", "\"playerTeams\":");

                    // Mark the dialog result as OK and deserialize the Json data
                    this.DialogResult = DialogResult.OK;
                    PlayerStats stats = JsonConvert.DeserializeObject<PlayerStats>(response.Content);

                    // Create ArrayList for adding the player's information
                    ArrayList values = new ArrayList();

                    // Set the form's data grid columns and fields
                    foreach (Group g in stats.response[0].playerTeams[0].groups)
                    {
                        for (int i = 0; i < g.statistics.Count; i++)
                        {
                            // Set the data for the data grid view
                            string statName = g.statistics[i].name;
                            string value = g.statistics[i].value;

                            // Create column for data grid view and save value to an ArrayList for adding the row
                            this.playerStatsDGV.Columns.Add(new DataGridViewColumn() {HeaderText = statName, CellTemplate = new DataGridViewTextBoxCell()});
                            values.Add(value);
                        }
                    }

                    // Add the ArrayList as a row to the datagridview
                    this.playerStatsDGV.Rows.Add(values.ToArray());

                }
                else
                {
                    // Hide the datagridview since there is not data to display
                    this.playerStatsDGV.Visible = false;

                    // Display error and set the dialog result
                    this.errorLabel.Text = "Error: There are no additional stats available to display for this player";
                    this.errorLabel.Show();
                    this.DialogResult = DialogResult.Cancel;
                }

            }
            catch (Exception ex)
            {
                // Hide the datagridview since there is not data to display
                this.playerStatsDGV.Visible = false;

                // Display error and set the dialog result
                this.errorLabel.Text = "Error: Issue occurred with API. Close the form and try again.";
                this.errorLabel.Show();
                this.DialogResult = DialogResult.Cancel;
            }
        }

    }

}
