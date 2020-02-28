using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Flattiverse;
using Manager.UIs.Accounts;
using Manager.UIs.Space;
using Manager.UIs.Settings;

namespace Manager.UIs
{
    public partial class MainUI : Form
    {
        #region Fields
        private Server server;

        #endregion

        #region Constructors
        public MainUI()
        {
            InitializeComponent();
        }
        #endregion

        #region Auxiliary Methods
        private void showSettings(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            if (item == null || item.Tag as Universe == null)
                return;

            mainPanel.Controls.Clear();

            EditUniverse eu = new EditUniverse((Universe)item.Tag);
            eu.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(eu);
        }

        private void viewGalaxyEventHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            if (item == null || item.Tag as Galaxy == null)
                return;

            drawSpacePanel((Galaxy)item.Tag);
        }

        private void drawSpacePanel(Galaxy galaxy)
        {
            mainPanel.Controls.Clear();

            SpacePanel ds = new SpacePanel(galaxy);
            ds.Dock = DockStyle.Fill;
            ds.Tag = galaxy.Universe;
            mainPanel.Controls.Add(ds);
        }
        #endregion

        #region GUI Methods
        private void MainUI_Load(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();

            if (DialogResult.OK != logInForm.ShowDialog())
            {
                Close();
                return;
            }

            server = logInForm.Server;

            logInForm.Close();

            loggedUserLabel.Visible = true;
            loggedUserLabel.Text = "Logged in as: " + server.Player.Name;

            foreach (Universe universe in server.Universes)
            {
                ToolStripMenuItem settingsItem = new ToolStripMenuItem(universe.Name);
                settingsItem.Click += new EventHandler(showSettings);
                settingsItem.Tag = universe;

                settingsToolStripMenuItem.DropDownItems.Add(settingsItem);

                ToolStripMenuItem viewItem = new ToolStripMenuItem(universe.Name);
                viewItem.Tag = universe;

                viewToolStripMenuItem.DropDownItems.Add(viewItem);

                TreeNode universeNode = new TreeNode();
                universeNode.Tag = universe;
                universeNode.Text = universe.Name;

                treeView.Nodes.Add(universeNode);

                foreach (Galaxy galaxy in universe.Galaxies)
                {
                    ToolStripMenuItem galaxyViewItem = new ToolStripMenuItem(galaxy.Name);
                    galaxyViewItem.Click += new EventHandler(viewGalaxyEventHandler);
                    galaxyViewItem.Tag = galaxy;

                    TreeNode galaxyNode = new TreeNode();
                    galaxyNode.Tag = galaxy;
                    galaxyNode.Text = galaxy.Name;
                    universeNode.Nodes.Add(galaxyNode);

                    viewItem.DropDownItems.Add(galaxyViewItem);
                }
            }

            treeView.ExpandAll();
        }

        private void showPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewPanel.Visible = !treeViewPanel.Visible;
        }

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;

            if (node.Tag as Galaxy != null)
                drawSpacePanel((Galaxy)node.Tag);
        }

        private void showAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            AccountsPanel sa = new AccountsPanel(server);
            sa.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(sa);
        }

        private void mainPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control.Tag is Universe)
                ((Universe)(e.Control.Tag)).Part();
        }
        #endregion
    }
}
