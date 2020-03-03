using System;
using System.Windows.Forms;
using Manager.Units;
using Flattiverse;

namespace Manager.UIs.Space.UnitPanels
{
    public partial class mTargetPanel : UserControl
    {
        #region Fields
        private mTarget mTarget;
        #endregion

        #region Constructors
        public mTargetPanel(mTarget mTarget)
        {
            InitializeComponent();

            this.mTarget = mTarget;

            foreach (Team t in mTarget.Galaxy.Universe.Teams)
            {
                ComboBoxItem item = new ComboBoxItem(t.Name, t);
                teamComboBox.Items.Add(item);

                if (t.Name == mTarget.Team.Name)
                    teamComboBox.SelectedItem = item;
            }

            if (teamComboBox.SelectedItem == null)
                teamComboBox.SelectedIndex = 0;

            sequenceNumericUpDown.Minimum = decimal.MinValue;
            sequenceNumericUpDown.Maximum = decimal.MaxValue;
            sequenceNumericUpDown.Value = mTarget.Sequence;

            hintNumericUpDown.Minimum = decimal.MinValue;
            hintNumericUpDown.Maximum = decimal.MaxValue;

            if (mTarget.Hint.HasValue)
            {
                hintCheckBox.Checked = true;
                hintNumericUpDown.Value = (decimal)mTarget.Hint;
            }
            else
            {
                hintCheckBox.Checked = false;
                hintvalueLabel.Visible = false;
                hintNumericUpDown.Visible = false;
            }
        }
        #endregion

        #region GUI Methods
        //TODO saving without clicking
        private void hintNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (hintCheckBox.Checked)
                mTarget.Hint = (float)hintNumericUpDown.Value;
            else
                mTarget.Hint = null;
        }

        private void sequenceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mTarget.Sequence = (int)sequenceNumericUpDown.Value;
        }

        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mTarget.Team = (Team)((ComboBoxItem)teamComboBox.SelectedItem).Value;
        }

        private void hintCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            hintvalueLabel.Visible = hintCheckBox.Checked;
            hintNumericUpDown.Visible = hintCheckBox.Checked;
        }
        #endregion
    }
}
