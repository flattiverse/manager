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

            foreach (FlattiverseResourceKind kind in Enum.GetValues(typeof(FlattiverseResourceKind)))
            {
                int k = (int)kind;

                if (k < 7 || k == 21)
                {
                    resourceComboBox.Items.Add(kind);

                    if (mSun.ResourceKind == kind)
                        resourceComboBox.SelectedItem = kind;
                }
            }
        }
        #endregion

        #region GUI Methods
        private void mSunPanel_MouseLeave(object sender, EventArgs e)
        {
            mSun.Gravity = (float)gravityNumericUpDown.Value;
            mSun.Radiation = (float)radiationNumericUpDown.Value;
            mSun.PowerOutput = (float)powerOutputNumericUpDown.Value;
        }

        private void resourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mSun.ResourceKind = (FlattiverseResourceKind)resourceComboBox.SelectedItem;
        }
        #endregion
    }
}
