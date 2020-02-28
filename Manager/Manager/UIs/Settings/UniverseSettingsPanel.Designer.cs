namespace Manager.UIs.Settings
{
    partial class EditUniverse
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.maxShipsPerTeamNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxShipsPerTeamLabel = new System.Windows.Forms.Label();
            this.maxShipsPerPlayerLabel = new System.Windows.Forms.Label();
            this.maxShipsPerPlayerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxPlayersPerTeamNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxPlayersPerTeamLabel = new System.Windows.Forms.Label();
            this.maxPlayersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxPlayersLabel = new System.Windows.Forms.Label();
            this.privilegesComboBox = new System.Windows.Forms.ComboBox();
            this.defaultPrivilegesLabel = new System.Windows.Forms.Label();
            this.universeStatusComboBox = new System.Windows.Forms.ComboBox();
            this.universeStatusLabel = new System.Windows.Forms.Label();
            this.universeModeComboBox = new System.Windows.Forms.ComboBox();
            this.difficultyComboBox = new System.Windows.Forms.ComboBox();
            this.universeModeLabel = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.galaxiesTreeView = new System.Windows.Forms.TreeView();
            this.galaxiesLabel = new System.Windows.Forms.Label();
            this.systemsLabel = new System.Windows.Forms.Label();
            this.privilegesLabel = new System.Windows.Forms.Label();
            this.systemsTreeView = new System.Windows.Forms.TreeView();
            this.privilegesTreeView = new System.Windows.Forms.TreeView();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxShipsPerTeamNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxShipsPerPlayerNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPlayersPerTeamNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPlayersNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(15, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name: ";
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.maxShipsPerTeamNumericUpDown);
            this.infoPanel.Controls.Add(this.maxShipsPerTeamLabel);
            this.infoPanel.Controls.Add(this.maxShipsPerPlayerLabel);
            this.infoPanel.Controls.Add(this.maxShipsPerPlayerNumericUpDown);
            this.infoPanel.Controls.Add(this.maxPlayersPerTeamNumericUpDown);
            this.infoPanel.Controls.Add(this.maxPlayersPerTeamLabel);
            this.infoPanel.Controls.Add(this.maxPlayersNumericUpDown);
            this.infoPanel.Controls.Add(this.maxPlayersLabel);
            this.infoPanel.Controls.Add(this.privilegesComboBox);
            this.infoPanel.Controls.Add(this.defaultPrivilegesLabel);
            this.infoPanel.Controls.Add(this.universeStatusComboBox);
            this.infoPanel.Controls.Add(this.universeStatusLabel);
            this.infoPanel.Controls.Add(this.universeModeComboBox);
            this.infoPanel.Controls.Add(this.difficultyComboBox);
            this.infoPanel.Controls.Add(this.universeModeLabel);
            this.infoPanel.Controls.Add(this.difficultyLabel);
            this.infoPanel.Controls.Add(this.descriptionTextBox);
            this.infoPanel.Controls.Add(this.descriptionLabel);
            this.infoPanel.Controls.Add(this.nameLabel);
            this.infoPanel.Controls.Add(this.nameTextBox);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(286, 507);
            this.infoPanel.TabIndex = 5;
            // 
            // maxShipsPerTeamNumericUpDown
            // 
            this.maxShipsPerTeamNumericUpDown.Enabled = false;
            this.maxShipsPerTeamNumericUpDown.Location = new System.Drawing.Point(130, 280);
            this.maxShipsPerTeamNumericUpDown.Name = "maxShipsPerTeamNumericUpDown";
            this.maxShipsPerTeamNumericUpDown.Size = new System.Drawing.Size(139, 20);
            this.maxShipsPerTeamNumericUpDown.TabIndex = 22;
            // 
            // maxShipsPerTeamLabel
            // 
            this.maxShipsPerTeamLabel.AutoSize = true;
            this.maxShipsPerTeamLabel.Location = new System.Drawing.Point(15, 283);
            this.maxShipsPerTeamLabel.Name = "maxShipsPerTeamLabel";
            this.maxShipsPerTeamLabel.Size = new System.Drawing.Size(88, 13);
            this.maxShipsPerTeamLabel.TabIndex = 21;
            this.maxShipsPerTeamLabel.Text = "MaxShips/Team:";
            // 
            // maxShipsPerPlayerLabel
            // 
            this.maxShipsPerPlayerLabel.AutoSize = true;
            this.maxShipsPerPlayerLabel.Location = new System.Drawing.Point(15, 252);
            this.maxShipsPerPlayerLabel.Name = "maxShipsPerPlayerLabel";
            this.maxShipsPerPlayerLabel.Size = new System.Drawing.Size(90, 13);
            this.maxShipsPerPlayerLabel.TabIndex = 20;
            this.maxShipsPerPlayerLabel.Text = "MaxShips/Player:";
            // 
            // maxShipsPerPlayerNumericUpDown
            // 
            this.maxShipsPerPlayerNumericUpDown.Enabled = false;
            this.maxShipsPerPlayerNumericUpDown.Location = new System.Drawing.Point(130, 250);
            this.maxShipsPerPlayerNumericUpDown.Name = "maxShipsPerPlayerNumericUpDown";
            this.maxShipsPerPlayerNumericUpDown.Size = new System.Drawing.Size(139, 20);
            this.maxShipsPerPlayerNumericUpDown.TabIndex = 19;
            // 
            // maxPlayersPerTeamNumericUpDown
            // 
            this.maxPlayersPerTeamNumericUpDown.Enabled = false;
            this.maxPlayersPerTeamNumericUpDown.Location = new System.Drawing.Point(130, 220);
            this.maxPlayersPerTeamNumericUpDown.Name = "maxPlayersPerTeamNumericUpDown";
            this.maxPlayersPerTeamNumericUpDown.Size = new System.Drawing.Size(139, 20);
            this.maxPlayersPerTeamNumericUpDown.TabIndex = 18;
            // 
            // maxPlayersPerTeamLabel
            // 
            this.maxPlayersPerTeamLabel.AutoSize = true;
            this.maxPlayersPerTeamLabel.Location = new System.Drawing.Point(15, 222);
            this.maxPlayersPerTeamLabel.Name = "maxPlayersPerTeamLabel";
            this.maxPlayersPerTeamLabel.Size = new System.Drawing.Size(96, 13);
            this.maxPlayersPerTeamLabel.TabIndex = 17;
            this.maxPlayersPerTeamLabel.Text = "MaxPlayers/Team:";
            // 
            // maxPlayersNumericUpDown
            // 
            this.maxPlayersNumericUpDown.Enabled = false;
            this.maxPlayersNumericUpDown.Location = new System.Drawing.Point(130, 190);
            this.maxPlayersNumericUpDown.Name = "maxPlayersNumericUpDown";
            this.maxPlayersNumericUpDown.Size = new System.Drawing.Size(139, 20);
            this.maxPlayersNumericUpDown.TabIndex = 16;
            // 
            // maxPlayersLabel
            // 
            this.maxPlayersLabel.AutoSize = true;
            this.maxPlayersLabel.Location = new System.Drawing.Point(15, 192);
            this.maxPlayersLabel.Name = "maxPlayersLabel";
            this.maxPlayersLabel.Size = new System.Drawing.Size(64, 13);
            this.maxPlayersLabel.TabIndex = 15;
            this.maxPlayersLabel.Text = "MaxPlayers:";
            // 
            // privilegesComboBox
            // 
            this.privilegesComboBox.Enabled = false;
            this.privilegesComboBox.FormattingEnabled = true;
            this.privilegesComboBox.Location = new System.Drawing.Point(130, 160);
            this.privilegesComboBox.Name = "privilegesComboBox";
            this.privilegesComboBox.Size = new System.Drawing.Size(139, 21);
            this.privilegesComboBox.TabIndex = 14;
            // 
            // defaultPrivilegesLabel
            // 
            this.defaultPrivilegesLabel.AutoSize = true;
            this.defaultPrivilegesLabel.Location = new System.Drawing.Point(15, 163);
            this.defaultPrivilegesLabel.Name = "defaultPrivilegesLabel";
            this.defaultPrivilegesLabel.Size = new System.Drawing.Size(92, 13);
            this.defaultPrivilegesLabel.TabIndex = 13;
            this.defaultPrivilegesLabel.Text = "Default Privileges:";
            // 
            // universeStatusComboBox
            // 
            this.universeStatusComboBox.Enabled = false;
            this.universeStatusComboBox.FormattingEnabled = true;
            this.universeStatusComboBox.Location = new System.Drawing.Point(130, 130);
            this.universeStatusComboBox.Name = "universeStatusComboBox";
            this.universeStatusComboBox.Size = new System.Drawing.Size(139, 21);
            this.universeStatusComboBox.TabIndex = 12;
            // 
            // universeStatusLabel
            // 
            this.universeStatusLabel.AutoSize = true;
            this.universeStatusLabel.Location = new System.Drawing.Point(15, 133);
            this.universeStatusLabel.Name = "universeStatusLabel";
            this.universeStatusLabel.Size = new System.Drawing.Size(82, 13);
            this.universeStatusLabel.TabIndex = 11;
            this.universeStatusLabel.Text = "UniverseStatus:";
            // 
            // universeModeComboBox
            // 
            this.universeModeComboBox.Enabled = false;
            this.universeModeComboBox.FormattingEnabled = true;
            this.universeModeComboBox.Location = new System.Drawing.Point(130, 100);
            this.universeModeComboBox.Name = "universeModeComboBox";
            this.universeModeComboBox.Size = new System.Drawing.Size(139, 21);
            this.universeModeComboBox.TabIndex = 10;
            // 
            // difficultyComboBox
            // 
            this.difficultyComboBox.Enabled = false;
            this.difficultyComboBox.FormattingEnabled = true;
            this.difficultyComboBox.Location = new System.Drawing.Point(130, 70);
            this.difficultyComboBox.Name = "difficultyComboBox";
            this.difficultyComboBox.Size = new System.Drawing.Size(139, 21);
            this.difficultyComboBox.TabIndex = 9;
            // 
            // universeModeLabel
            // 
            this.universeModeLabel.AutoSize = true;
            this.universeModeLabel.Location = new System.Drawing.Point(15, 103);
            this.universeModeLabel.Name = "universeModeLabel";
            this.universeModeLabel.Size = new System.Drawing.Size(82, 13);
            this.universeModeLabel.TabIndex = 8;
            this.universeModeLabel.Text = "UniverseMode: ";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(15, 73);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(50, 13);
            this.difficultyLabel.TabIndex = 7;
            this.difficultyLabel.Text = "Difficulty:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(130, 40);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(139, 20);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(15, 43);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(66, 13);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Description: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(130, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(139, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // galaxiesTreeView
            // 
            this.galaxiesTreeView.Location = new System.Drawing.Point(292, 20);
            this.galaxiesTreeView.Name = "galaxiesTreeView";
            this.galaxiesTreeView.Size = new System.Drawing.Size(366, 141);
            this.galaxiesTreeView.TabIndex = 6;
            // 
            // galaxiesLabel
            // 
            this.galaxiesLabel.AutoSize = true;
            this.galaxiesLabel.Location = new System.Drawing.Point(292, 5);
            this.galaxiesLabel.Name = "galaxiesLabel";
            this.galaxiesLabel.Size = new System.Drawing.Size(47, 13);
            this.galaxiesLabel.TabIndex = 9;
            this.galaxiesLabel.Text = "Galaxies";
            // 
            // systemsLabel
            // 
            this.systemsLabel.AutoSize = true;
            this.systemsLabel.Location = new System.Drawing.Point(292, 175);
            this.systemsLabel.Name = "systemsLabel";
            this.systemsLabel.Size = new System.Drawing.Size(46, 13);
            this.systemsLabel.TabIndex = 10;
            this.systemsLabel.Text = "Systems";
            // 
            // privilegesLabel
            // 
            this.privilegesLabel.AutoSize = true;
            this.privilegesLabel.Location = new System.Drawing.Point(292, 345);
            this.privilegesLabel.Name = "privilegesLabel";
            this.privilegesLabel.Size = new System.Drawing.Size(52, 13);
            this.privilegesLabel.TabIndex = 11;
            this.privilegesLabel.Text = "Privileges";
            // 
            // systemsTreeView
            // 
            this.systemsTreeView.Location = new System.Drawing.Point(292, 190);
            this.systemsTreeView.Name = "systemsTreeView";
            this.systemsTreeView.Size = new System.Drawing.Size(366, 141);
            this.systemsTreeView.TabIndex = 12;
            // 
            // privilegesTreeView
            // 
            this.privilegesTreeView.Location = new System.Drawing.Point(292, 360);
            this.privilegesTreeView.Name = "privilegesTreeView";
            this.privilegesTreeView.Size = new System.Drawing.Size(366, 141);
            this.privilegesTreeView.TabIndex = 13;
            // 
            // EditUniverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.privilegesTreeView);
            this.Controls.Add(this.systemsTreeView);
            this.Controls.Add(this.privilegesLabel);
            this.Controls.Add(this.systemsLabel);
            this.Controls.Add(this.galaxiesLabel);
            this.Controls.Add(this.galaxiesTreeView);
            this.Controls.Add(this.infoPanel);
            this.Name = "EditUniverse";
            this.Size = new System.Drawing.Size(661, 507);
            this.Load += new System.EventHandler(this.EditUniverse_Load);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxShipsPerTeamNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxShipsPerPlayerNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPlayersPerTeamNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxPlayersNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label universeModeLabel;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.ComboBox universeStatusComboBox;
        private System.Windows.Forms.Label universeStatusLabel;
        private System.Windows.Forms.ComboBox universeModeComboBox;
        private System.Windows.Forms.ComboBox difficultyComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown maxPlayersNumericUpDown;
        private System.Windows.Forms.Label maxPlayersLabel;
        private System.Windows.Forms.ComboBox privilegesComboBox;
        private System.Windows.Forms.Label defaultPrivilegesLabel;
        private System.Windows.Forms.Label maxShipsPerPlayerLabel;
        private System.Windows.Forms.NumericUpDown maxShipsPerPlayerNumericUpDown;
        private System.Windows.Forms.NumericUpDown maxPlayersPerTeamNumericUpDown;
        private System.Windows.Forms.Label maxPlayersPerTeamLabel;
        private System.Windows.Forms.NumericUpDown maxShipsPerTeamNumericUpDown;
        private System.Windows.Forms.Label maxShipsPerTeamLabel;
        private System.Windows.Forms.TreeView galaxiesTreeView;
        private System.Windows.Forms.Label galaxiesLabel;
        private System.Windows.Forms.Label systemsLabel;
        private System.Windows.Forms.Label privilegesLabel;
        private System.Windows.Forms.TreeView systemsTreeView;
        private System.Windows.Forms.TreeView privilegesTreeView;
    }
}
