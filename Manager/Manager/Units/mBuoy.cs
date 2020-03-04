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

        public mBuoy(Unit buoy) : base(buoy)
        {
            if (!(buoy is Buoy))
                throw new Exception("mBouy can be created only based on Buoy");

            Message = ((Buoy)buoy).Message;
        }
        #endregion

        #region Methods
        public override XmlElement CreateXmlElement(XmlDocument xmlDoc)
        {
            XmlElement el = xmlDoc.CreateElement("Buoy");

            setBaseAttributes(el);

            el.InnerText = Message;

            return el;
        }

        public override mUnit Copy()
        {
            mBuoy copy = new mBuoy(Unit);
            copy.Name = Unit.Name + "_Copy";
            return copy;
        }
        #endregion
    }
}
