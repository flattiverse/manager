using System;
using System.Xml;
using Flattiverse;

namespace Manager.Units
{
    public class mMoon : mUnit
    {
        #region Fields
        public float Gravity;
        public float Radiation;
        #endregion

        #region Constructors
        public mMoon() { }

        public mMoon(Moon moon) : base(moon)
        {
            Gravity = moon.Gravity;
            Radiation = moon.Radiation;
        }
        #endregion

        #region Methods
        public override XmlElement CreateXmlElement(XmlDocument xmlDoc)
        {
            XmlElement el = xmlDoc.CreateElement("Moon");

            setBaseAttributes(el);

            el.SetAttribute("Gravity", Gravity.ToString());
            el.SetAttribute("Radiation", Radiation.ToString());
            return el;
        }
        #endregion
    }
}
