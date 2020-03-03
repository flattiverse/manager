namespace Manager.UIs.Space.UnitPanels
{
    partial class mBuoyPanel
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
            this.broadcastTextBox = new System.Windows.Forms.TextBox();
            this.broadcastLabel = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.broadcastTextBox);
            this.groupBox.Controls.Add(this.broadcastLabel);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(400, 64);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Extra Fields";
            // 
            // broadcastTextBox
            // 
            this.broadcastTextBox.Location = new System.Drawing.Point(62, 28);
            this.broadcastTextBox.Name = "broadcastTextBox";
            this.broadcastTextBox.Size = new System.Drawing.Size(334, 20);
            this.broadcastTextBox.TabIndex = 5;
            this.broadcastTextBox.TextChanged += new System.EventHandler(this.broadcastTextBox_TextChanged);
            this.broadcastTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.broadcastTextBox_Validating);
            // 
            // broadcastLabel
            // 
            this.broadcastLabel.AutoSize = true;
            this.broadcastLabel.Location = new System.Drawing.Point(6, 31);
            this.broadcastLabel.Name = "broadcastLabel";
            this.broadcastLabel.Size = new System.Drawing.Size(58, 13);
            this.broadcastLabel.TabIndex = 4;
            this.broadcastLabel.Text = "Broadcast:";
            // 
            // mBuoyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox);
            this.Name = "mBuoyPanel";
            this.Size = new System.Drawing.Size(403, 67);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label broadcastLabel;
        private System.Windows.Forms.TextBox broadcastTextBox;
    }
}
