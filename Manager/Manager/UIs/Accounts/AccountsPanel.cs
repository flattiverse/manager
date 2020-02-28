using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flattiverse;

namespace Manager.UIs.Accounts
{
    public partial class AccountsPanel : UserControl
    {
        #region Fields
        private Server server;
        #endregion

        #region Constructors
        public AccountsPanel(Server server)
        {
            InitializeComponent();

            this.server = server;
        }
        #endregion

        #region GUI Methods
        private void ShowAccounts_Load(object sender, EventArgs e)
        {
            foreach (Account account in server.QueryAccounts("%", false))
            {
                TreeNode treeNode = new TreeNode(account.Name);
                treeNode.Tag = account;

                accountsTreeView.Nodes.Add(treeNode);

                treeNode.Nodes.Add(new TreeNode("Status: " + account.Status));
                treeNode.Nodes.Add(new TreeNode("Kills: " + account.Kills));
                treeNode.Nodes.Add(new TreeNode("Deaths: " + account.Deaths));
                treeNode.Nodes.Add(new TreeNode("E -mail: " + account.EMail));
                treeNode.Nodes.Add(new TreeNode("New e-mail: " + account.NewEMail));
            }
        }

        private void accountsTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                accountsTreeView.SelectedNode = e.Node;
                contextMenuStrip.Show(MousePosition);
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ChangePasswordForm changePasswordForm = new ChangePasswordForm((Account)accountsTreeView.SelectedNode.Tag))
                if (changePasswordForm.ShowDialog() == DialogResult.OK)
                    MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
