namespace Manager.UIs.Space.UnitPanels
{
    partial class mMeteoroidPanel
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radiationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.radiationLabel = new System.Windows.Forms.Label();
            this.gravityLabel = new System.Windows.Forms.Label();
            this.gravityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radiationNumericUpDown);
            this.groupBox.Controls.Add(this.radiationLabel);
            this.groupBox.Controls.Add(this.gravityLabel);
            this.groupBox.Controls.Add(this.gravityNumericUpDown);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(400, 64);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Extra Fields";
            // 
            // radiationNumericUpDown
            // 
            this.radiationNumericUpDown.DecimalPlaces = 1;
            this.radiationNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.radiationNumericUpDown.Location = new System.Drawing.Point(197, 29);
            this.radiationNumericUpDown.Name = "radiationNumericUpDown";
            this.radiationNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.radiationNumericUpDown.TabIndex = 7;
            this.radiationNumericUpDown.ValueChanged += new System.EventHandler(this.radiationNumericUpDown_ValueChanged);
            // 
            // radiationLabel
            // 
            this.radiationLabel.AutoSize = true;
            this.radiationLabel.Location = new System.Drawing.Point(141, 31);
            this.radiationLabel.Name = "radiationLabel";
            this.radiationLabel.Size = new System.Drawing.Size(55, 13);
            this.radiationLabel.TabIndex = 6;
            this.radiationLabel.Text = "Radiation:";
            // 
            // gravityLabel
            // 
            this.gravityLabel.AutoSize = true;
            this.gravityLabel.Location = new System.Drawing.Point(24, 31);
            this.gravityLabel.Name = "gravityLabel";
            this.gravityLabel.Size = new System.Drawing.Size(43, 13);
            this.gravityLabel.TabIndex = 4;
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
            this.gravityNumericUpDown.Location = new System.Drawing.Point(71, 29);
            this.gravityNumericUpDown.Name = "gravityNumericUpDown";
            this.gravityNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.gravityNumericUpDown.TabIndex = 5;
            this.gravityNumericUpDown.ValueChanged += new System.EventHandler(this.gravityNumericUpDown_ValueChanged);
            // 
            // mPlanetPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox);
            this.Name = "mPlanetPanel";
            this.Size = new System.Drawing.Size(400, 64);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.NumericUpDown radiationNumericUpDown;
        private System.Windows.Forms.Label radiationLabel;
        private System.Windows.Forms.Label gravityLabel;
        private System.Windows.Forms.NumericUpDown gravityNumericUpDown;
    }
}
