namespace NFLTrackerApp
{
    partial class PlayerStatsForm
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
            playerPB = new PictureBox();
            playerNameLbl = new Label();
            errorLabel = new Label();
            playerStatsDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)playerPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerStatsDGV).BeginInit();
            SuspendLayout();
            // 
            // playerPB
            // 
            playerPB.Location = new Point(12, 12);
            playerPB.Name = "playerPB";
            playerPB.Size = new Size(150, 150);
            playerPB.TabIndex = 0;
            playerPB.TabStop = false;
            // 
            // playerNameLbl
            // 
            playerNameLbl.AutoSize = true;
            playerNameLbl.Font = new Font("Papyrus", 36F, FontStyle.Bold, GraphicsUnit.Point);
            playerNameLbl.Location = new Point(270, 52);
            playerNameLbl.Name = "playerNameLbl";
            playerNameLbl.Size = new Size(308, 76);
            playerNameLbl.TabIndex = 37;
            playerNameLbl.Text = "Player Name";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(12, 322);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(60, 18);
            errorLabel.TabIndex = 38;
            errorLabel.Text = "Error:";
            // 
            // playerStatsDGV
            // 
            playerStatsDGV.AllowUserToAddRows = false;
            playerStatsDGV.AllowUserToDeleteRows = false;
            playerStatsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            playerStatsDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            playerStatsDGV.BorderStyle = BorderStyle.Fixed3D;
            playerStatsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playerStatsDGV.Location = new Point(12, 232);
            playerStatsDGV.Name = "playerStatsDGV";
            playerStatsDGV.ReadOnly = true;
            playerStatsDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            playerStatsDGV.RowTemplate.Height = 25;
            playerStatsDGV.SelectionMode = DataGridViewSelectionMode.CellSelect;
            playerStatsDGV.Size = new Size(744, 75);
            playerStatsDGV.TabIndex = 39;
            // 
            // PlayerStatsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 351);
            Controls.Add(playerStatsDGV);
            Controls.Add(errorLabel);
            Controls.Add(playerNameLbl);
            Controls.Add(playerPB);
            Name = "PlayerStatsForm";
            Text = "PlayerStatsForm";
            ((System.ComponentModel.ISupportInitialize)playerPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerStatsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox playerPB;
        private Label playerNameLbl;
        private Label errorLabel;
        private DataGridView playerStatsDGV;
    }
}