using System;
using System.Xml;
using Flattiverse;
using Flattiverse.Units;

namespace Manager.Units
{
    public class mPlanet : mUnit
    {
        #region Fields
        public float Gravity;
        public float Radiation;
        public FlattiverseResource Resource;
        #endregion

        #region Constructors
        public mPlanet(Galaxy galaxy) : base(galaxy){ }

        public mPlanet(Unit unit) : base(unit)
        {
            if (!(unit is Planet))
                throw new Exception("mPlanet can be created only based on Planet");

            Planet planet = (Planet)unit;

            Gravity = planet.Gravity;
            Radiation = planet.Radiation;
            Resource = planet.Resource;
        }
        #endregion

        #region Methods
        public override XmlElement CreateXmlElement(XmlDocument xmlDoc)
        {
            XmlElement el = xmlDoc.CreateElement("Planet");

            setBaseAttributes(el);

            el.SetAttribute("Radius", R.ToString());
            el.SetAttribute("Gravity", Gravity.ToString());
            el.SetAttribute("Resource", Resource.ToString());
            el.SetAttribute("Radiation", Radiation.ToString());
            return el;
        }

        public override mUnit Copy()
        {
            mPlanet copy = new mPlanet(Unit);
            copy.Name = Unit.Name + "_Copy";
            return copy;
        }
        #endregion
    }
}
