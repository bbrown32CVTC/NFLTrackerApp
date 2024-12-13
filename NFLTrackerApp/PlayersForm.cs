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
using System.Windows.Forms.VisualStyles;

namespace NFLTrackerApp
{
    public partial class PlayersForm : Form
    {
        // Global Variables
        private string apiKey = NFLKey.getKey();
        private int teamNum = 0;
        private int year = 0;

        public PlayersForm(int year, int teamNum, string teamName)
        {
            InitializeComponent();

            // Hide error message
            this.errorLabel.Hide();

            // Set global variables
            this.year = year;
            this.teamNum = teamNum;

            // Get the selected team's image as a stream and set it to the picturebox
            Stream imgStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream($"NFLTrackerApp.Images.{this.teamNum}.png");
            this.teamPB.Image = new Bitmap(imgStream);
            if (this.teamNum == 13)
            {
                // Resize the image for New York Jets logo
                this.teamPB.SizeMode = PictureBoxSizeMode.AutoSize;
            }

            // Set the form and title to the team's name
            this.Text = $"{teamName} Roster";
            this.teamNameLbl.Text = teamName;

            // Get roster from API and set it to the data grid view
            setRoster(this.year, this.teamNum);

        }

        private void setRoster(int year, int teamNum)
        {

            try
            {
                RestClient client = new RestClient($"https://v1.american-football.api-sports.io/players?season={year}&team={teamNum}"); // Sets API address
                RestRequest request = new RestRequest()  // Create GET request
                {
                    Method = Method.Get
                };
                request.AddHeader("x-rapidapi-key", this.apiKey);
                request.AddHeader("content-type", "application/json");
                RestResponse response = client.Execute(request);  // Submit Get request

                if (response.IsSuccessful && !response.Content.Contains("\"results\":0"))
                {
                    // Manipulate Json fields for deserializing - Make null fields blank strings or 0 integers
                    response.Content = response.Content.Replace("position\":", "playerPosition\":")
                        .Replace("age\":null", "age\":0").Replace("number\":null", "number\":0").Replace("experience\":null", "experience\":0");
                    response.Content = response.Content.Replace("\":null", "\":\"\"");

                    // Mark the dialog result as OK and deserialize the Json data
                    this.DialogResult = DialogResult.OK;
                    Players players = JsonConvert.DeserializeObject<Players>(response.Content);

                    // Set the form's data grid fields
                    for (int i = 0; i < players.response.Count; i++)
                    {
                        // Skip adding if the name is set to "Team" due to it being blank data
                        if (players.response[i].name.Equals("Team"))
                        {
                            continue;
                        }

                        // Set variables for roster add
                        string name = players.response[i].name.Trim();
                        string group = players.response[i].group.Trim();
                        string position = players.response[i].playerPosition.Trim();
                        int number = players.response[i].number;
                        string college = players.response[i].college.Trim();
                        int experience = players.response[i].experience;

                        // Set invisible column fields that will be passed on to the PlayerStats Form when player button clicked
                        int playerID = players.response[i].id;
                        string image = players.response[i].image.Trim();

                        // Create and add new rows to roster data grid view
                        this.rosterDGV.Rows.Add(name, group, position, number, college, experience, playerID, image);
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

        private void rosterDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the player's information for sending to the PlayerStats form
            string playerName = this.rosterDGV.SelectedRows[0].Cells[0].Value.ToString();
            int playerID = Convert.ToInt32(this.rosterDGV.SelectedRows[0].Cells[6].Value);
            string image = this.rosterDGV.SelectedRows[0].Cells[7].Value.ToString();

            // Create and display the PlayerStats form
            PlayerStatsForm psf = new PlayerStatsForm(playerName, playerID, image, this.teamNum, this.year);
            psf.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display support contact information
            MessageBox.Show("ProSync CS LLC \n\n1212 Sugar Blvd \nEau Claire, WI 54703 \n\n715-555-5525", "Contact Support");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the instructions and details for operating this form
            MessageBox.Show("All current players for the selected team are displayed. Clicking on a player's name will bring you to a " +
                "new window that will display additional statistics for that player.", "Roster Window Instructions");
        }
    }
}
