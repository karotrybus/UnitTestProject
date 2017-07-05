using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ClassLibrary2Test
{
    public class Class1
    {
        [Fact]
        public void PassTest()
        {
            Assert.Equal(4, 4);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void IsInPortTest(bool value)
        {
            ClassLibrary1.Boat boat = new ClassLibrary1.Boat("Notos", 4, 4);
            boat.Docked = value;

            Assert.True(boat.IsInPort());
        }

        [Theory]
        [InlineData("Notos", 4, 4, 5)]
        public void ChangeSailsNumberTest(string name, int crew, int sail, int newSails)
        {
            ClassLibrary1.Boat boat = new ClassLibrary1.Boat(name, crew, sail);
            boat.ChangeSailsNumber(newSails);
            Assert.Equal(boat.Sails, newSails);
        }

        [Theory]
        [InlineData("Notos",4,4,"Giżycko")]
        public void RemoveBoatFromPortTest(string nameB, int crew, int sails, string nameP)
        {
            ClassLibrary1.Boat boat = new ClassLibrary1.Boat(nameB, crew, sails);
            ClassLibrary1.Port port = new ClassLibrary1.Port(nameP, boat);

            port.RemoveBoatFromPort(boat.Name);
            Assert.Equal(port.NumberOfPortsBoats, 0);
        }

        [Fact]
        public void JakisTest()
        {
            ClassLibrary1.Port port = new ClassLibrary1.Port("Mikołajki", new ClassLibrary1.Boat("Notos", 4, 4));

            var check = port.Name.Contains("Miko");
            Assert.Equal(false, check);
        }

    }
}
