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

namespace Manager.UIs.Space.UnitPanels
{
    public partial class mMeteoroidPanel : UserControl
    {
        #region Fields
        private mMeteoroid mMeteoroid;
        #endregion

        #region Constructors
        public mMeteoroidPanel(mMeteoroid mMeteoroid)
        {
            InitializeComponent();

            this.mMeteoroid = mMeteoroid;

            gravityNumericUpDown.Value = (decimal)mMeteoroid.Gravity;
            radiationNumericUpDown.Value = (decimal)mMeteoroid.Radiation;
        }
        #endregion

        private void gravityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mMeteoroid.Gravity = (float)gravityNumericUpDown.Value;
        }

        private void radiationNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mMeteoroid.Radiation = (float)radiationNumericUpDown.Value;
        }
    }
}
