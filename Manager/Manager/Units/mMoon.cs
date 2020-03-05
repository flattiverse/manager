using System;
using System.Xml;
using Flattiverse;
using Flattiverse.Units;

namespace Manager.Units
{
    public class mMoon : mUnit
    {
        #region Fields
        public float Gravity;
        public float Radiation;
        public FlattiverseResourceKind ResourceKind;
        #endregion

        #region Constructors
        public mMoon(Galaxy galaxy) : base(galaxy) { }

        public mMoon(Unit unit) : base(unit)
        {
            if (!(unit is Moon))
                throw new Exception("mMoon can be created only based on Moon");

            Moon moon = (Moon)unit;

            Gravity = moon.Gravity;
            Radiation = moon.Radiation;
            ResourceKind = moon.Resource;
        }
        #endregion

        #region Methods
        public override XmlElement CreateXmlElement(XmlDocument xmlDoc)
        {
            XmlElement el = xmlDoc.CreateElement("Moon");

            setBaseAttributes(el);

            el.SetAttribute("Radius", R.ToString());
            el.SetAttribute("Gravity", Gravity.ToString());
            el.SetAttribute("Resource", ResourceKind.ToString());
            el.SetAttribute("Radiation", Radiation.ToString());
            return el;
        }

        public override mUnit Copy()
        {
            mMoon copy = new mMoon(Unit);
            copy.Name = Unit.Name + "_Copy";
            return copy;
        }
        #endregion
    }
}
