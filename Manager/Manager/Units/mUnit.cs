using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Flattiverse;

namespace Manager.Units
{
    public class mUnit
    {
        #region Fields
        public readonly Galaxy Galaxy;
        public string Name;
        public float X;
        public float Y;
        public float R;
        #endregion

        #region Constructors
        public mUnit() { }

        public mUnit(Unit unit)
        {
            Galaxy = unit.Galaxy;

            Name = unit.Name;
            X = unit.Position.X;
            Y = unit.Position.Y;
            R = unit.Radius;
        }
        #endregion

        #region Methods
        public virtual XmlElement CreateXmlElement(XmlDocument xmlDoc)
        { 
            return xmlDoc.CreateElement("Unit");
        }

        protected void setBaseAttributes(XmlElement el)
        {
            el.SetAttribute("Name", Name);
            el.SetAttribute("PositionX", X.ToString());
            el.SetAttribute("PositionY", Y.ToString());
            el.SetAttribute("Radius", R.ToString());
        }
        #endregion
    }
}
