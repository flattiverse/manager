using System;
using System.Xml;
using Flattiverse;

namespace Manager.Units
{
    public class mTarget : mUnit
    {
        #region Fields
        public Team Team;
        public int Sequence;
        public float? Hint;
        #endregion

        #region Constructors
        public mTarget() { }

        public mTarget(Target target) : base(target)
        {
            Team = target.Team;
            Sequence = target.Sequence;
            Hint = target.Hint;
        }
        #endregion

        #region Methods
        public override XmlElement CreateXmlElement(XmlDocument xmlDoc)
        {
            XmlElement el = xmlDoc.CreateElement("Target");

            setBaseAttributes(el);

            el.SetAttribute("Team", Team.ToString());
            el.SetAttribute("Sequence", Sequence.ToString());
            el.SetAttribute("Hint", Hint.ToString());
            return el;
        }
        #endregion
    }
}
