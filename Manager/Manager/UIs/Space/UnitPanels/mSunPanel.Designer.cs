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
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountLabel = new System.Windows.Forms.Label();
            this.plasmaLevelLabel = new System.Windows.Forms.Label();
            this.plasmaLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.powerOutputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.powerOutPutLabel = new System.Windows.Forms.Label();
            this.radiationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.radiationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gravityNumericUpDown)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plasmaLevelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerOutputNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // gravityLabel
            // 
            this.gravityLabel.AutoSize = true;
            this.gravityLabel.Location = new System.Drawing.Point(6, 30);
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
            this.gravityNumericUpDown.Location = new System.Drawing.Point(82, 28);
            this.gravityNumericUpDown.Name = "gravityNumericUpDown";
            this.gravityNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.gravityNumericUpDown.TabIndex = 1;
            this.gravityNumericUpDown.ValueChanged += new System.EventHandler(this.gravityNumericUpDown_ValueChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.amountNumericUpDown);
            this.groupBox.Controls.Add(this.amountLabel);
            this.groupBox.Controls.Add(this.plasmaLevelLabel);
            this.groupBox.Controls.Add(this.plasmaLevelNumericUpDown);
            this.groupBox.Controls.Add(this.powerOutputNumericUpDown);
            this.groupBox.Controls.Add(this.powerOutPutLabel);
            this.groupBox.Controls.Add(this.radiationNumericUpDown);
            this.groupBox.Controls.Add(this.radiationLabel);
            this.groupBox.Controls.Add(this.gravityLabel);
            this.groupBox.Controls.Add(this.gravityNumericUpDown);
            this.groupBox.Location = new System.Drawing.Point(3, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(394, 107);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Extra Fields";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.DecimalPlaces = 1;
            this.amountNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.amountNumericUpDown.Location = new System.Drawing.Point(196, 69);
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.amountNumericUpDown.TabIndex = 9;
            this.amountNumericUpDown.ValueChanged += new System.EventHandler(this.amountNumericUpDown_ValueChanged);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(147, 71);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(46, 13);
            this.amountLabel.TabIndex = 8;
            this.amountLabel.Text = "Amount:";
            // 
            // plasmaLevelLabel
            // 
            this.plasmaLevelLabel.AutoSize = true;
            this.plasmaLevelLabel.Location = new System.Drawing.Point(6, 71);
            this.plasmaLevelLabel.Name = "plasmaLevelLabel";
            this.plasmaLevelLabel.Size = new System.Drawing.Size(73, 13);
            this.plasmaLevelLabel.TabIndex = 6;
            this.plasmaLevelLabel.Text = "Plasma Level:";
            // 
            // plasmaLevelNumericUpDown
            // 
            this.plasmaLevelNumericUpDown.DecimalPlaces = 1;
            this.plasmaLevelNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.plasmaLevelNumericUpDown.Location = new System.Drawing.Point(82, 69);
            this.plasmaLevelNumericUpDown.Name = "plasmaLevelNumericUpDown";
            this.plasmaLevelNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.plasmaLevelNumericUpDown.TabIndex = 7;
            this.plasmaLevelNumericUpDown.ValueChanged += new System.EventHandler(this.plasmaLevelNumericUpDown_ValueChanged);
            // 
            // powerOutputNumericUpDown
            // 
            this.powerOutputNumericUpDown.DecimalPlaces = 1;
            this.powerOutputNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.powerOutputNumericUpDown.Location = new System.Drawing.Point(328, 28);
            this.powerOutputNumericUpDown.Name = "powerOutputNumericUpDown";
            this.powerOutputNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.powerOutputNumericUpDown.TabIndex = 5;
            this.powerOutputNumericUpDown.ValueChanged += new System.EventHandler(this.powerOutputNumericUpDown_ValueChanged);
            // 
            // powerOutPutLabel
            // 
            this.powerOutPutLabel.AutoSize = true;
            this.powerOutPutLabel.Location = new System.Drawing.Point(247, 30);
            this.powerOutPutLabel.Name = "powerOutPutLabel";
            this.powerOutPutLabel.Size = new System.Drawing.Size(78, 13);
            this.powerOutPutLabel.TabIndex = 4;
            this.powerOutPutLabel.Text = "Power Output: ";
            // 
            // radiationNumericUpDown
            // 
            this.radiationNumericUpDown.DecimalPlaces = 1;
            this.radiationNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.radiationNumericUpDown.Location = new System.Drawing.Point(196, 28);
            this.radiationNumericUpDown.Name = "radiationNumericUpDown";
            this.radiationNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.radiationNumericUpDown.TabIndex = 3;
            this.radiationNumericUpDown.ValueChanged += new System.EventHandler(this.radiationNumericUpDown_ValueChanged);
            // 
            // radiationLabel
            // 
            this.radiationLabel.AutoSize = true;
            this.radiationLabel.Location = new System.Drawing.Point(137, 30);
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
            this.Size = new System.Drawing.Size(400, 115);
            ((System.ComponentModel.ISupportInitialize)(this.gravityNumericUpDown)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plasmaLevelNumericUpDown)).EndInit();
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
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label plasmaLevelLabel;
        private System.Windows.Forms.NumericUpDown plasmaLevelNumericUpDown;
    }
}
