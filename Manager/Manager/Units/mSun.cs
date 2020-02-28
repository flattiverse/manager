using System;
using System.Xml;
using Flattiverse;

namespace Manager.Units
{
    public class mSun : mUnit
    {
        #region Fields
        public float Gravity;
        public float Radiation;
        public float PowerOutput;
        public float PlasmaLevel;
        public float Amount;
        #endregion

        #region Constructors
        public mSun() { }

        public mSun(Sun sun) : base(sun)
        {
            Gravity = sun.Gravity;
            Radiation = sun.Radiation;
            PowerOutput = sun.PowerOutput;
            //PlasmaLevel = sun.PlasmaLevel; //TODO: comment out when ready
            //Amount = sun.Amount;
        }
        #endregion

        #region Methods
        public override XmlElement CreateXmlElement(XmlDocument xmlDoc)
        {
            XmlElement el = xmlDoc.CreateElement("Sun");

            setBaseAttributes(el);

            el.SetAttribute("Gravity", Gravity.ToString());
            el.SetAttribute("Radiation", Radiation.ToString());
            el.SetAttribute("PowerOutput", PowerOutput.ToString());
            //el.SetAttribute("Plasma Level", PlasmaLevel.ToString()); //TODO: comment out when ready
            //el.SetAttribute("Amount", Amount.ToString());

            return el;
        }
        #endregion
    }
}
