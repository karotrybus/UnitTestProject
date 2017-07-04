using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MoqTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsBoatInPortTest()
        {
            var checker = new ClassLibrary1.BoatsChecker();
            var portMock = new Mock<ClassLibrary1.IPort>();

            portMock.Setup(x => x.GetNumberOfBoats()).Returns(1);

            bool check = checker.IsAnyBoatInPort(portMock.Object);

            Assert.AreEqual(check, true);
        }

        [TestMethod]
        public void ChangeSailsNumberTest()
        {
            var boatMock = new Mock<ClassLibrary1.IBoat>();

            int number = 5;
            boatMock.SetupProperty(boat => boat.Sails, 4);

            boatMock.Setup(x => x.ChangeSailsNumber(It.IsAny<int>()))
                .Callback((int newSails) =>
                {
                    boatMock.SetupProperty(boat => boat.Sails, number);
                });

            boatMock.Object.ChangeSailsNumber(number);
            int check = boatMock.Object.Sails;

            Assert.AreEqual(check, number);
        }

        [TestMethod]
        public void DockInTest()
        {
            var boatMock = new Mock<ClassLibrary1.IBoat>();

            boatMock.SetupProperty(boat => boat.Docked, false);

            boatMock.Setup(b => b.DockIn())
                .Callback(() =>
                {
                    boatMock.SetupProperty(boat => boat.Docked, true);
                });

            boatMock.Object.DockIn();

            bool check = boatMock.Object.Docked;

            Assert.IsTrue(check);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Some exception")]
        public void PortNameTest()
        {
            var portMock = new Mock<ClassLibrary1.IPort>();
            
            portMock.Setup(b => b.GetNumberOfBoats()).Throws(new Exception("Haha!"));

            try
            {
                int res = portMock.Object.GetNumberOfBoats();
            }
            catch (Exception e)
            {
                Assert.Fail("failed");
            }

        }
    }
}