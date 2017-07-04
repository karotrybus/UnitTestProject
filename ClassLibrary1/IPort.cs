using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IPort
    {
        string Name { get; set; }
        void EntryToPort(Boat boat);
        void SailingOutOfPort(Boat boat);
        int GetNumberOfBoats();
    }
}
