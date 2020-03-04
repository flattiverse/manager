using System;
using System.Xml;
using Flattiverse;
using Flattiverse.Units;

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
        public mTarget(Galaxy galaxy) : base(galaxy)
        {
            Team = galaxy.Universe.Teams.List[0];
        }

        public mTarget(Unit unit) : base(unit)
        {
            if (!(unit is Target))
                throw new Exception("mTarget can be created only based on Target");

            Target target = (Target)unit;

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

            el.SetAttribute("Team", Team.ID.ToString());
            el.SetAttribute("Sequence", Sequence.ToString());

            if (Hint.HasValue)
                el.SetAttribute("Hint", Hint.ToString());

            return el;
        }

        public override mUnit Copy()
        {
            mTarget copy = new mTarget(Unit);
            copy.Name = Unit.Name + "_Copy";
            return copy;
        }
        #endregion
    }
}
