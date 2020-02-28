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
using System.Xml;

namespace Manager.UIs.Space.UnitPanels
{
    public partial class mSunPanel : UserControl
    {
        #region Fields
        private mSun mSun;
        #endregion

        #region Constructors
        public mSunPanel(mSun mSun)
        {
            InitializeComponent();

            this.mSun = mSun;

            gravityNumericUpDown.Value = (decimal)mSun.Gravity;
            radiationNumericUpDown.Value = (decimal)mSun.Radiation;
            powerOutputNumericUpDown.Value = (decimal)mSun.PowerOutput;
            plasmaLevelNumericUpDown.Value = (decimal)mSun.PlasmaLevel;
            amountNumericUpDown.Value = (decimal)mSun.Amount;
        }
        #endregion

        #region GUI Methods
        private void gravityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mSun.Gravity = (float)gravityNumericUpDown.Value;              
        }

        private void radiationNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mSun.Radiation = (float)radiationNumericUpDown.Value;
        }

        private void powerOutputNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mSun.PowerOutput = (float)powerOutputNumericUpDown.Value;
        }

        private void plasmaLevelNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mSun.PlasmaLevel = (float)plasmaLevelNumericUpDown.Value;
        }

        private void amountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mSun.Amount = (float)amountNumericUpDown.Value;
        }
        #endregion
    }
}
