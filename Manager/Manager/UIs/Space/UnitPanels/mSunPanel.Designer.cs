namespace Manager.UIs.Space.UnitPanels
{
    partial class mSunPanel
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
            this.gravityLabel = new System.Windows.Forms.Label();
            this.gravityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.powerOutputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.powerOutPutLabel = new System.Windows.Forms.Label();
            this.radiationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.radiationLabel = new System.Windows.Forms.Label();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountLabel = new System.Windows.Forms.Label();
            this.plasmaLevelLabel = new System.Windows.Forms.Label();
            this.coronaRadiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.coronaFieldsGroupBox = new System.Windows.Forms.GroupBox();
            this.coronaRadiusLabel = new System.Windows.Forms.Label();
            this.plasmaComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gravityNumericUpDown)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerOutputNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coronaRadiusNumericUpDown)).BeginInit();
            this.coronaFieldsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gravityLabel
            // 
            this.gravityLabel.AutoSize = true;
            this.gravityLabel.Location = new System.Drawing.Point(2, 30);
            this.gravityLabel.Name = "gravityLabel";
            this.gravityLabel.Size = new System.Drawing.Size(43, 13);
            this.gravityLabel.TabIndex = 0;
            this.gravityLabel.Text = "Gravity:";
            // 
            // gravityNumericUpDown
            // 
            this.gravityNumericUpDown.DecimalPlaces = 1;
            this.gravityNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gravityNumericUpDown.Location = new System.Drawing.Point(45, 28);
            this.gravityNumericUpDown.Name = "gravityNumericUpDown";
            this.gravityNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.gravityNumericUpDown.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.powerOutputNumericUpDown);
            this.groupBox.Controls.Add(this.powerOutPutLabel);
            this.groupBox.Controls.Add(this.radiationNumericUpDown);
            this.groupBox.Controls.Add(this.radiationLabel);
            this.groupBox.Controls.Add(this.gravityLabel);
            this.groupBox.Controls.Add(this.gravityNumericUpDown);
            this.groupBox.Location = new System.Drawing.Point(0, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(400, 67);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Extra Fields";
            // 
            // powerOutputNumericUpDown
            // 
            this.powerOutputNumericUpDown.DecimalPlaces = 1;
            this.powerOutputNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.powerOutputNumericUpDown.Location = new System.Drawing.Point(319, 28);
            this.powerOutputNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.powerOutputNumericUpDown.Name = "powerOutputNumericUpDown";
            this.powerOutputNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.powerOutputNumericUpDown.TabIndex = 5;
            // 
            // powerOutPutLabel
            // 
            this.powerOutPutLabel.AutoSize = true;
            this.powerOutPutLabel.Location = new System.Drawing.Point(241, 30);
            this.powerOutPutLabel.Name = "powerOutPutLabel";
            this.powerOutPutLabel.Size = new System.Drawing.Size(75, 13);
            this.powerOutPutLabel.TabIndex = 4;
            this.powerOutPutLabel.Text = "Power Output:";
            // 
            // radiationNumericUpDown
            // 
            this.radiationNumericUpDown.DecimalPlaces = 1;
            this.radiationNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.radiationNumericUpDown.Location = new System.Drawing.Point(167, 28);
            this.radiationNumericUpDown.Name = "radiationNumericUpDown";
            this.radiationNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.radiationNumericUpDown.TabIndex = 3;
            // 
            // radiationLabel
            // 
            this.radiationLabel.AutoSize = true;
            this.radiationLabel.Location = new System.Drawing.Point(114, 30);
            this.radiationLabel.Name = "radiationLabel";
            this.radiationLabel.Size = new System.Drawing.Size(55, 13);
            this.radiationLabel.TabIndex = 2;
            this.radiationLabel.Text = "Radiation:";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.DecimalPlaces = 1;
            this.amountNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.amountNumericUpDown.Location = new System.Drawing.Point(165, 24);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.amountNumericUpDown.TabIndex = 9;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(116, 26);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(46, 13);
            this.amountLabel.TabIndex = 8;
            this.amountLabel.Text = "Amount:";
            // 
            // plasmaLevelLabel
            // 
            this.plasmaLevelLabel.AutoSize = true;
            this.plasmaLevelLabel.Location = new System.Drawing.Point(241, 26);
            this.plasmaLevelLabel.Name = "plasmaLevelLabel";
            this.plasmaLevelLabel.Size = new System.Drawing.Size(73, 13);
            this.plasmaLevelLabel.TabIndex = 6;
            this.plasmaLevelLabel.Text = "Plasma Level:";
            // 
            // coronaRadiusNumericUpDown
            // 
            this.coronaRadiusNumericUpDown.DecimalPlaces = 1;
            this.coronaRadiusNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.coronaRadiusNumericUpDown.Location = new System.Drawing.Point(44, 24);
            this.coronaRadiusNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.coronaRadiusNumericUpDown.Name = "coronaRadiusNumericUpDown";
            this.coronaRadiusNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.coronaRadiusNumericUpDown.TabIndex = 7;
            // 
            // coronaFieldsGroupBox
            // 
            this.coronaFieldsGroupBox.Controls.Add(this.coronaRadiusLabel);
            this.coronaFieldsGroupBox.Controls.Add(this.plasmaComboBox);
            this.coronaFieldsGroupBox.Controls.Add(this.amountNumericUpDown);
            this.coronaFieldsGroupBox.Controls.Add(this.plasmaLevelLabel);
            this.coronaFieldsGroupBox.Controls.Add(this.amountLabel);
            this.coronaFieldsGroupBox.Controls.Add(this.coronaRadiusNumericUpDown);
            this.coronaFieldsGroupBox.Location = new System.Drawing.Point(0, 76);
            this.coronaFieldsGroupBox.Name = "coronaFieldsGroupBox";
            this.coronaFieldsGroupBox.Size = new System.Drawing.Size(400, 60);
            this.coronaFieldsGroupBox.TabIndex = 3;
            this.coronaFieldsGroupBox.TabStop = false;
            this.coronaFieldsGroupBox.Text = "Corona fields";
            // 
            // coronaRadiusLabel
            // 
            this.coronaRadiusLabel.AutoSize = true;
            this.coronaRadiusLabel.Location = new System.Drawing.Point(1, 26);
            this.coronaRadiusLabel.Name = "coronaRadiusLabel";
            this.coronaRadiusLabel.Size = new System.Drawing.Size(43, 13);
            this.coronaRadiusLabel.TabIndex = 11;
            this.coronaRadiusLabel.Text = "Radius:";
            // 
            // plasmaComboBox
            // 
            this.plasmaComboBox.FormattingEnabled = true;
            this.plasmaComboBox.Location = new System.Drawing.Point(317, 23);
            this.plasmaComboBox.Name = "plasmaComboBox";
            this.plasmaComboBox.Size = new System.Drawing.Size(69, 21);
            this.plasmaComboBox.TabIndex = 10;
            // 
            // mSunPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.coronaFieldsGroupBox);
            this.Controls.Add(this.groupBox);
            this.Name = "mSunPanel";
            this.Size = new System.Drawing.Size(403, 139);
            this.MouseLeave += new System.EventHandler(this.mSunPanel_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.gravityNumericUpDown)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerOutputNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coronaRadiusNumericUpDown)).EndInit();
            this.coronaFieldsGroupBox.ResumeLayout(false);
            this.coronaFieldsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gravityLabel;
        private System.Windows.Forms.NumericUpDown gravityNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.NumericUpDown radiationNumericUpDown;
        private System.Windows.Forms.Label radiationLabel;
        private System.Windows.Forms.Label powerOutPutLabel;
        private System.Windows.Forms.NumericUpDown powerOutputNumericUpDown;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label plasmaLevelLabel;
        private System.Windows.Forms.NumericUpDown coronaRadiusNumericUpDown;
        private System.Windows.Forms.GroupBox coronaFieldsGroupBox;
        private System.Windows.Forms.Label coronaRadiusLabel;
        private System.Windows.Forms.ComboBox plasmaComboBox;
    }
}
