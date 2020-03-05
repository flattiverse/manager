using System;
using System.Diagnostics;
using System.Windows.Forms;
using Flattiverse;

namespace Manager.UIs
{
    public partial class LogInForm : Form
    {
        #region Fields
        public Server Server;
        #endregion

        #region Constructors
        public LogInForm()
        {
            InitializeComponent();
        }
        #endregion

        #region GUI Methods
        private async void logInButton_Click(object sender, EventArgs e)
        {
            try
            {
                Enabled = false;
                Text = "Log in. Connecting... Please wait";

                Server = new Server();

                await Server.Login(userNameTextBox.Text, passwordTextBox.Text);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Enabled = true;
                Text = "Log in";

                MessageBox.Show(ex.Message, "Logging in failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
