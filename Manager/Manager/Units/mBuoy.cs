using System;
using System.Xml;
using Flattiverse;
using Flattiverse.Units;

namespace Manager.Units
{
    public class mBuoy : mUnit
    {
        #region Fields
        public string Message;
        #endregion

        #region Constructors
        public mBuoy(Galaxy galaxy) : base(galaxy) { }

        public mBuoy(Buoy buoy) : base(buoy)
        {
            Message = buoy.Message;
        }
        #endregion

        #region Methods
        public override XmlElement CreateXmlElement(XmlDocument xmlDoc)
        {
            XmlElement el = xmlDoc.CreateElement("Buoy");

            setBaseAttributes(el);

            el.SetAttribute("Broadcast", Message); //TODO: something is wrong?

            return el;
        }
        #endregion
    }
}
