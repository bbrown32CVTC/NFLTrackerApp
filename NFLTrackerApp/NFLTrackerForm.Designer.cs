namespace NFLTrackerApp
{
    partial class NFLTrackerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NFLTrackerForm));
            welcomeLabel = new Label();
            teamSelectLabel = new Label();
            teamSelectCB = new ComboBox();
            getInfoBtn = new Button();
            nflLogo1 = new PictureBox();
            nflLogo2 = new PictureBox();
            divisionBtn = new Button();
            conferenceBtn = new Button();
            errorLabel = new Label();
            menu = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)nflLogo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nflLogo2).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.FlatStyle = FlatStyle.Flat;
            welcomeLabel.Font = new Font("Verdana", 26.25F);
            welcomeLabel.Location = new Point(182, 66);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(454, 42);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome to NFL Tracker!";
            // 
            // teamSelectLabel
            // 
            teamSelectLabel.AutoSize = true;
            teamSelectLabel.Font = new Font("Verdana", 14.25F);
            teamSelectLabel.Location = new Point(153, 195);
            teamSelectLabel.Name = "teamSelectLabel";
            teamSelectLabel.Size = new Size(141, 23);
            teamSelectLabel.TabIndex = 1;
            teamSelectLabel.Text = "Select Team: ";
            // 
            // teamSelectCB
            // 
            teamSelectCB.DropDownStyle = ComboBoxStyle.DropDownList;
            teamSelectCB.Font = new Font("Verdana", 12F);
            teamSelectCB.FormattingEnabled = true;
            teamSelectCB.Location = new Point(297, 195);
            teamSelectCB.Name = "teamSelectCB";
            teamSelectCB.Size = new Size(245, 26);
            teamSelectCB.Sorted = true;
            teamSelectCB.TabIndex = 2;
            teamSelectCB.SelectedIndexChanged += teamSelectCB_SelectedIndexChanged;
            // 
            // getInfoBtn
            // 
            getInfoBtn.BackColor = Color.SteelBlue;
            getInfoBtn.FlatAppearance.BorderColor = Color.White;
            getInfoBtn.FlatAppearance.MouseOverBackColor = Color.Red;
            getInfoBtn.Font = new Font("Verdana", 18F);
            getInfoBtn.ForeColor = Color.GhostWhite;
            getInfoBtn.Location = new Point(297, 265);
            getInfoBtn.Name = "getInfoBtn";
            getInfoBtn.Size = new Size(245, 34);
            getInfoBtn.TabIndex = 3;
            getInfoBtn.Text = "Get Team Info";
            getInfoBtn.UseVisualStyleBackColor = false;
            getInfoBtn.Click += getInfoBtn_Click;
            // 
            // nflLogo1
            // 
            nflLogo1.Image = (Image)resources.GetObject("nflLogo1.Image");
            nflLogo1.ImageLocation = "";
            nflLogo1.Location = new Point(86, 43);
            nflLogo1.Name = "nflLogo1";
            nflLogo1.Size = new Size(68, 77);
            nflLogo1.TabIndex = 4;
            nflLogo1.TabStop = false;
            // 
            // nflLogo2
            // 
            nflLogo2.Image = (Image)resources.GetObject("nflLogo2.Image");
            nflLogo2.ImageLocation = "";
            nflLogo2.Location = new Point(660, 43);
            nflLogo2.Name = "nflLogo2";
            nflLogo2.Size = new Size(68, 77);
            nflLogo2.TabIndex = 5;
            nflLogo2.TabStop = false;
            // 
            // divisionBtn
            // 
            divisionBtn.BackColor = Color.GhostWhite;
            divisionBtn.Font = new Font("Verdana", 18F);
            divisionBtn.ForeColor = SystemColors.HotTrack;
            divisionBtn.Location = new Point(110, 347);
            divisionBtn.Name = "divisionBtn";
            divisionBtn.Size = new Size(184, 34);
            divisionBtn.TabIndex = 6;
            divisionBtn.Text = "Divisions";
            divisionBtn.UseVisualStyleBackColor = false;
            divisionBtn.Click += divisionBtn_Click;
            // 
            // conferenceBtn
            // 
            conferenceBtn.BackColor = Color.GhostWhite;
            conferenceBtn.Font = new Font("Verdana", 18F);
            conferenceBtn.ForeColor = SystemColors.HotTrack;
            conferenceBtn.Location = new Point(544, 347);
            conferenceBtn.Name = "conferenceBtn";
            conferenceBtn.Size = new Size(184, 34);
            conferenceBtn.TabIndex = 7;
            conferenceBtn.Text = "Conferences";
            conferenceBtn.UseVisualStyleBackColor = false;
            conferenceBtn.Click += conferenceBtn_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Verdana", 12F, FontStyle.Bold);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(12, 423);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(60, 18);
            errorLabel.TabIndex = 8;
            errorLabel.Text = "Error:";
            // 
            // menu
            // 
            menu.Font = new Font("Verdana", 9.75F);
            menu.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, aboutToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 24);
            menu.TabIndex = 9;
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
            // NFLTrackerForm
            // 
            AcceptButton = getInfoBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(errorLabel);
            Controls.Add(conferenceBtn);
            Controls.Add(divisionBtn);
            Controls.Add(nflLogo2);
            Controls.Add(nflLogo1);
            Controls.Add(getInfoBtn);
            Controls.Add(teamSelectCB);
            Controls.Add(teamSelectLabel);
            Controls.Add(welcomeLabel);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "NFLTrackerForm";
            Text = "NFL Tracker";
            ((System.ComponentModel.ISupportInitialize)nflLogo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nflLogo2).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Label teamSelectLabel;
        private ComboBox teamSelectCB;
        private Button getInfoBtn;
        private PictureBox nflLogo1;
        private PictureBox nflLogo2;
        private Button divisionBtn;
        private Button conferenceBtn;
        private Label errorLabel;
        private MenuStrip menu;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
