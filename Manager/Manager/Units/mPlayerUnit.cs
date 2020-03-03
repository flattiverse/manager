using Flattiverse;
using Flattiverse.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Units
{
    public class mPlayerUnit : mUnit
    {
        #region Fields
        public float Direction;
        public float Engine;
        public float Rotation;
        public float Thruster;
        public Scanner BroadScanner;
        #endregion

        #region Constructors
        public mPlayerUnit(PlayerUnit playerUnit) : base(playerUnit)
        {
            Direction = playerUnit.Direction;
            Engine = playerUnit.Engine;
            Rotation = playerUnit.Rotation;
            Thruster = playerUnit.Thruster;
            BroadScanner = playerUnit.BroadScanner;
        }
        #endregion
    }
}
