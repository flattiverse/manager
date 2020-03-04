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

            foreach (FlattiverseResource p in Enum.GetValues(typeof(FlattiverseResource)))
            {
                resourceComboBox.Items.Add(p);

                if (mMeteoroid.Resource == p)
                    resourceComboBox.SelectedItem = p;
            }

            gravityNumericUpDown.Minimum = decimal.MinValue;
            gravityNumericUpDown.Maximum = decimal.MaxValue;
            gravityNumericUpDown.Value = (decimal)mMeteoroid.Gravity;

            radiationNumericUpDown.Minimum = decimal.MinValue;
            radiationNumericUpDown.Maximum = decimal.MaxValue;
            radiationNumericUpDown.Value = (decimal)mMeteoroid.Radiation;
        }
        #endregion

        #region GUI Methods
        private void mMeteoroidPanel_MouseLeave(object sender, EventArgs e)
        {
            mMeteoroid.Radiation = (float)radiationNumericUpDown.Value;
            mMeteoroid.Gravity = (float)gravityNumericUpDown.Value;
        }

        private void resourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mMeteoroid.Resource = (FlattiverseResource)resourceComboBox.SelectedItem;
        }
        #endregion
    }
}
