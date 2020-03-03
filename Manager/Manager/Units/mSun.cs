using Flattiverse;
using Flattiverse.Units;
using System.Xml;

namespace Manager.Units
{
    public class mSun : mUnit
    {
        #region Fields
        public float Gravity;
        public float Radiation;
        public float PowerOutput;
        public mCorona mCorona;
        #endregion

        #region Constructors
        public mSun(Galaxy galaxy) : base(galaxy)
        {
            mCorona = new mCorona();
        }

        public mSun(Sun sun) : base(sun)
        {
            Gravity = sun.Gravity;
            Radiation = sun.Radiation;
            PowerOutput = sun.PowerOutput;

            if (sun.Corona != null)
                mCorona = new mCorona(sun.Corona);
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

            if (mCorona != null && mCorona.Plasma > 0)
                mCorona.AddXmlAttributes(xmlDoc, el);

            return el;
        }
        #endregion
    }
}
