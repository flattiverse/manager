namespace Manager.UIs.Space.UnitPanels
{
    partial class mTargetPanel
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
            this.hintvalueLabel = new System.Windows.Forms.Label();
            this.hintCheckBox = new System.Windows.Forms.CheckBox();
            this.teamLabel = new System.Windows.Forms.Label();
            this.teamComboBox = new System.Windows.Forms.ComboBox();
            this.hintNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hintLabel = new System.Windows.Forms.Label();
            this.sequenceLabel = new System.Windows.Forms.Label();
            this.sequenceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hintNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.hintvalueLabel);
            this.groupBox.Controls.Add(this.hintCheckBox);
            this.groupBox.Controls.Add(this.teamLabel);
            this.groupBox.Controls.Add(this.teamComboBox);
            this.groupBox.Controls.Add(this.hintNumericUpDown);
            this.groupBox.Controls.Add(this.hintLabel);
            this.groupBox.Controls.Add(this.sequenceLabel);
            this.groupBox.Controls.Add(this.sequenceNumericUpDown);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(400, 95);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Extra Fields";
            // 
            // hintvalueLabel
            // 
            this.hintvalueLabel.AutoSize = true;
            this.hintvalueLabel.Location = new System.Drawing.Point(68, 68);
            this.hintvalueLabel.Name = "hintvalueLabel";
            this.hintvalueLabel.Size = new System.Drawing.Size(58, 13);
            this.hintvalueLabel.TabIndex = 11;
            this.hintvalueLabel.Text = "Hint value:";
            // 
            // hintCheckBox
            // 
            this.hintCheckBox.AutoSize = true;
            this.hintCheckBox.Location = new System.Drawing.Point(47, 68);
            this.hintCheckBox.Name = "hintCheckBox";
            this.hintCheckBox.Size = new System.Drawing.Size(15, 14);
            this.hintCheckBox.TabIndex = 10;
            this.hintCheckBox.UseVisualStyleBackColor = true;
            this.hintCheckBox.CheckedChanged += new System.EventHandler(this.hintCheckBox_CheckedChanged);
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(6, 31);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(40, 13);
            this.teamLabel.TabIndex = 9;
            this.teamLabel.Text = "Team: ";
            // 
            // teamComboBox
            // 
            this.teamComboBox.FormattingEnabled = true;
            this.teamComboBox.Location = new System.Drawing.Point(47, 28);
            this.teamComboBox.Name = "teamComboBox";
            this.teamComboBox.Size = new System.Drawing.Size(98, 21);
            this.teamComboBox.TabIndex = 8;
            this.teamComboBox.SelectedIndexChanged += new System.EventHandler(this.teamComboBox_SelectedIndexChanged);
            // 
            // hintNumericUpDown
            // 
            this.hintNumericUpDown.DecimalPlaces = 1;
            this.hintNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.hintNumericUpDown.Location = new System.Drawing.Point(132, 66);
            this.hintNumericUpDown.Name = "hintNumericUpDown";
            this.hintNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.hintNumericUpDown.TabIndex = 7;
            this.hintNumericUpDown.ValueChanged += new System.EventHandler(this.hintNumericUpDown_ValueChanged);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(6, 68);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(29, 13);
            this.hintLabel.TabIndex = 6;
            this.hintLabel.Text = "Hint:";
            // 
            // sequenceLabel
            // 
            this.sequenceLabel.AutoSize = true;
            this.sequenceLabel.Location = new System.Drawing.Point(154, 31);
            this.sequenceLabel.Name = "sequenceLabel";
            this.sequenceLabel.Size = new System.Drawing.Size(59, 13);
            this.sequenceLabel.TabIndex = 4;
            this.sequenceLabel.Text = "Sequence:";
            // 
            // sequenceNumericUpDown
            // 
            this.sequenceNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sequenceNumericUpDown.Location = new System.Drawing.Point(214, 29);
            this.sequenceNumericUpDown.Name = "sequenceNumericUpDown";
            this.sequenceNumericUpDown.Size = new System.Drawing.Size(68, 20);
            this.sequenceNumericUpDown.TabIndex = 5;
            this.sequenceNumericUpDown.ValueChanged += new System.EventHandler(this.sequenceNumericUpDown_ValueChanged);
            // 
            // mTargetPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox);
            this.Name = "mTargetPanel";
            this.Size = new System.Drawing.Size(403, 98);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hintNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sequenceNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.NumericUpDown hintNumericUpDown;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Label sequenceLabel;
        private System.Windows.Forms.NumericUpDown sequenceNumericUpDown;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.ComboBox teamComboBox;
        private System.Windows.Forms.CheckBox hintCheckBox;
        private System.Windows.Forms.Label hintvalueLabel;
    }
}
