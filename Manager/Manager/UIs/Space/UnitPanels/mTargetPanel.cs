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

            foreach (Team t in Enum.GetValues(typeof(Team)))
                teamComboBox.Items.Add(t);

            sequenceNumericUpDown.Value = mTarget.Sequence;
            hintNumericUpDown.Value = (decimal)mTarget.Hint;
        }
        #endregion

        #region GUI Methods
        private void teamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mTarget.Team = (Team)teamComboBox.SelectedItem;
        }

        private void sequenceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mTarget.Sequence = (int)sequenceNumericUpDown.Value;
        }

        private void hintNumericUpDown_Click(object sender, EventArgs e)
        {
            mTarget.Hint = (float)hintNumericUpDown.Value; //TODO: null option
        }
        #endregion
    }
}
