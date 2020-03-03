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
        #endregion

        #region Constructors
        public mPlanet(Galaxy galaxy) : base(galaxy){ }

        public mPlanet(Planet planet) : base(planet)
        {
            Gravity = planet.Gravity;
            Radiation = planet.Radiation;
        }
        #endregion

        #region Methods
        public override XmlElement CreateXmlElement(XmlDocument xmlDoc)
        {
            XmlElement el = xmlDoc.CreateElement("Planet");

            setBaseAttributes(el);

            el.SetAttribute("Gravity", Gravity.ToString());
            el.SetAttribute("Radiation", Radiation.ToString());
            return el;
        }
        #endregion
    }
}
