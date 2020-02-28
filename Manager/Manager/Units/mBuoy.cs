using System;
using System.Xml;
using Flattiverse;

namespace Manager.Units
{
    public class mBuoy : mUnit
    {
        #region Constructors
        public mBuoy() { }

        public mBuoy(Buoy buoy) : base(buoy)
        {
        }
        #endregion

        #region Methods
        public override XmlElement CreateXmlElement(XmlDocument xmlDoc)
        {
            XmlElement el = xmlDoc.CreateElement("Buoy");

            setBaseAttributes(el);

            return el;
            //TODO: anything to add?
        }
        #endregion
    }
}
