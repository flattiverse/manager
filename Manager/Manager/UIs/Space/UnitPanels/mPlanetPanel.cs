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

            gravityNumericUpDown.Minimum = decimal.MinValue;
            gravityNumericUpDown.Maximum = decimal.MaxValue;
            gravityNumericUpDown.Value = (decimal)mPlanet.Gravity;

            radiationNumericUpDown.Minimum = decimal.MinValue;
            radiationNumericUpDown.Maximum = decimal.MaxValue;
            radiationNumericUpDown.Value = (decimal)mPlanet.Radiation;
        }
        #endregion

        #region GUI Method
        private void mPlanetPanel_MouseLeave(object sender, EventArgs e)
        {
            mPlanet.Gravity = (float)gravityNumericUpDown.Value;
            mPlanet.Radiation = (float)radiationNumericUpDown.Value;
        }
        #endregion
    }
}
