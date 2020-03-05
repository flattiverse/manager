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
            this.resourceLabel = new System.Windows.Forms.Label();
            this.resourceComboBox = new System.Windows.Forms.ComboBox();
            this.powerOutputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.powerOutPutLabel = new System.Windows.Forms.Label();
            this.radiationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.radiationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gravityNumericUpDown)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerOutputNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // gravityLabel
            // 
            this.gravityLabel.AutoSize = true;
            this.gravityLabel.Location = new System.Drawing.Point(3, 28);
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
            this.gravityNumericUpDown.Location = new System.Drawing.Point(64, 26);
            this.gravityNumericUpDown.Name = "gravityNumericUpDown";
            this.gravityNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.gravityNumericUpDown.TabIndex = 1;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.resourceLabel);
            this.groupBox.Controls.Add(this.resourceComboBox);
            this.groupBox.Controls.Add(this.powerOutputNumericUpDown);
            this.groupBox.Controls.Add(this.powerOutPutLabel);
            this.groupBox.Controls.Add(this.radiationNumericUpDown);
            this.groupBox.Controls.Add(this.radiationLabel);
            this.groupBox.Controls.Add(this.gravityLabel);
            this.groupBox.Controls.Add(this.gravityNumericUpDown);
            this.groupBox.Location = new System.Drawing.Point(0, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(400, 85);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Extra Fields";
            // 
            // resourceLabel
            // 
            this.resourceLabel.AutoSize = true;
            this.resourceLabel.Location = new System.Drawing.Point(151, 60);
            this.resourceLabel.Name = "resourceLabel";
            this.resourceLabel.Size = new System.Drawing.Size(56, 13);
            this.resourceLabel.TabIndex = 13;
            this.resourceLabel.Text = "Resource:";
            // 
            // resourceComboBox
            // 
            this.resourceComboBox.FormattingEnabled = true;
            this.resourceComboBox.Location = new System.Drawing.Point(232, 57);
            this.resourceComboBox.Name = "resourceComboBox";
            this.resourceComboBox.Size = new System.Drawing.Size(87, 21);
            this.resourceComboBox.TabIndex = 12;
            this.resourceComboBox.SelectedIndexChanged += new System.EventHandler(this.resourceComboBox_SelectedIndexChanged);
            // 
            // powerOutputNumericUpDown
            // 
            this.powerOutputNumericUpDown.DecimalPlaces = 1;
            this.powerOutputNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.powerOutputNumericUpDown.Location = new System.Drawing.Point(232, 26);
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
            this.powerOutPutLabel.Location = new System.Drawing.Point(151, 28);
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
            this.radiationNumericUpDown.Location = new System.Drawing.Point(64, 58);
            this.radiationNumericUpDown.Name = "radiationNumericUpDown";
            this.radiationNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.radiationNumericUpDown.TabIndex = 3;
            // 
            // radiationLabel
            // 
            this.radiationLabel.AutoSize = true;
            this.radiationLabel.Location = new System.Drawing.Point(3, 62);
            this.radiationLabel.Name = "radiationLabel";
            this.radiationLabel.Size = new System.Drawing.Size(55, 13);
            this.radiationLabel.TabIndex = 2;
            this.radiationLabel.Text = "Radiation:";
            // 
            // mSunPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox);
            this.Name = "mSunPanel";
            this.Size = new System.Drawing.Size(403, 91);
            this.MouseLeave += new System.EventHandler(this.mSunPanel_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.gravityNumericUpDown)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerOutputNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiationNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label resourceLabel;
        private System.Windows.Forms.ComboBox resourceComboBox;
    }
}
