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
using Flattiverse;

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

            gravityNumericUpDown.Minimum = decimal.MinValue;
            gravityNumericUpDown.Maximum = decimal.MaxValue;
            gravityNumericUpDown.Value = (decimal)mSun.Gravity;

            radiationNumericUpDown.Minimum = decimal.MinValue;
            radiationNumericUpDown.Maximum = decimal.MaxValue;
            radiationNumericUpDown.Value = (decimal)mSun.Radiation;

            powerOutputNumericUpDown.Minimum = decimal.MinValue;
            powerOutputNumericUpDown.Maximum = decimal.MaxValue;
            powerOutputNumericUpDown.Value = (decimal)mSun.PowerOutput;

            plasmaComboBox.Items.Insert(0, "None");

            foreach (Plasma p in Enum.GetValues(typeof(Plasma)))
                plasmaComboBox.Items.Add(p);

            plasmaComboBox.SelectedIndex = 0;

            if (mSun.mCorona != null && mSun.mCorona.Plasma > 0)
            {
                coronaRadiusNumericUpDown.Minimum = decimal.MinValue;
                coronaRadiusNumericUpDown.Maximum = decimal.MaxValue;
                coronaRadiusNumericUpDown.Value = (decimal)mSun.mCorona.Radius;

                amountNumericUpDown.Minimum = decimal.MinValue;
                amountNumericUpDown.Maximum = decimal.MaxValue;
                amountNumericUpDown.Value = (decimal)mSun.mCorona.Amount;

                plasmaComboBox.SelectedItem = mSun.mCorona.Plasma;
            }
        }
        #endregion

        #region GUI Methods
        private void mSunPanel_MouseLeave(object sender, EventArgs e)
        {
            mSun.Gravity = (float)gravityNumericUpDown.Value;
            mSun.Radiation = (float)radiationNumericUpDown.Value;
            mSun.PowerOutput = (float)powerOutputNumericUpDown.Value;

            if (mSun.mCorona == null && (plasmaComboBox.SelectedIndex) > 0)
                mSun.mCorona = new mCorona();

            if (mSun.mCorona != null)
            {
                mSun.mCorona.Amount = (float)amountNumericUpDown.Value;
                mSun.mCorona.Radius = (float)coronaRadiusNumericUpDown.Value;

                if (plasmaComboBox.SelectedIndex > 0)
                    mSun.mCorona.Plasma = (Plasma)plasmaComboBox.SelectedItem;
                else
                    mSun.mCorona.Plasma = 0;
            }
        }
        #endregion
    }
}
