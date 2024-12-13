namespace NFLTrackerApp
{
    partial class TeamGameStatsForm
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
            versusLbl = new Label();
            teamPB = new PictureBox();
            teamPB2 = new PictureBox();
            hoaLbl = new Label();
            hoaLbl2 = new Label();
            errorLabel = new Label();
            scoreLbl = new Label();
            scoreLbl2 = new Label();
            q1Lbl = new Label();
            q1Lbl2 = new Label();
            q2Lbl = new Label();
            q3Lbl = new Label();
            q4Lbl = new Label();
            q4Lbl2 = new Label();
            q3Lbl2 = new Label();
            q2Lbl2 = new Label();
            otLbl = new Label();
            otLbl2 = new Label();
            selectedTeamDGV = new DataGridView();
            FirstDowns = new DataGridViewTextBoxColumn();
            Plays = new DataGridViewTextBoxColumn();
            Yards = new DataGridViewTextBoxColumn();
            AvgYards = new DataGridViewTextBoxColumn();
            PassYards = new DataGridViewTextBoxColumn();
            PassComp = new DataGridViewTextBoxColumn();
            RushYards = new DataGridViewTextBoxColumn();
            RushAttempts = new DataGridViewTextBoxColumn();
            Turnovers = new DataGridViewTextBoxColumn();
            PossessionTotal = new DataGridViewTextBoxColumn();
            Interceptions = new DataGridViewTextBoxColumn();
            IntTouchdowns = new DataGridViewTextBoxColumn();
            FumblesRecovered = new DataGridViewTextBoxColumn();
            Sacks = new DataGridViewTextBoxColumn();
            Safeties = new DataGridViewTextBoxColumn();
            oppTeamDGV = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            intTouchdown = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)teamPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamPB2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedTeamDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oppTeamDGV).BeginInit();
            SuspendLayout();
            // 
            // versusLbl
            // 
            versusLbl.AutoSize = true;
            versusLbl.Font = new Font("Papyrus", 72F, FontStyle.Bold, GraphicsUnit.Point);
            versusLbl.Location = new Point(397, 38);
            versusLbl.Name = "versusLbl";
            versusLbl.Size = new Size(169, 151);
            versusLbl.TabIndex = 37;
            versusLbl.Text = "vs.";
            // 
            // teamPB
            // 
            teamPB.Location = new Point(12, 38);
            teamPB.Name = "teamPB";
            teamPB.Size = new Size(150, 150);
            teamPB.SizeMode = PictureBoxSizeMode.CenterImage;
            teamPB.TabIndex = 36;
            teamPB.TabStop = false;
            // 
            // teamPB2
            // 
            teamPB2.Location = new Point(728, 38);
            teamPB2.Name = "teamPB2";
            teamPB2.Size = new Size(150, 150);
            teamPB2.SizeMode = PictureBoxSizeMode.CenterImage;
            teamPB2.TabIndex = 38;
            teamPB2.TabStop = false;
            // 
            // hoaLbl
            // 
            hoaLbl.AutoSize = true;
            hoaLbl.Font = new Font("Verdana", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            hoaLbl.Location = new Point(12, 223);
            hoaLbl.Name = "hoaLbl";
            hoaLbl.Size = new Size(197, 32);
            hoaLbl.TabIndex = 39;
            hoaLbl.Text = "HomeOrAway";
            // 
            // hoaLbl2
            // 
            hoaLbl2.AutoSize = true;
            hoaLbl2.Font = new Font("Verdana", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            hoaLbl2.Location = new Point(728, 222);
            hoaLbl2.Name = "hoaLbl2";
            hoaLbl2.Size = new Size(197, 32);
            hoaLbl2.TabIndex = 40;
            hoaLbl2.Text = "HomeOrAway";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(12, 630);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(60, 18);
            errorLabel.TabIndex = 41;
            errorLabel.Text = "Error:";
            // 
            // scoreLbl
            // 
            scoreLbl.AutoSize = true;
            scoreLbl.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            scoreLbl.Location = new Point(12, 374);
            scoreLbl.Name = "scoreLbl";
            scoreLbl.Size = new Size(92, 29);
            scoreLbl.TabIndex = 42;
            scoreLbl.Text = "Score:";
            // 
            // scoreLbl2
            // 
            scoreLbl2.AutoSize = true;
            scoreLbl2.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            scoreLbl2.Location = new Point(728, 373);
            scoreLbl2.Name = "scoreLbl2";
            scoreLbl2.Size = new Size(92, 29);
            scoreLbl2.TabIndex = 43;
            scoreLbl2.Text = "Score:";
            // 
            // q1Lbl
            // 
            q1Lbl.AutoSize = true;
            q1Lbl.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            q1Lbl.Location = new Point(12, 412);
            q1Lbl.Name = "q1Lbl";
            q1Lbl.Size = new Size(46, 23);
            q1Lbl.TabIndex = 44;
            q1Lbl.Text = "Q1:";
            // 
            // q1Lbl2
            // 
            q1Lbl2.AutoSize = true;
            q1Lbl2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            q1Lbl2.Location = new Point(728, 411);
            q1Lbl2.Name = "q1Lbl2";
            q1Lbl2.Size = new Size(46, 23);
            q1Lbl2.TabIndex = 45;
            q1Lbl2.Text = "Q1:";
            // 
            // q2Lbl
            // 
            q2Lbl.AutoSize = true;
            q2Lbl.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            q2Lbl.Location = new Point(12, 452);
            q2Lbl.Name = "q2Lbl";
            q2Lbl.Size = new Size(46, 23);
            q2Lbl.TabIndex = 46;
            q2Lbl.Text = "Q2:";
            // 
            // q3Lbl
            // 
            q3Lbl.AutoSize = true;
            q3Lbl.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            q3Lbl.Location = new Point(12, 489);
            q3Lbl.Name = "q3Lbl";
            q3Lbl.Size = new Size(46, 23);
            q3Lbl.TabIndex = 47;
            q3Lbl.Text = "Q3:";
            // 
            // q4Lbl
            // 
            q4Lbl.AutoSize = true;
            q4Lbl.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            q4Lbl.Location = new Point(12, 526);
            q4Lbl.Name = "q4Lbl";
            q4Lbl.Size = new Size(46, 23);
            q4Lbl.TabIndex = 48;
            q4Lbl.Text = "Q4:";
            // 
            // q4Lbl2
            // 
            q4Lbl2.AutoSize = true;
            q4Lbl2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            q4Lbl2.Location = new Point(728, 525);
            q4Lbl2.Name = "q4Lbl2";
            q4Lbl2.Size = new Size(46, 23);
            q4Lbl2.TabIndex = 51;
            q4Lbl2.Text = "Q4:";
            // 
            // q3Lbl2
            // 
            q3Lbl2.AutoSize = true;
            q3Lbl2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            q3Lbl2.Location = new Point(728, 488);
            q3Lbl2.Name = "q3Lbl2";
            q3Lbl2.Size = new Size(46, 23);
            q3Lbl2.TabIndex = 50;
            q3Lbl2.Text = "Q3:";
            // 
            // q2Lbl2
            // 
            q2Lbl2.AutoSize = true;
            q2Lbl2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            q2Lbl2.Location = new Point(728, 451);
            q2Lbl2.Name = "q2Lbl2";
            q2Lbl2.Size = new Size(46, 23);
            q2Lbl2.TabIndex = 49;
            q2Lbl2.Text = "Q2:";
            // 
            // otLbl
            // 
            otLbl.AutoSize = true;
            otLbl.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            otLbl.Location = new Point(12, 562);
            otLbl.Name = "otLbl";
            otLbl.Size = new Size(44, 23);
            otLbl.TabIndex = 52;
            otLbl.Text = "OT:";
            // 
            // otLbl2
            // 
            otLbl2.AutoSize = true;
            otLbl2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            otLbl2.Location = new Point(728, 561);
            otLbl2.Name = "otLbl2";
            otLbl2.Size = new Size(44, 23);
            otLbl2.TabIndex = 53;
            otLbl2.Text = "OT:";
            // 
            // selectedTeamDGV
            // 
            selectedTeamDGV.AllowUserToAddRows = false;
            selectedTeamDGV.AllowUserToDeleteRows = false;
            selectedTeamDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            selectedTeamDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedTeamDGV.Columns.AddRange(new DataGridViewColumn[] { FirstDowns, Plays, Yards, AvgYards, PassYards, PassComp, RushYards, RushAttempts, Turnovers, PossessionTotal, Interceptions, IntTouchdowns, FumblesRecovered, Sacks, Safeties });
            selectedTeamDGV.Location = new Point(12, 278);
            selectedTeamDGV.Name = "selectedTeamDGV";
            selectedTeamDGV.ReadOnly = true;
            selectedTeamDGV.RowTemplate.Height = 25;
            selectedTeamDGV.Size = new Size(326, 78);
            selectedTeamDGV.TabIndex = 54;
            // 
            // FirstDowns
            // 
            FirstDowns.HeaderText = "First Downs";
            FirstDowns.Name = "FirstDowns";
            FirstDowns.ReadOnly = true;
            FirstDowns.Width = 86;
            // 
            // Plays
            // 
            Plays.HeaderText = "Plays";
            Plays.Name = "Plays";
            Plays.ReadOnly = true;
            Plays.Width = 59;
            // 
            // Yards
            // 
            Yards.HeaderText = "Yards";
            Yards.Name = "Yards";
            Yards.ReadOnly = true;
            Yards.Width = 60;
            // 
            // AvgYards
            // 
            AvgYards.HeaderText = "Avg Yards";
            AvgYards.Name = "AvgYards";
            AvgYards.ReadOnly = true;
            AvgYards.Width = 78;
            // 
            // PassYards
            // 
            PassYards.HeaderText = "Passing Yards";
            PassYards.Name = "PassYards";
            PassYards.ReadOnly = true;
            PassYards.Width = 95;
            // 
            // PassComp
            // 
            PassComp.HeaderText = "Pass Completions";
            PassComp.Name = "PassComp";
            PassComp.ReadOnly = true;
            PassComp.Width = 115;
            // 
            // RushYards
            // 
            RushYards.HeaderText = "Rushing Yards";
            RushYards.Name = "RushYards";
            RushYards.ReadOnly = true;
            RushYards.Width = 97;
            // 
            // RushAttempts
            // 
            RushAttempts.HeaderText = "Rush Attempts";
            RushAttempts.Name = "RushAttempts";
            RushAttempts.ReadOnly = true;
            RushAttempts.Width = 101;
            // 
            // Turnovers
            // 
            Turnovers.HeaderText = "Turnovers";
            Turnovers.Name = "Turnovers";
            Turnovers.ReadOnly = true;
            Turnovers.Width = 84;
            // 
            // PossessionTotal
            // 
            PossessionTotal.HeaderText = "Possession Total";
            PossessionTotal.Name = "PossessionTotal";
            PossessionTotal.ReadOnly = true;
            PossessionTotal.Width = 107;
            // 
            // Interceptions
            // 
            Interceptions.HeaderText = "Interceptions";
            Interceptions.Name = "Interceptions";
            Interceptions.ReadOnly = true;
            Interceptions.Width = 101;
            // 
            // IntTouchdowns
            // 
            IntTouchdowns.HeaderText = "Interception TDs";
            IntTouchdowns.Name = "IntTouchdowns";
            IntTouchdowns.ReadOnly = true;
            IntTouchdowns.Width = 108;
            // 
            // FumblesRecovered
            // 
            FumblesRecovered.HeaderText = "Fumbles Recovered";
            FumblesRecovered.Name = "FumblesRecovered";
            FumblesRecovered.ReadOnly = true;
            FumblesRecovered.Width = 124;
            // 
            // Sacks
            // 
            Sacks.HeaderText = "Sacks";
            Sacks.Name = "Sacks";
            Sacks.ReadOnly = true;
            Sacks.Width = 61;
            // 
            // Safeties
            // 
            Safeties.HeaderText = "Safeties";
            Safeties.Name = "Safeties";
            Safeties.ReadOnly = true;
            Safeties.Width = 72;
            // 
            // oppTeamDGV
            // 
            oppTeamDGV.AllowUserToAddRows = false;
            oppTeamDGV.AllowUserToDeleteRows = false;
            oppTeamDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            oppTeamDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            oppTeamDGV.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, intTouchdown, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14 });
            oppTeamDGV.Location = new Point(728, 277);
            oppTeamDGV.Name = "oppTeamDGV";
            oppTeamDGV.ReadOnly = true;
            oppTeamDGV.RowTemplate.Height = 25;
            oppTeamDGV.Size = new Size(327, 78);
            oppTeamDGV.TabIndex = 55;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "First Downs";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 86;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Plays";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 59;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Yards";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Avg Yards";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 78;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Passing Yards";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 95;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Pass Completions";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 115;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Rushing Yards";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 97;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Rush Attempts";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 101;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Turnovers";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 84;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Possession Total";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 107;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Interceptions";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 101;
            // 
            // intTouchdown
            // 
            intTouchdown.HeaderText = "Interception TDs";
            intTouchdown.Name = "intTouchdown";
            intTouchdown.ReadOnly = true;
            intTouchdown.Width = 108;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Fumbles Recovered";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 124;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Sacks";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            dataGridViewTextBoxColumn13.Width = 61;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Safeties";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            dataGridViewTextBoxColumn14.Width = 72;
            // 
            // TeamGameStatsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 658);
            Controls.Add(oppTeamDGV);
            Controls.Add(selectedTeamDGV);
            Controls.Add(otLbl2);
            Controls.Add(otLbl);
            Controls.Add(q4Lbl2);
            Controls.Add(q3Lbl2);
            Controls.Add(q2Lbl2);
            Controls.Add(q4Lbl);
            Controls.Add(q3Lbl);
            Controls.Add(q2Lbl);
            Controls.Add(q1Lbl2);
            Controls.Add(q1Lbl);
            Controls.Add(scoreLbl2);
            Controls.Add(scoreLbl);
            Controls.Add(errorLabel);
            Controls.Add(hoaLbl2);
            Controls.Add(hoaLbl);
            Controls.Add(teamPB2);
            Controls.Add(versusLbl);
            Controls.Add(teamPB);
            Name = "TeamGameStatsForm";
            Text = "Game Stats";
            ((System.ComponentModel.ISupportInitialize)teamPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamPB2).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectedTeamDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)oppTeamDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label versusLbl;
        private PictureBox teamPB;
        private PictureBox teamPB2;
        private Label hoaLbl;
        private Label hoaLbl2;
        private Label errorLabel;
        private Label scoreLbl;
        private Label scoreLbl2;
        private Label q1Lbl;
        private Label q1Lbl2;
        private Label q2Lbl;
        private Label q3Lbl;
        private Label q4Lbl;
        private Label q4Lbl2;
        private Label q3Lbl2;
        private Label q2Lbl2;
        private Label otLbl;
        private Label otLbl2;
        private DataGridView selectedTeamDGV;
        private DataGridView oppTeamDGV;
        private DataGridViewTextBoxColumn FirstDowns;
        private DataGridViewTextBoxColumn Plays;
        private DataGridViewTextBoxColumn Yards;
        private DataGridViewTextBoxColumn AvgYards;
        private DataGridViewTextBoxColumn PassYards;
        private DataGridViewTextBoxColumn PassComp;
        private DataGridViewTextBoxColumn RushYards;
        private DataGridViewTextBoxColumn RushAttempts;
        private DataGridViewTextBoxColumn Turnovers;
        private DataGridViewTextBoxColumn PossessionTotal;
        private DataGridViewTextBoxColumn Interceptions;
        private DataGridViewTextBoxColumn IntTouchdowns;
        private DataGridViewTextBoxColumn FumblesRecovered;
        private DataGridViewTextBoxColumn Sacks;
        private DataGridViewTextBoxColumn Safeties;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn intTouchdown;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}