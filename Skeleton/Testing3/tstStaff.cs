using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Create an instance of the Class clsStaff.
            clsStaff AStaff = new clsStaff();
            // Test to see if it exists.
            Assert.IsNotNull(AStaff);
        }
    }
}
