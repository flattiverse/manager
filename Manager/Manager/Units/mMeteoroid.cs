using System;
using System.Xml;
using Flattiverse;

namespace Manager.Units
{
    public class mMeteoroid : mUnit
    {
        #region Fields
        public float Gravity;
        public float Radiation;
        #endregion

        #region Constructors
        public mMeteoroid() { }

        public mMeteoroid(Meteoroid meteoroid) : base(meteoroid)
        {
            Gravity = meteoroid.Gravity;
            Radiation = meteoroid.Radiation;
        }
        #endregion

        #region Methods
        public override XmlElement CreateXmlElement(XmlDocument xmlDoc)
        {
            XmlElement el = xmlDoc.CreateElement("Meteoroid");

            setBaseAttributes(el);

            el.SetAttribute("Gravity", Gravity.ToString());
            el.SetAttribute("Radiation", Radiation.ToString());
            return el;
        }
        #endregion
    }
}
