using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IBoat
    {
        bool Docked { get; set; }

        int Sails { get; set; }
        bool IsInPort();

        bool DockIn();
        bool SailAway();

        void ChangeSailsNumber(int newSails);
    }
}
