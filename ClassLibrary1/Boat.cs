using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Boat
    {
        public string Name { get; set; }

        public int Crew { get; set; }

        public Boat(string name, int crew)
        {
            Name = name;
            Crew = crew;
        }
    }
}
