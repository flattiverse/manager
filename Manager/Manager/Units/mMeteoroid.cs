using System;
using System.Xml;
using Flattiverse;
using Flattiverse.Units;

namespace Manager.Units
{
    public class mMeteoroid : mUnit
    {
        #region Fields
        public float Gravity;
        public float Radiation;
        public FlattiverseResource Resource;
        #endregion

        #region Constructors
        public mMeteoroid(Galaxy galaxy) : base(galaxy) { }

        public mMeteoroid(Unit unit) : base(unit)
        {
            if (!(unit is Meteoroid))
                throw new Exception("mMeteoroid can be created only based on Buoy");

            Meteoroid meteoroid = (Meteoroid)unit;

            Gravity = meteoroid.Gravity;
            Radiation = meteoroid.Radiation;
            Resource = meteoroid.Resource;
        }
        #endregion

        #region Methods
        public override XmlElement CreateXmlElement(XmlDocument xmlDoc)
        {
            XmlElement el = xmlDoc.CreateElement("Meteoroid");

            setBaseAttributes(el);

            el.SetAttribute("Radius", R.ToString());
            el.SetAttribute("Gravity", Gravity.ToString());
            el.SetAttribute("Resource", Resource.ToString());
            el.SetAttribute("Radiation", Radiation.ToString());
            return el;
        }

        public override mUnit Copy()
        {
            mMeteoroid copy = new mMeteoroid(Unit);
            copy.Name = Unit.Name + "_Copy";
            return copy;
        }
        #endregion
    }
}
