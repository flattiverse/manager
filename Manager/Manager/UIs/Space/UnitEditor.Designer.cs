namespace Manager.UIs.Space
{
    partial class UnitEditor
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
            this.positionXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.positionYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rLabel = new System.Windows.Forms.Label();
            this.radiusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dimensionGroupBox = new System.Windows.Forms.GroupBox();
            this.profileGroupBox = new System.Windows.Forms.GroupBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.extraFieldsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.positionXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumericUpDown)).BeginInit();
            this.dimensionGroupBox.SuspendLayout();
            this.profileGroupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // positionXNumericUpDown
            // 
            this.positionXNumericUpDown.DecimalPlaces = 2;
            this.positionXNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.positionXNumericUpDown.Location = new System.Drawing.Point(69, 23);
            this.positionXNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.positionXNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.positionXNumericUpDown.Name = "positionXNumericUpDown";
            this.positionXNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.positionXNumericUpDown.TabIndex = 2;
            this.positionXNumericUpDown.ValueChanged += new System.EventHandler(this.positionXNumericUpDown_ValueChanged);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(6, 25);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(57, 13);
            this.xLabel.TabIndex = 3;
            this.xLabel.Text = "Position X:";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(152, 25);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(57, 13);
            this.yLabel.TabIndex = 4;
            this.yLabel.Text = "Position Y:";
            // 
            // positionYNumericUpDown
            // 
            this.positionYNumericUpDown.DecimalPlaces = 2;
            this.positionYNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.positionYNumericUpDown.Location = new System.Drawing.Point(213, 23);
            this.positionYNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.positionYNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.positionYNumericUpDown.Name = "positionYNumericUpDown";
            this.positionYNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.positionYNumericUpDown.TabIndex = 5;
            this.positionYNumericUpDown.ValueChanged += new System.EventHandler(this.positionYNumericUpDown_ValueChanged);
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(285, 25);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(43, 13);
            this.rLabel.TabIndex = 6;
            this.rLabel.Text = "Radius:";
            // 
            // radiusNumericUpDown
            // 
            this.radiusNumericUpDown.DecimalPlaces = 2;
            this.radiusNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.radiusNumericUpDown.Location = new System.Drawing.Point(334, 23);
            this.radiusNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.radiusNumericUpDown.Name = "radiusNumericUpDown";
            this.radiusNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.radiusNumericUpDown.TabIndex = 7;
            this.radiusNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.radiusNumericUpDown.ValueChanged += new System.EventHandler(this.radiusNumericUpDown_ValueChanged);
            // 
            // dimensionGroupBox
            // 
            this.dimensionGroupBox.Controls.Add(this.xLabel);
            this.dimensionGroupBox.Controls.Add(this.radiusNumericUpDown);
            this.dimensionGroupBox.Controls.Add(this.positionXNumericUpDown);
            this.dimensionGroupBox.Controls.Add(this.rLabel);
            this.dimensionGroupBox.Controls.Add(this.yLabel);
            this.dimensionGroupBox.Controls.Add(this.positionYNumericUpDown);
            this.dimensionGroupBox.Location = new System.Drawing.Point(7, 83);
            this.dimensionGroupBox.Name = "dimensionGroupBox";
            this.dimensionGroupBox.Size = new System.Drawing.Size(399, 50);
            this.dimensionGroupBox.TabIndex = 8;
            this.dimensionGroupBox.TabStop = false;
            this.dimensionGroupBox.Text = "Dimensions";
            // 
            // profileGroupBox
            // 
            this.profileGroupBox.Controls.Add(this.nameTextBox);
            this.profileGroupBox.Controls.Add(this.nameLabel);
            this.profileGroupBox.Location = new System.Drawing.Point(7, 26);
            this.profileGroupBox.Name = "profileGroupBox";
            this.profileGroupBox.Size = new System.Drawing.Size(399, 52);
            this.profileGroupBox.TabIndex = 9;
            this.profileGroupBox.TabStop = false;
            this.profileGroupBox.Text = "Profile";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(69, 18);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(317, 20);
            this.nameTextBox.TabIndex = 9;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Name: ";
            // 
            // extraFieldsFlowLayoutPanel
            // 
            this.extraFieldsFlowLayoutPanel.AutoSize = true;
            this.extraFieldsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.extraFieldsFlowLayoutPanel.Location = new System.Drawing.Point(8, 142);
            this.extraFieldsFlowLayoutPanel.Name = "extraFieldsFlowLayoutPanel";
            this.extraFieldsFlowLayoutPanel.Size = new System.Drawing.Size(400, 10);
            this.extraFieldsFlowLayoutPanel.TabIndex = 11;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(414, 24);
            this.menuStrip.TabIndex = 12;
            this.menuStrip.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // UnitEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(414, 160);
            this.Controls.Add(this.extraFieldsFlowLayoutPanel);
            this.Controls.Add(this.profileGroupBox);
            this.Controls.Add(this.dimensionGroupBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitEditor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unit Editor";
            this.Load += new System.EventHandler(this.UnitEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.positionXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusNumericUpDown)).EndInit();
            this.dimensionGroupBox.ResumeLayout(false);
            this.dimensionGroupBox.PerformLayout();
            this.profileGroupBox.ResumeLayout(false);
            this.profileGroupBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown positionXNumericUpDown;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.NumericUpDown positionYNumericUpDown;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.NumericUpDown radiusNumericUpDown;
        private System.Windows.Forms.GroupBox dimensionGroupBox;
        private System.Windows.Forms.GroupBox profileGroupBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.FlowLayoutPanel extraFieldsFlowLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}