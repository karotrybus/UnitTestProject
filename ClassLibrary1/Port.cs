using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Port
    {
        public string Name { get; set; }

        public int NumberOfBoats { get; set; }

        public List<Boat> boats = new List<Boat>();

        public void PrintPortName()
        {
            System.Diagnostics.Debug.WriteLine(Name);
        }

        public void EntryToPort(Boat boat)
        {
            AddBoatToPort(boat);
            NumberOfBoats++;
        }

        public void SailingOutOfPort(Boat boat)
        {
            RemoveBoatFromPort(boat.Name);
            NumberOfBoats--;
        }

        public void AddBoatToPort(Boat boat)
        {
            boats.Add(boat);
        }

        public void RemoveBoatFromPort(String boatName)
        {
            boats.Find(b => b.Name == boatName);
        }
    }    
}
