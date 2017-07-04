using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BoatsChecker
    {
        public bool IsAnyBoatInPort(IPort port)
        {
            if (port == null) throw new ArgumentNullException(nameof(port));

            if (port.GetNumberOfBoats() <= 0)
                return false;
            else
                return true;
        }

        public bool IsBoatInPort(IBoat boat)
        {
            if (boat == null) throw new ArgumentNullException(nameof(boat));

            return boat.Docked;
        }

        public int GetNumerOfSails(IBoat boat)
        {
            return boat.Sails;
        }

    }
}
