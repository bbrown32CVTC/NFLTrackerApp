namespace NFLTrackerApp
{
    partial class ScheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            teamNameLbl = new Label();
            teamPB = new PictureBox();
            errorLabel = new Label();
            scheduleDGV = new DataGridView();
            Date = new DataGridViewButtonColumn();
            Week = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            HomeTeam = new DataGridViewTextBoxColumn();
            AwayTeam = new DataGridViewTextBoxColumn();
            Stadium = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            Outcome = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            OppNumber = new DataGridViewTextBoxColumn();
            scheduleLbl = new Label();
            menu = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)teamPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scheduleDGV).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameLbl
            // 
            teamNameLbl.AutoSize = true;
            teamNameLbl.Font = new Font("Papyrus", 36F, FontStyle.Bold);
            teamNameLbl.Location = new Point(290, 81);
            teamNameLbl.Name = "teamNameLbl";
            teamNameLbl.Size = new Size(299, 76);
            teamNameLbl.TabIndex = 37;
            teamNameLbl.Text = "Team Name";
            // 
            // teamPB
            // 
            teamPB.Location = new Point(12, 35);
            teamPB.Name = "teamPB";
            teamPB.Size = new Size(150, 150);
            teamPB.SizeMode = PictureBoxSizeMode.CenterImage;
            teamPB.TabIndex = 36;
            teamPB.TabStop = false;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Verdana", 12F, FontStyle.Bold);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(12, 710);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(60, 18);
            errorLabel.TabIndex = 38;
            errorLabel.Text = "Error:";
            // 
            // scheduleDGV
            // 
            scheduleDGV.AllowUserToAddRows = false;
            scheduleDGV.AllowUserToDeleteRows = false;
            scheduleDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            scheduleDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            scheduleDGV.BorderStyle = BorderStyle.Fixed3D;
            scheduleDGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            scheduleDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scheduleDGV.Columns.AddRange(new DataGridViewColumn[] { Date, Week, Type, HomeTeam, AwayTeam, Stadium, Location, Status, Score, Outcome, Number, OppNumber });
            scheduleDGV.Location = new Point(20, 245);
            scheduleDGV.Name = "scheduleDGV";
            scheduleDGV.ReadOnly = true;
            scheduleDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            scheduleDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            scheduleDGV.Size = new Size(1016, 428);
            scheduleDGV.TabIndex = 39;
            scheduleDGV.CellContentClick += scheduleDGV_CellContentClick;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Resizable = DataGridViewTriState.True;
            Date.SortMode = DataGridViewColumnSortMode.Automatic;
            Date.Width = 56;
            // 
            // Week
            // 
            Week.HeaderText = "Week";
            Week.Name = "Week";
            Week.ReadOnly = true;
            Week.Width = 61;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
            Type.Width = 56;
            // 
            // HomeTeam
            // 
            HomeTeam.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            HomeTeam.HeaderText = "Home Team";
            HomeTeam.Name = "HomeTeam";
            HomeTeam.ReadOnly = true;
            HomeTeam.Width = 96;
            // 
            // AwayTeam
            // 
            AwayTeam.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AwayTeam.HeaderText = "Away Team";
            AwayTeam.Name = "AwayTeam";
            AwayTeam.ReadOnly = true;
            AwayTeam.Width = 92;
            // 
            // Stadium
            // 
            Stadium.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Stadium.HeaderText = "Stadium";
            Stadium.Name = "Stadium";
            Stadium.ReadOnly = true;
            Stadium.Width = 76;
            // 
            // Location
            // 
            Location.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Location.HeaderText = "Location";
            Location.Name = "Location";
            Location.ReadOnly = true;
            Location.Width = 78;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 64;
            // 
            // Score
            // 
            Score.HeaderText = "Score";
            Score.Name = "Score";
            Score.ReadOnly = true;
            Score.Width = 61;
            // 
            // Outcome
            // 
            Outcome.HeaderText = "Outcome";
            Outcome.Name = "Outcome";
            Outcome.ReadOnly = true;
            Outcome.Width = 82;
            // 
            // Number
            // 
            Number.HeaderText = "Number";
            Number.Name = "Number";
            Number.ReadOnly = true;
            Number.Visible = false;
            Number.Width = 76;
            // 
            // OppNumber
            // 
            OppNumber.HeaderText = "OppNumber";
            OppNumber.Name = "OppNumber";
            OppNumber.ReadOnly = true;
            OppNumber.Visible = false;
            OppNumber.Width = 99;
            // 
            // scheduleLbl
            // 
            scheduleLbl.AutoSize = true;
            scheduleLbl.Font = new Font("Verdana", 21.75F, FontStyle.Bold | FontStyle.Underline);
            scheduleLbl.Location = new Point(426, 207);
            scheduleLbl.Name = "scheduleLbl";
            scheduleLbl.Size = new Size(163, 35);
            scheduleLbl.TabIndex = 40;
            scheduleLbl.Text = "Schedule";
            // 
            // menu
            // 
            menu.Font = new Font("Verdana", 9.75F);
            menu.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, aboutToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1052, 24);
            menu.TabIndex = 145;
            menu.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(47, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(58, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1052, 735);
            Controls.Add(menu);
            Controls.Add(scheduleLbl);
            Controls.Add(scheduleDGV);
            Controls.Add(errorLabel);
            Controls.Add(teamNameLbl);
            Controls.Add(teamPB);
            Name = "ScheduleForm";
            Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)teamPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)scheduleDGV).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label teamNameLbl;
        private PictureBox teamPB;
        private Label errorLabel;
        private DataGridView scheduleDGV;
        private Label scheduleLbl;
        private DataGridViewButtonColumn Date;
        private DataGridViewTextBoxColumn Week;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn HomeTeam;
        private DataGridViewTextBoxColumn AwayTeam;
        private DataGridViewTextBoxColumn Stadium;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn Outcome;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn OppNumber;
        private MenuStrip menu;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}