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
    public partial class mMoonPanel : UserControl
    {
        #region Fields
        private mMoon mMoon;
        #endregion

        #region Constructors
        public mMoonPanel(mMoon mMoon)
        {
            InitializeComponent();

            this.mMoon = mMoon;

            gravityNumericUpDown.Value = (decimal)mMoon.Gravity;
            radiationNumericUpDown.Value = (decimal)mMoon.Radiation;
        }
        #endregion

        private void gravityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mMoon.Gravity = (float)gravityNumericUpDown.Value;
        }

        private void radiationNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mMoon.Radiation = (float)radiationNumericUpDown.Value;
        }
    }
}
