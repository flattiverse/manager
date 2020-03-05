using Flattiverse;
using Flattiverse.Units;
using System;
using System.Xml;

namespace Manager.Units
{
    public class mCorona
    {
        #region Fiedls
        public float Radius;
        public float Amount;
        public Plasma Plasma;
        #endregion

        #region Constructors
        public mCorona()
        {
            Plasma = new Plasma();
        }

        //public mCorona(SunCorona corona)
        //{
        //    if (corona == null)
        //        throw new Exception("Corona cannot be null");

        //    Radius = corona.Radius;
        //    Amount = corona.Amount;
        //    Plasma = corona.Plasma;
        //}
        #endregion

        #region Methods
        public XmlElement AddXmlAttributes(XmlDocument xmlDoc, XmlElement el)
        {
            XmlElement childEl = xmlDoc.CreateElement("Plasma");
            childEl.SetAttribute("Level", ((int)Plasma).ToString());
            childEl.SetAttribute("Amount", Amount.ToString());
            childEl.SetAttribute("Radius", Radius.ToString());

            el.AppendChild(childEl);

            return el;
        }
        #endregion

    }
}
