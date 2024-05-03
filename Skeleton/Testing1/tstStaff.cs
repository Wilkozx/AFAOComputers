using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        { 
            // create an instance of a Staff
            clsStaff AStaff = new clsStaff();
            // Check if it exists
            Assert.IsNotNull(AStaff);
        }
    }
}
