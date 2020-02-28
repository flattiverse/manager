using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flattiverse;

namespace Manager.UIs.Accounts
{
    public partial class ChangePasswordForm : Form
    {
        #region Fields
        private Account account;
        #endregion

        #region Constructors
        public ChangePasswordForm(Account account)
        {
            InitializeComponent();

            this.account = account;

            Text = "Change password of " + account.Name;
        }
        #endregion

        #region GUI Methods
        private async void saveButton_Click(object sender, EventArgs e)
        {
            Text = "Saving the new password. Please wait...";
            Enabled = false;

            try
            {
                await account.ChangePassword(passwordTextBox.Text);
                DialogResult =  DialogResult.OK;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Enabled = true;
            }
        }
        #endregion
    }
}
