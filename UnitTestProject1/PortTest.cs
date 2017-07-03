using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestClass]
    public class PortTest
    {
        [TestMethod]
        public void EntryToPortTest()
        {
            ClassLibrary1.Port port = new ClassLibrary1.Port();
            int expectedResult = port.NumberOfBoats;
            Assert.That(expectedResult, Is.Equal)
        }
    }
}
