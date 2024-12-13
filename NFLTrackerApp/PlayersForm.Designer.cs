using System.Numerics;

namespace NFLTrackerApp
{
    partial class PlayersForm
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
            rosterDGV = new DataGridView();
            Player = new DataGridViewButtonColumn();
            Group = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Number = new DataGridViewTextBoxColumn();
            College = new DataGridViewTextBoxColumn();
            YearsOfExp = new DataGridViewTextBoxColumn();
            PlayerID = new DataGridViewTextBoxColumn();
            Image = new DataGridViewTextBoxColumn();
            teamPB = new PictureBox();
            teamNameLbl = new Label();
            errorLabel = new Label();
            rosterLbl = new Label();
            menu = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)rosterDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teamPB).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // rosterDGV
            // 
            rosterDGV.AllowUserToAddRows = false;
            rosterDGV.AllowUserToDeleteRows = false;
            rosterDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            rosterDGV.BorderStyle = BorderStyle.Fixed3D;
            rosterDGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            rosterDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rosterDGV.Columns.AddRange(new DataGridViewColumn[] { Player, Group, Position, Number, College, YearsOfExp, PlayerID, Image });
            rosterDGV.Location = new Point(141, 221);
            rosterDGV.Name = "rosterDGV";
            rosterDGV.ReadOnly = true;
            rosterDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            rosterDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rosterDGV.Size = new Size(681, 428);
            rosterDGV.TabIndex = 0;
            rosterDGV.CellContentClick += rosterDGV_CellContentClick;
            // 
            // Player
            // 
            Player.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Player.HeaderText = "Name";
            Player.Name = "Player";
            Player.ReadOnly = true;
            Player.Resizable = DataGridViewTriState.True;
            Player.SortMode = DataGridViewColumnSortMode.Automatic;
            Player.Width = 64;
            // 
            // Group
            // 
            Group.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Group.HeaderText = "Group";
            Group.Name = "Group";
            Group.ReadOnly = true;
            Group.Width = 65;
            // 
            // Position
            // 
            Position.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Position.HeaderText = "Position";
            Position.Name = "Position";
            Position.ReadOnly = true;
            Position.Width = 75;
            // 
            // Number
            // 
            Number.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Number.HeaderText = "Number";
            Number.Name = "Number";
            Number.ReadOnly = true;
            Number.Width = 76;
            // 
            // College
            // 
            College.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            College.HeaderText = "College";
            College.Name = "College";
            College.ReadOnly = true;
            College.Width = 72;
            // 
            // YearsOfExp
            // 
            YearsOfExp.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            YearsOfExp.HeaderText = "Years Of Experience";
            YearsOfExp.Name = "YearsOfExp";
            YearsOfExp.ReadOnly = true;
            YearsOfExp.Width = 124;
            // 
            // PlayerID
            // 
            PlayerID.HeaderText = "Player ID";
            PlayerID.Name = "PlayerID";
            PlayerID.ReadOnly = true;
            PlayerID.Visible = false;
            PlayerID.Width = 72;
            // 
            // Image
            // 
            Image.HeaderText = "Image";
            Image.Name = "Image";
            Image.ReadOnly = true;
            Image.Visible = false;
            Image.Width = 65;
            // 
            // teamPB
            // 
            teamPB.Location = new Point(12, 34);
            teamPB.Name = "teamPB";
            teamPB.Size = new Size(150, 150);
            teamPB.SizeMode = PictureBoxSizeMode.CenterImage;
            teamPB.TabIndex = 30;
            teamPB.TabStop = false;
            // 
            // teamNameLbl
            // 
            teamNameLbl.AutoSize = true;
            teamNameLbl.Font = new Font("Papyrus", 36F, FontStyle.Bold);
            teamNameLbl.Location = new Point(285, 69);
            teamNameLbl.Name = "teamNameLbl";
            teamNameLbl.Size = new Size(299, 76);
            teamNameLbl.TabIndex = 36;
            teamNameLbl.Text = "Team Name";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Verdana", 12F, FontStyle.Bold);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(12, 668);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(60, 18);
            errorLabel.TabIndex = 37;
            errorLabel.Text = "Error:";
            // 
            // rosterLbl
            // 
            rosterLbl.AutoSize = true;
            rosterLbl.Font = new Font("Verdana", 21.75F, FontStyle.Bold | FontStyle.Underline);
            rosterLbl.Location = new Point(383, 183);
            rosterLbl.Name = "rosterLbl";
            rosterLbl.Size = new Size(121, 35);
            rosterLbl.TabIndex = 38;
            rosterLbl.Text = "Roster";
            // 
            // menu
            // 
            menu.Font = new Font("Verdana", 9.75F);
            menu.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, aboutToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(951, 24);
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
            // PlayersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 694);
            Controls.Add(menu);
            Controls.Add(rosterLbl);
            Controls.Add(errorLabel);
            Controls.Add(teamNameLbl);
            Controls.Add(teamPB);
            Controls.Add(rosterDGV);
            Name = "PlayersForm";
            Text = "Players";
            ((System.ComponentModel.ISupportInitialize)rosterDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)teamPB).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView rosterDGV;
        private PictureBox teamPB;
        private Label teamNameLbl;
        private Label errorLabel;
        private Label rosterLbl;
        private DataGridViewButtonColumn Player;
        private DataGridViewTextBoxColumn Group;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn College;
        private DataGridViewTextBoxColumn YearsOfExp;
        private DataGridViewTextBoxColumn PlayerID;
        private DataGridViewTextBoxColumn Image;
        private MenuStrip menu;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}