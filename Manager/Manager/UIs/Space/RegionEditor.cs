using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flattiverse;
using Region = Flattiverse.Region;

namespace Manager.UIs.Space
{
    public partial class RegionEditor : Form
    {
        #region Fields
        public Region mRegion;

        private Galaxy galaxy;
        #endregion

        #region Constructors
        public RegionEditor(Region region, Galaxy galaxy)
        {
            InitializeComponent();

            mRegion = region;
            this.galaxy = galaxy;
        }
        #endregion

        #region GUI Methods
        private void RegionEditor_Load(object sender, EventArgs e)
        {
            topNumericUpDown.Minimum = decimal.MinValue;
            topNumericUpDown.Maximum = decimal.MaxValue;
            bottomNumericUpDown.Minimum = decimal.MinValue;
            bottomNumericUpDown.Maximum = decimal.MaxValue;
            leftNumericUpDown.Minimum = decimal.MinValue;
            leftNumericUpDown.Maximum = decimal.MaxValue;
            rightNumericUpDown.Minimum = decimal.MinValue;
            rightNumericUpDown.Maximum = decimal.MaxValue;

            idNumericUpDown.Value = mRegion.ID;
            nameTextBox.Text = mRegion.Name;
            spawnCheckBox.Checked = mRegion.Spawn;
            topNumericUpDown.Value = (decimal)mRegion.Top;
            bottomNumericUpDown.Value = (decimal)mRegion.Bottom;
            rightNumericUpDown.Value = (decimal)mRegion.Right;
            leftNumericUpDown.Value = (decimal)mRegion.Left;

            foreach (Team t in galaxy.Universe.Teams)
            {
                ComboBoxItem item = new ComboBoxItem(t.Name, t);
                teamComboBox.Items.Add(item);

                if (mRegion.Team != null && t.Name == mRegion.Team.Name)
                    teamComboBox.SelectedItem = item;
            }

            if (teamComboBox.SelectedItem == null)
                teamComboBox.SelectedIndex = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!Flattiverse.Region.CheckName(nameTextBox.Text))
            {
                MessageBox.Show(@"Name is incorrect. Follow the rule: 1-64 chars, all latin chars, including umlauts and the chars: space . - _ \ / | and #.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (topNumericUpDown.Value <= bottomNumericUpDown.Value || rightNumericUpDown.Value <= leftNumericUpDown.Value)
            {
                MessageBox.Show(@"Location parameters of region are incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            mRegion.Name = nameTextBox.Text;
            mRegion.Team = (Team)((ComboBoxItem)teamComboBox.SelectedItem).Value;
            mRegion.Spawn = spawnCheckBox.Checked;
            mRegion.Top = (float)topNumericUpDown.Value;
            mRegion.Bottom = (float)bottomNumericUpDown.Value;
            mRegion.Left = (float)leftNumericUpDown.Value;
            mRegion.Right = (float)rightNumericUpDown.Value;

            DialogResult = DialogResult.OK;
        }
        #endregion
    }
}
