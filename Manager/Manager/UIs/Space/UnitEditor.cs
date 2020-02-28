﻿using Flattiverse;
using Manager.Units;
using System;
using System.Windows.Forms;
using System.Xml;
using Manager.UIs.Space.UnitPanels;

namespace Manager.UIs.Space
{
    public partial class UnitEditor : Form
    {
        #region Fields
        public string XML;

        private mUnit mUnit;
        private mUnit unitToCopy;
        #endregion

        #region Constructors
        public UnitEditor(mUnit mUnit, mUnit unitToCopy = null)
        {
            InitializeComponent();

            if (mUnit == null)
                throw new Exception("mUnit cannot be null");

            this.mUnit = mUnit;

            Text = "Unit Editor";
        }
        #endregion

        #region GUI Methods
        private void UnitEditor_Load(object sender, EventArgs e)
        {
            if (unitToCopy != null)
                nameTextBox.Text = mUnit.Name + "_Copy";
            else
                nameTextBox.Text = mUnit.Name;

            positionXNumericUpDown.Value = (decimal)mUnit.X;
            positionYNumericUpDown.Value = (decimal)mUnit.Y;
            radiusNumericUpDown.Value = (decimal)mUnit.R;

            //TODO big switch
            if (mUnit is mSun)
                extraFieldsFlowLayoutPanel.Controls.Add(new mSunPanel((mSun)mUnit));
            else if (mUnit is mPlanet)
                extraFieldsFlowLayoutPanel.Controls.Add(new mPlanetPanel((mPlanet)mUnit));
            else if (mUnit is mMeteoroid)
                extraFieldsFlowLayoutPanel.Controls.Add(new mMeteoroidPanel((mMeteoroid)mUnit));
            else if (mUnit is mMoon)
                extraFieldsFlowLayoutPanel.Controls.Add(new mMoonPanel((mMoon)mUnit));
            else if (mUnit is mTarget)
                extraFieldsFlowLayoutPanel.Controls.Add(new mTargetPanel((mTarget)mUnit));
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            mUnit.Name = nameTextBox.Text;
        }

        private void positionXNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mUnit.X = (float)positionXNumericUpDown.Value;
        }

        private void positionYNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mUnit.Y = (float)positionYNumericUpDown.Value;
        }

        private void radiusNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            mUnit.R = (float)radiusNumericUpDown.Value;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Unit.CheckName(nameTextBox.Text))
            {
                MessageBox.Show(@"Name is incorrect. Follow the rule: 1-64 chars, all latin chars, including umlauts and the chars: space . - _ \ / | and #.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XmlDocument xmlDoc = new XmlDocument();

            XmlElement el = mUnit.CreateXmlElement(xmlDoc);
            xmlDoc.AppendChild(el);

            XML = xmlDoc.OuterXml;

            DialogResult = DialogResult.OK;
        }
        #endregion
    }
}