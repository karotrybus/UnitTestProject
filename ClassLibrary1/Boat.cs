using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Boat : IBoat
    {
        public string Name { get; set; }

        public int Crew { get; set; }

        public int Sails { get; set; }

        public bool Docked { get; set; }

        public Boat(string name, int crew, int sails)
        {
            Name = name;
            Crew = crew;
            Sails = sails;
            Docked = true;
        }

        public bool IsInPort()
        {
            return Docked;
        }

        public bool DockIn()
        {
            Docked = true;
            return Docked;
        }

        public bool SailAway()
        {
            Docked = false;
            return Docked;
        }

        public void ChangeSailsNumber(int newSails)
        {
            Sails = newSails;
        }
    }
}
