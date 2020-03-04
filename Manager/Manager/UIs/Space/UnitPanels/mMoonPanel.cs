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
using Flattiverse;

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

            foreach (FlattiverseResource p in Enum.GetValues(typeof(FlattiverseResource)))
            {
                resourceComboBox.Items.Add(p);

                if (mMoon.Resource == p)
                    resourceComboBox.SelectedItem = p;
            }

            gravityNumericUpDown.Minimum = decimal.MinValue;
            gravityNumericUpDown.Maximum = decimal.MaxValue;
            gravityNumericUpDown.Value = (decimal)mMoon.Gravity;

            radiationNumericUpDown.Minimum = decimal.MinValue;
            radiationNumericUpDown.Maximum = decimal.MaxValue;
            radiationNumericUpDown.Value = (decimal)mMoon.Radiation;
        }
        #endregion

        #region GUI Methods
        private void mMoonPanel_MouseLeave(object sender, EventArgs e)
        {
            mMoon.Gravity = (float)gravityNumericUpDown.Value;
            mMoon.Radiation = (float)radiationNumericUpDown.Value;
        }

        private void resourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mMoon.Resource = (FlattiverseResource)resourceComboBox.SelectedItem;
        }
        #endregion
    }
}
