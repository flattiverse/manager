using Flattiverse;
using Flattiverse.Units;
using System;
using System.Xml;

namespace Manager.Units
{
    public class mSun : mUnit
    {
        #region Fields
        public float Gravity;
        public float Radiation;
        public float PowerOutput;
        public FlattiverseResourceKind ResourceKind;
        #endregion

        #region Constructors
        public mSun(Galaxy galaxy) : base(galaxy)
        {
        }

        public mSun(Unit unit) : base(unit)
        {
            if (!(unit is Sun))
                throw new Exception("mSun can be created only based on Sun");

            Sun sun = (Sun)unit;

            Gravity = sun.Gravity;
            Radiation = sun.Radiation;
            PowerOutput = sun.PowerOutput;
            ResourceKind = sun.Resource;
        }
        #endregion

        #region Methods
        public override XmlElement CreateXmlElement(XmlDocument xmlDoc)
        {
            XmlElement el = xmlDoc.CreateElement("Sun");

            setBaseAttributes(el);

            el.SetAttribute("Radius", R.ToString());
            el.SetAttribute("Gravity", Gravity.ToString());
            el.SetAttribute("Radiation", Radiation.ToString());
            el.SetAttribute("PowerOutput", PowerOutput.ToString());
            el.SetAttribute("Resource", ResourceKind.ToString());

            return el;
        }

        public override mUnit Copy()
        {
            mSun copy = new mSun(Unit);
            copy.Name = Unit.Name + "_Copy";
            return copy;
        }
        #endregion
    }
}
