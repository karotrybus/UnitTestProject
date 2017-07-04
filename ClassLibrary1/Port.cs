using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Port : IPort
    {
        public string Name { get; set; }

        public int NumberOfPortsBoats { get; set; }

        public Port(String name, Boat boat)
        {
            Name = name;
            AddBoatToPort(boat);
        }

        public List<Boat> boats = new List<Boat>();

        public void PrintPortName()
        {
            System.Diagnostics.Debug.WriteLine(Name);
        }

        public void EntryToPort(Boat boat)
        {
            AddBoatToPort(boat);
        }

        public void SailingOutOfPort(Boat boat)
        {
            RemoveBoatFromPort(boat.Name);
        }

        public void AddBoatToPort(Boat boat)
        {
            boats.Add(boat);
            NumberOfPortsBoats++;
        }

        public void RemoveBoatFromPort(String boatName)
        {
            var boatToRemove = boats.Find(b => b.Name == boatName);
            boats.Remove(boatToRemove);
            NumberOfPortsBoats--;
        }

        public int GetNumberOfBoats()
        {
            return NumberOfPortsBoats;
        }
    }    
}
