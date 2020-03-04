using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Flattiverse;
using Flattiverse.Units;

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
        public Unit Unit;
        #endregion

        #region Constructors
        public mUnit(Galaxy galaxy)
        {
            Galaxy = galaxy;
        }

        public mUnit(Unit unit)
        {
            Unit = unit;
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

        public virtual mUnit Copy()
        {
            mUnit copy = new mUnit(Unit);
            copy.Name = Unit.Name + "_Copy";

            return copy;
        }

        protected void setBaseAttributes(XmlElement el)
        {
            el.SetAttribute("Name", Name);
            el.SetAttribute("PositionX", X.ToString());
            el.SetAttribute("PositionY", Y.ToString());
        }
        #endregion
    }
}
