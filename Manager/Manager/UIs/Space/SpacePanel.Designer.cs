namespace Manager.UIs.Space
{
    partial class SpacePanel
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meteoroidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buoyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.targetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.createRegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(964, 734);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.Resize += new System.EventHandler(this.pictureBox_Resize);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.createRegionToolStripMenuItem,
            this.updateRegionToolStripMenuItem,
            this.deleteRegionToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 180);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sunToolStripMenuItem,
            this.planetToolStripMenuItem,
            this.moonToolStripMenuItem,
            this.meteoroidToolStripMenuItem,
            this.buoyToolStripMenuItem,
            this.targetToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem.Text = "Create unit";
            // 
            // sunToolStripMenuItem
            // 
            this.sunToolStripMenuItem.Name = "sunToolStripMenuItem";
            this.sunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sunToolStripMenuItem.Text = "Sun";
            this.sunToolStripMenuItem.Click += new System.EventHandler(this.sunToolStripMenuItem_Click);
            // 
            // planetToolStripMenuItem
            // 
            this.planetToolStripMenuItem.Name = "planetToolStripMenuItem";
            this.planetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.planetToolStripMenuItem.Text = "Planet";
            this.planetToolStripMenuItem.Click += new System.EventHandler(this.planetToolStripMenuItem_Click);
            // 
            // moonToolStripMenuItem
            // 
            this.moonToolStripMenuItem.Name = "moonToolStripMenuItem";
            this.moonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moonToolStripMenuItem.Text = "Moon";
            this.moonToolStripMenuItem.Click += new System.EventHandler(this.moonToolStripMenuItem_Click);
            // 
            // meteoroidToolStripMenuItem
            // 
            this.meteoroidToolStripMenuItem.Name = "meteoroidToolStripMenuItem";
            this.meteoroidToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.meteoroidToolStripMenuItem.Text = "Meteoroid";
            this.meteoroidToolStripMenuItem.Click += new System.EventHandler(this.meteoroidToolStripMenuItem_Click);
            // 
            // buoyToolStripMenuItem
            // 
            this.buoyToolStripMenuItem.Name = "buoyToolStripMenuItem";
            this.buoyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buoyToolStripMenuItem.Text = "Buoy";
            this.buoyToolStripMenuItem.Click += new System.EventHandler(this.buoyToolStripMenuItem_Click);
            // 
            // targetToolStripMenuItem
            // 
            this.targetToolStripMenuItem.Name = "targetToolStripMenuItem";
            this.targetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.targetToolStripMenuItem.Text = "Target";
            this.targetToolStripMenuItem.Click += new System.EventHandler(this.targetToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update unit";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy unit";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete unit";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // createRegionToolStripMenuItem
            // 
            this.createRegionToolStripMenuItem.Name = "createRegionToolStripMenuItem";
            this.createRegionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createRegionToolStripMenuItem.Text = "Create region";
            this.createRegionToolStripMenuItem.Click += new System.EventHandler(this.createRegionToolStripMenuItem_Click);
            // 
            // updateRegionToolStripMenuItem
            // 
            this.updateRegionToolStripMenuItem.Name = "updateRegionToolStripMenuItem";
            this.updateRegionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateRegionToolStripMenuItem.Text = "Update region";
            this.updateRegionToolStripMenuItem.Click += new System.EventHandler(this.updateRegionToolStripMenuItem_Click);
            // 
            // deleteRegionToolStripMenuItem
            // 
            this.deleteRegionToolStripMenuItem.Name = "deleteRegionToolStripMenuItem";
            this.deleteRegionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteRegionToolStripMenuItem.Text = "Delete region";
            this.deleteRegionToolStripMenuItem.Click += new System.EventHandler(this.deleteRegionToolStripMenuItem_Click);
            // 
            // SpacePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox);
            this.Name = "SpacePanel";
            this.Size = new System.Drawing.Size(964, 734);
            this.Load += new System.EventHandler(this.SpacePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meteoroidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buoyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem targetToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem createRegionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRegionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRegionToolStripMenuItem;
    }
}
