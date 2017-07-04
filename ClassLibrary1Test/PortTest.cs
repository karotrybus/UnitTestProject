using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;

namespace ClassLibrary1Test
{
    [TestFixture]
    public class PortTest
    {
        ClassLibrary1.Port port;
        [TestFixtureSetUp]        
        public void TestSetup()
        {
            port = new ClassLibrary1.Port("Sztynort", new ClassLibrary1.Boat("Krasula", 4, 3));
        }

        [Test]
        public void EntryToPortTest()
        {
            //ClassLibrary1.Port port = new ClassLibrary1.Port("Sztynort", new ClassLibrary1.Boat("Krasula", 4));
            ClassLibrary1.Boat boat = new ClassLibrary1.Boat("Toskania", 7, 4);
            port.EntryToPort(boat);
            int expected = port.NumberOfPortsBoats;
            Assert.That(expected, Is.EqualTo(2));
        }

        [Test]
            //[Ignore]
            public void SailingOutOfPortTest()
            {
                //ClassLibrary1.Port port = new ClassLibrary1.Port("Wilkasy", new ClassLibrary1.Boat("Bloody Mary", 6));
                var boat = port.boats.Find(b => b.Name == "Krasula");
                port.SailingOutOfPort(boat);
                int expected = port.NumberOfPortsBoats;
                Assert.That(expected, Is.EqualTo(1));
            }

        [Test]
        public void CheckStringValue()
        {
            string boatName = port.boats.Find(b => b.Name == "Krasula").Name;
            boatName.Should().StartWith("Kr").And.EndWith("la");
        }

        [Test]
        public void CheckCollection()
        {
            port.boats.Should().HaveCount(1, "we should have one boat!");
        }

        [TestFixtureTearDown]
        public void TestTearDown()
        {
            port = null;
        }

    }
}
