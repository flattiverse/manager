using Flattiverse;
using Flattiverse.Events;
using Flattiverse.Units;
using Manager.Units;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Region = Flattiverse.Region;

namespace Manager.UIs.Space
{
    public partial class SpacePanel : UserControl
    {
        #region Fields
        private Server server;
        private Universe universe;
        private Galaxy galaxy;
        private List<mUnit> mUnits; //TODO
        private mUnit selectedUnit;
        private object syncDrawing = new object();
        private List<Region> regions;

        private float cx; //Center of the picturebox 
        private float cy; //Center of the picturebox
        private float zoom = 0.5f;

        private Bitmap bitmap;
        private Font font = new Font("Arial", 8);
        private Controllable testShip;
        Pen dashedYellowPen = new Pen(Brushes.Yellow);
        #endregion

        #region Constructors
        public SpacePanel(Galaxy galaxy)
        {
            InitializeComponent();

            this.galaxy = galaxy;

            universe = galaxy.Universe;
            server = universe.Server;

            mUnits = new List<mUnit>();
            regions = new List<Region>();
        }
        #endregion

        #region Methods
        private void setPens()
        {
            dashedYellowPen.DashPattern = new float[] { 2, 6 };
        }

        private async void gatherEvents()
        {
            Queue<FlattiverseEvent> events = await server.GatherEvents();

            while (events.Count > 0)
            {
                FlattiverseEvent @event = events.Dequeue();

                if (@event is GoneUnitEvent)
                {
                    mUnit removed = mUnits.Find(u => u.Name == ((GoneUnitEvent)@event).Name);
                    mUnits.Remove(removed);
                }
                else if (@event is NewUnitEvent)
                {
                    Unit unit = ((UnitEvent)@event).Unit;

                    switch (unit)
                    {
                        case Buoy buoy: mUnits.Add(new mBuoy(buoy)); break;
                        case Meteoroid meteoroid: mUnits.Add(new mMeteoroid(meteoroid)); break;
                        case Moon moon: mUnits.Add(new mMoon(moon)); break;
                        case Planet planet: mUnits.Add(new mPlanet(planet)); break;
                        case Sun sun: mUnits.Add(new mSun(sun)); break;
                        case Target target: mUnits.Add(new mTarget(target)); break;
                        case PlayerUnit player: mUnits.Add(new mPlayerUnit(player)); break;
                    }
                }
                else if (@event is UnitEvent)
                    Console.WriteLine("Unit Event");
                else if (@event is UpdatedUnitEvent)
                    Console.WriteLine("UpdatedUnitEvent");
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
                    switch (u)
                    {
                        case mBuoy buoy:
                            graphics.DrawEllipse(Pens.Red, compX(u.X - u.R), compY(u.Y + u.R), compD(u.R), compD(u.R));
                            //graphics.DrawString(u.Name, font, Brushes.White, compX(u.X), compY(u.Y));
                            break;
                        case mMeteoroid meteoroid:
                            graphics.DrawEllipse(Pens.Orange, compX(u.X - u.R), compY(u.Y + u.R), compD(u.R), compD(u.R));
                            //graphics.DrawString(u.Name, font, Brushes.White, compX(u.X), compY(u.Y));
                            break;
                        case mMoon moon:
                            graphics.DrawEllipse(Pens.Silver, compX(u.X - u.R), compY(u.Y + u.R), compD(u.R), compD(u.R));
                            //graphics.DrawString(u.Name, font, Brushes.White, compX(u.X), compY(u.Y));
                            break;
                        case mPlanet planet:
                            graphics.DrawEllipse(Pens.Blue, compX(u.X - u.R), compY(u.Y + u.R), compD(u.R), compD(u.R));
                            //graphics.DrawString(u.Name, font, Brushes.White, compX(u.X), compY(u.Y));
                            break;
                        case mSun sun:
                            graphics.DrawEllipse(Pens.Yellow, compX(u.X - u.R), compY(u.Y + u.R), compD(u.R), compD(u.R));
                            //graphics.DrawString(u.Name, font, Brushes.White, compX(u.X), compY(u.Y));

                            if (sun.mCorona != null && sun.mCorona.Plasma > 0)
                                graphics.DrawEllipse(dashedYellowPen, compX(u.X - sun.mCorona.Radius), compY(u.Y + sun.mCorona.Radius), compD(sun.mCorona.Radius), compD(sun.mCorona.Radius));

                            break;
                        case mTarget target:
                            graphics.DrawEllipse(Pens.Violet, compX(u.X - u.R), compY(u.Y + u.R), compD(u.R), compD(u.R));
                            //graphics.DrawString(u.Name, font, Brushes.White, compX(u.X), compY(u.Y));
                            break;
                        case mPlayerUnit p:
                            graphics.DrawEllipse(Pens.White, compX(u.X - u.R), compY(u.Y + u.R), compD(u.R), compD(u.R));

                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine(u.Name);
                            sb.AppendLine("Direction: " + p.Direction);
                            sb.AppendLine("Rotation: " + p.Rotation);
                            sb.AppendLine("Engine: " + p.Engine);
                            graphics.DrawString(sb.ToString(), font, Brushes.White, compX(u.X + u.R + 2), compY(u.Y + 5)); //TODO: improve
                            break;
                        default:
                            MessageBox.Show("New unit " + u.Name, "New unit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                    }
                }

                //TODO: test it
                foreach (Region region in regions)
                {
                    Pen pen = new Pen(Color.FromArgb((int)region.Team.R * 255, (int)region.Team.G * 255, (int)region.Team.B * 255));
                    pen.DashPattern = new float[] { 2, 6 };
                    graphics.DrawRectangle(pen, compX(region.Left), compY(region.Top), compD(region.Right - region.Left), compD(region.Top - region.Bottom));
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

        private float compD(float r)
        {
            return 2 * r * zoom;
        }
        #endregion

        #region GUI Methods
        private async void DrawSpace_Load(object sender, EventArgs e)
        {
            try
            {
                Task<List<Region>> queryRegions = galaxy.QueryRegions();
                bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

                setPens();

                await universe.Join();

                regions = await queryRegions;
                await galaxy.StartView();

                //testShip = await universe.NewShip("Test123");

                MouseWheel += new MouseEventHandler(MouseWheelHandler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            gatherEvents();
        }

        private void MouseWheelHandler(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && zoom > 0.00390625)
                zoom /= 2;
            else if (zoom <= 2048)
                zoom *= 2;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(bitmap, Point.Empty);
        }

        private void pictureBox_Resize(object sender, EventArgs e)
        {
            if (pictureBox.Width == 0 || pictureBox.Height == 0)
                return;

            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
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
            mSun mSun = new mSun(galaxy);

            using (UnitEditor ue = new UnitEditor(mSun))
                if (ue.ShowDialog() == DialogResult.OK)
                    await galaxy.UpdateUnitXml(ue.XML);

            selectedUnit = null;
        }

        private async void planetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mPlanet mPlanet = new mPlanet(galaxy);

            using (UnitEditor ue = new UnitEditor(mPlanet))
                if (ue.ShowDialog() == DialogResult.OK)
                    await galaxy.UpdateUnitXml(ue.XML);

            selectedUnit = null;
        }

        private async void moonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mMoon mMoon = new mMoon(galaxy);

            using (UnitEditor ue = new UnitEditor(mMoon))
                if (ue.ShowDialog() == DialogResult.OK)
                    await galaxy.UpdateUnitXml(ue.XML);

            selectedUnit = null;
        }

        private async void meteoroidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mMeteoroid mMeteoroid = new mMeteoroid(galaxy);

            using (UnitEditor ue = new UnitEditor(mMeteoroid))
                if (ue.ShowDialog() == DialogResult.OK)
                    await galaxy.UpdateUnitXml(ue.XML);

            selectedUnit = null;
        }

        private async void buoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mBuoy mBuoy = new mBuoy(galaxy);

            using (UnitEditor ue = new UnitEditor(mBuoy))
                if (ue.ShowDialog() == DialogResult.OK)
                    await galaxy.UpdateUnitXml(ue.XML);

            selectedUnit = null;
        }

        private async void targetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mTarget mTarget = new mTarget(galaxy);

            using (UnitEditor ue = new UnitEditor(mTarget))
                if (ue.ShowDialog() == DialogResult.OK)
                    await galaxy.UpdateUnitXml(ue.XML);

            selectedUnit = null;
        }
        #endregion
    }
}
