using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manager.Units;
using Flattiverse.Units;

namespace Manager.UIs.Space.UnitPanels
{
    public partial class mBuoyPanel : UserControl
    {
        #region Fields
        private mBuoy mBuoy;
        #endregion

        #region Constructors
        public mBuoyPanel(mBuoy mBuoy)
        {
            InitializeComponent();

            this.mBuoy = mBuoy;

            broadcastTextBox.Text = mBuoy.Message;
        }
        #endregion

        #region GUI Method
        private void broadcastTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Buoy.CheckMessage(broadcastTextBox.Text))
                mBuoy.Message = broadcastTextBox.Text;
        }
        #endregion

        private void broadcastTextBox_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
