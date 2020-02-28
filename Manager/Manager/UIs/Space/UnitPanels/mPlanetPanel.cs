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
    public partial class mPlanetPanel : UserControl
    {
        #region Fields
        private mPlanet mPlanet;
        #endregion

        #region Constructors
        public mPlanetPanel(mPlanet mPlanet)
        {
            InitializeComponent();

            this.mPlanet = mPlanet;

            gravityNumericUpDown.Value = (decimal)mPlanet.Gravity;
            radiationNumericUpDown.Value = (decimal)mPlanet.Radiation;
        }
        #endregion

        private void gravityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mPlanet.Gravity = (float)gravityNumericUpDown.Value;
        }

        private void radiationNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mPlanet.Radiation = (float)radiationNumericUpDown.Value;
        }
    }
}
