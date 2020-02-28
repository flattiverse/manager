using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using Flattiverse;
using Manager.Units;

namespace Manager.UIs.Space
{
    public partial class SpacePanel : UserControl
    {
        #region Fields
        private Server server;
        private Universe universe;
        private Galaxy galaxy;
        private List<mUnit> mUnits;
        private mUnit selectedUnit;
        private object syncDrawing = new object();

        private float cx; //Center of the picturebox 
        private float cy; //Center of the picturebox
        private float zoom = 0.5f;

        private Bitmap bitmap;//TODO: not thread safe
        private Font font = new Font("Arial", 15);
        #endregion

        #region Constructors
        public SpacePanel(Galaxy galaxy)
        {
            InitializeComponent();

            this.galaxy = galaxy;

            universe = galaxy.Universe;
            server = universe.Server;

            mUnits = new List<mUnit>();
        }
        #endregion

        #region Methods
        private void metaEvent(FlattiverseEvent @event)
        {

        }

        private void scanEvent(FlattiverseEvent @event)
        {
            if (@event is GoneUnitEvent)
            {
                mUnit removed = mUnits.Find(u => u.Name == ((GoneUnitEvent)@event).Name);
                mUnits.Remove(removed);
            }
            else
            {
                Unit unit = ((UnitEvent)@event).Unit;

                if (!mUnits.Exists(u => u.Name == unit.Name))
                    if (unit is Sun)
                        mUnits.Add(new mSun((Sun)unit));
            }

            draw();
        }

        private void draw()
        {
            cx = pictureBox.Width / 2f;
            cy = pictureBox.Height / 2f;

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.Black);

                foreach (mUnit u in mUnits)
                {
                    graphics.DrawEllipse(Pens.Yellow, compX(u.X - u.R), compY(u.Y + u.R), compD(u.R), compD(u.R));
                    graphics.DrawString(u.Name, font, Brushes.White, compX(u.X), compY(u.Y));
                }
            }

            pictureBox.Invalidate();
        }

        private float compX(float x)
        {
            return cx + x * zoom;
        }

        private float compY(float y)
        {
            return cy - y * zoom;
        }

        private float compD(float y)
        {
            return 2 * y * zoom;
        }
        #endregion

        #region GUI Methods
        private async void DrawSpace_Load(object sender, EventArgs e)
        {
            try
            {
                bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

                server.ScanEvent += scanEvent;
                server.MetaEvent += metaEvent;

                await universe.Join();
                await galaxy.StartView();

                MouseWheel += new MouseEventHandler(MouseWheelHandler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MouseWheelHandler(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                zoom /= 2;
            else
                zoom *= 2;

            draw();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(bitmap, Point.Empty);
        }

        private void pictureBox_Resize(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

            draw();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            selectedUnit = null;

            if (e.Button == MouseButtons.Right)
            {
                updateToolStripMenuItem.Visible = false;
                deleteToolStripMenuItem.Visible = false;
                copyToolStripMenuItem.Visible = false;

                Point p = new Point((int)((e.X - cx) / zoom), (int)(-(e.Y - cy) / zoom));

                foreach (mUnit u in mUnits)
                    if (Math.Pow(p.X - u.X, 2) + Math.Pow(p.Y - u.Y, 2) <= Math.Pow(u.R, 2))
                    {
                        selectedUnit = u;
                        break;
                    }

                if (selectedUnit != null)
                {
                    updateToolStripMenuItem.Visible = true;
                    deleteToolStripMenuItem.Visible = true;
                    copyToolStripMenuItem.Visible = true;
                }

                contextMenuStrip.Show(MousePosition);
            }
        }

        private async void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (UnitEditor ue = new UnitEditor(selectedUnit))
                if (ue.ShowDialog() == DialogResult.OK)
                    await galaxy.UpdateUnitXml(ue.XML);

            selectedUnit = null;
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                await galaxy.DeleteUnit(selectedUnit.Name);
                mUnits.Remove(selectedUnit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO:
            //using (UnitEditor ue = new UnitEditor(selectedUnit))
            //    if (ue.ShowDialog() == DialogResult.OK)
            //        await galaxy.UpdateUnitXml(ue.XML);

            //selectedUnit = null;
        }

        private async void sunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mSun mSun = new mSun();

            using (UnitEditor ue = new UnitEditor(mSun))
                if (ue.ShowDialog() == DialogResult.OK)
                    await galaxy.UpdateUnitXml(ue.XML);

            selectedUnit = null;
        }

        private async void planetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mPlanet mPlanet = new mPlanet();

            using (UnitEditor ue = new UnitEditor(mPlanet))
                if (ue.ShowDialog() == DialogResult.OK)
                    await galaxy.UpdateUnitXml(ue.XML);

            selectedUnit = null;
        }

        private async void moonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mMoon mMoon = new mMoon();

            using (UnitEditor ue = new UnitEditor(mMoon))
                if (ue.ShowDialog() == DialogResult.OK)
                    await galaxy.UpdateUnitXml(ue.XML);

            selectedUnit = null;
        }

        private async void meteoroidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mMeteoroid mMeteoroid = new mMeteoroid();

            using (UnitEditor ue = new UnitEditor(mMeteoroid))
                if (ue.ShowDialog() == DialogResult.OK)
                    await galaxy.UpdateUnitXml(ue.XML);

            selectedUnit = null;
        }

        private async void buoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mBuoy mBuoy = new mBuoy();

            using (UnitEditor ue = new UnitEditor(mBuoy))
                if (ue.ShowDialog() == DialogResult.OK)
                    await galaxy.UpdateUnitXml(ue.XML);

            selectedUnit = null;
        }

        private async void targetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mTarget mTarget = new mTarget();

            using (UnitEditor ue = new UnitEditor(mTarget))
                if (ue.ShowDialog() == DialogResult.OK)
                    await galaxy.UpdateUnitXml(ue.XML);

            selectedUnit = null;
        }
        #endregion
    }
}
