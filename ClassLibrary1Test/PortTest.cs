using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace ClassLibrary1Test
{
    [TestFixture]
    public class PortTest
    {
        [Test]
        public void EntryToPortTest()
        {
            ClassLibrary1.Port port = new ClassLibrary1.Port();
            ClassLibrary1.Boat boat = new ClassLibrary1.Boat("Krasula", 4);
            port.EntryToPort(boat);
            int expected = port.NumberOfBoats;
            Assert.That(expected, Is.EqualTo(1));
        }

        
    }
}
