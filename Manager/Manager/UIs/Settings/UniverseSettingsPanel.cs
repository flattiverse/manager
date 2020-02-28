using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Flattiverse;

namespace Manager.UIs.Settings
{
    public partial class EditUniverse : UserControl
    {
        #region Fields
        private Universe universe;
        #endregion

        #region Constructors
        public EditUniverse(Universe universe)
        {
            InitializeComponent();

            this.universe = universe;
        }
        #endregion

        #region GUI Methods
        private void EditUniverse_Load(object sender, System.EventArgs e)
        {
            foreach (Difficulty difficulty in Enum.GetValues(typeof(Difficulty)))
                difficultyComboBox.Items.Add(difficulty);

            foreach (UniverseMode difficulty in Enum.GetValues(typeof(UniverseMode)))
                universeModeComboBox.Items.Add(difficulty);

            foreach (UniverseStatus difficulty in Enum.GetValues(typeof(UniverseStatus)))
                universeStatusComboBox.Items.Add(difficulty);

            foreach (Privileges difficulty in Enum.GetValues(typeof(Privileges)))
                privilegesComboBox.Items.Add(difficulty);

            nameTextBox.Text = universe.Name;
            descriptionTextBox.Text = universe.Description;
            difficultyComboBox.SelectedItem = universe.Difficulty;
            universeModeComboBox.SelectedItem = universe.Mode;
            universeStatusComboBox.SelectedItem = universe.Status;
            privilegesComboBox.SelectedItem = universe.DefaultPrivileges;
            maxPlayersNumericUpDown.Value = universe.MaxPlayers;
            maxPlayersPerTeamNumericUpDown.Value = universe.MaxPlayersPerTeam;
            maxShipsPerPlayerNumericUpDown.Value = universe.MaxShipsPerPlayer;
            maxShipsPerTeamNumericUpDown.Value = universe.MaxShipsPerTeam;

            foreach (Galaxy galaxy in universe.Galaxies)
            {
                TreeNode node = new TreeNode();
                node.Text = galaxy.Name;

                galaxiesTreeView.Nodes.Add(node);
            }

            foreach (UniverseSystem system in universe.Systems)
            {
                TreeNode node = new TreeNode();
                node.Text = system.Kind.ToString();

                systemsTreeView.Nodes.Add(node);
            }

            foreach (KeyValuePair<Account, Privileges> kvp in universe.QueryPrivileges())
            {
                TreeNode node = new TreeNode();
                node.Text = kvp.Key.Name + " " + kvp.Value.ToString();

                privilegesTreeView.Nodes.Add(node);
            }
        }
        #endregion
    }
}
