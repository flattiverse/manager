namespace Manager.UIs.Space
{
    partial class RegionEditor
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
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.spawnLabel = new System.Windows.Forms.Label();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.locationGroupBox = new System.Windows.Forms.GroupBox();
            this.leftLabel = new System.Windows.Forms.Label();
            this.rightLabel = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
            this.botomLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.teamComboBox = new System.Windows.Forms.ComboBox();
            this.spawnCheckBox = new System.Windows.Forms.CheckBox();
            this.leftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.topNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bottomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            this.generalGroupBox.SuspendLayout();
            this.locationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Enabled = false;
            this.idLabel.Location = new System.Drawing.Point(12, 19);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 44);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(217, 19);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(37, 13);
            this.teamLabel.TabIndex = 2;
            this.teamLabel.Text = "Team:";
            // 
            // spawnLabel
            // 
            this.spawnLabel.AutoSize = true;
            this.spawnLabel.Location = new System.Drawing.Point(217, 44);
            this.spawnLabel.Name = "spawnLabel";
            this.spawnLabel.Size = new System.Drawing.Size(43, 13);
            this.spawnLabel.TabIndex = 3;
            this.spawnLabel.Text = "Spawn:";
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.Enabled = false;
            this.idNumericUpDown.Location = new System.Drawing.Point(53, 17);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(158, 20);
            this.idNumericUpDown.TabIndex = 9;
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.spawnCheckBox);
            this.generalGroupBox.Controls.Add(this.teamComboBox);
            this.generalGroupBox.Controls.Add(this.nameTextBox);
            this.generalGroupBox.Controls.Add(this.idLabel);
            this.generalGroupBox.Controls.Add(this.idNumericUpDown);
            this.generalGroupBox.Controls.Add(this.nameLabel);
            this.generalGroupBox.Controls.Add(this.teamLabel);
            this.generalGroupBox.Controls.Add(this.spawnLabel);
            this.generalGroupBox.Location = new System.Drawing.Point(7, 3);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(413, 68);
            this.generalGroupBox.TabIndex = 10;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General Fields";
            // 
            // locationGroupBox
            // 
            this.locationGroupBox.Controls.Add(this.bottomNumericUpDown);
            this.locationGroupBox.Controls.Add(this.topNumericUpDown);
            this.locationGroupBox.Controls.Add(this.rightNumericUpDown);
            this.locationGroupBox.Controls.Add(this.leftNumericUpDown);
            this.locationGroupBox.Controls.Add(this.rightLabel);
            this.locationGroupBox.Controls.Add(this.leftLabel);
            this.locationGroupBox.Controls.Add(this.topLabel);
            this.locationGroupBox.Controls.Add(this.botomLabel);
            this.locationGroupBox.Location = new System.Drawing.Point(5, 73);
            this.locationGroupBox.Name = "locationGroupBox";
            this.locationGroupBox.Size = new System.Drawing.Size(413, 68);
            this.locationGroupBox.TabIndex = 11;
            this.locationGroupBox.TabStop = false;
            this.locationGroupBox.Text = "Location";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Location = new System.Drawing.Point(14, 44);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(28, 13);
            this.leftLabel.TabIndex = 0;
            this.leftLabel.Text = "Left:";
            // 
            // rightLabel
            // 
            this.rightLabel.AutoSize = true;
            this.rightLabel.Location = new System.Drawing.Point(14, 24);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(35, 13);
            this.rightLabel.TabIndex = 1;
            this.rightLabel.Text = "Right:";
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Location = new System.Drawing.Point(217, 19);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(29, 13);
            this.topLabel.TabIndex = 2;
            this.topLabel.Text = "Top:";
            // 
            // botomLabel
            // 
            this.botomLabel.AutoSize = true;
            this.botomLabel.Location = new System.Drawing.Point(217, 44);
            this.botomLabel.Name = "botomLabel";
            this.botomLabel.Size = new System.Drawing.Size(43, 13);
            this.botomLabel.TabIndex = 3;
            this.botomLabel.Text = "Bottom:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(54, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(157, 20);
            this.nameTextBox.TabIndex = 10;
            // 
            // teamComboBox
            // 
            this.teamComboBox.FormattingEnabled = true;
            this.teamComboBox.Location = new System.Drawing.Point(259, 19);
            this.teamComboBox.Name = "teamComboBox";
            this.teamComboBox.Size = new System.Drawing.Size(148, 21);
            this.teamComboBox.TabIndex = 11;
            // 
            // spawnCheckBox
            // 
            this.spawnCheckBox.AutoSize = true;
            this.spawnCheckBox.Location = new System.Drawing.Point(259, 44);
            this.spawnCheckBox.Name = "spawnCheckBox";
            this.spawnCheckBox.Size = new System.Drawing.Size(15, 14);
            this.spawnCheckBox.TabIndex = 12;
            this.spawnCheckBox.UseVisualStyleBackColor = true;
            // 
            // leftNumericUpDown
            // 
            this.leftNumericUpDown.Location = new System.Drawing.Point(56, 42);
            this.leftNumericUpDown.Name = "leftNumericUpDown";
            this.leftNumericUpDown.Size = new System.Drawing.Size(158, 20);
            this.leftNumericUpDown.TabIndex = 10;
            // 
            // rightNumericUpDown
            // 
            this.rightNumericUpDown.Location = new System.Drawing.Point(56, 17);
            this.rightNumericUpDown.Name = "rightNumericUpDown";
            this.rightNumericUpDown.Size = new System.Drawing.Size(158, 20);
            this.rightNumericUpDown.TabIndex = 11;
            // 
            // topNumericUpDown
            // 
            this.topNumericUpDown.Location = new System.Drawing.Point(261, 17);
            this.topNumericUpDown.Name = "topNumericUpDown";
            this.topNumericUpDown.Size = new System.Drawing.Size(148, 20);
            this.topNumericUpDown.TabIndex = 12;
            // 
            // bottomNumericUpDown
            // 
            this.bottomNumericUpDown.Location = new System.Drawing.Point(261, 42);
            this.bottomNumericUpDown.Name = "bottomNumericUpDown";
            this.bottomNumericUpDown.Size = new System.Drawing.Size(148, 20);
            this.bottomNumericUpDown.TabIndex = 13;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(182, 143);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // RegionEditor
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 171);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.locationGroupBox);
            this.Controls.Add(this.generalGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegionEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Region Editor";
            this.Load += new System.EventHandler(this.RegionEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            this.locationGroupBox.ResumeLayout(false);
            this.locationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Label spawnLabel;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.CheckBox spawnCheckBox;
        private System.Windows.Forms.ComboBox teamComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.GroupBox locationGroupBox;
        private System.Windows.Forms.NumericUpDown bottomNumericUpDown;
        private System.Windows.Forms.NumericUpDown topNumericUpDown;
        private System.Windows.Forms.NumericUpDown rightNumericUpDown;
        private System.Windows.Forms.NumericUpDown leftNumericUpDown;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label botomLabel;
        private System.Windows.Forms.Button saveButton;
    }
}