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

        [TestMethod]
        public void StaffIdOK()
        {
            // Creates an instance of the Class clsStaff.
            clsStaff AStaff = new clsStaff();
            // Creates some test data to assign to the Property
            Int32 TestData = 3; 
            // Assign the data to the property.
            AStaff.StaffId = TestData;
            // Test to see that the two values are the same.
            Assert.AreEqual(AStaff.StaffId, TestData);
        }

        [TestMethod]
        public void FirstNameOK()
        { 
            // Creates an instance of the Class clsStaff.
            clsStaff AStaff = new clsStaff();
            // Creates some test data to assign to the Property
            String TestData = "Firstname";
            // Assign the data to the property.
            AStaff.FirstName = TestData;
            // Test to see that the two values are the same.
            Assert.AreEqual(AStaff.FirstName, TestData);
        }

        [TestMethod]
        public void LastNameOK()
        {
            // Creates an instance of the Class clsStaff.
            clsStaff AStaff = new clsStaff();
            // Creates some test data to assign to the Property
            String TestData = "Lastname";
            // Assign the data to the property.
            AStaff.LastName = TestData;
            // Test to see that the two values are the same.
            Assert.AreEqual(AStaff.LastName, TestData);
        }

        [TestMethod]
        public void PayeeDetailsOK()
        {
            // Creates an instance of the Class clsStaff.
            clsStaff AStaff = new clsStaff();
            // Creates some test data to assign to the Property
            String TestData = "PayeeDetails";
            // Assign the data to the property.
            AStaff.PayeeDetails = TestData;
            // Test to see that the two values are the same.
            Assert.AreEqual(AStaff.PayeeDetails, TestData);
        }

        [TestMethod]
        public void HasPermsOK()
        {
            // Creates an instance of the Class clsStaff.
            clsStaff AStaff = new clsStaff();
            // Creates some test data to assign to the Property
            bool TestData = false;
            // Assign the data to the property.
            AStaff.HasPerms = TestData;
            // Test to see that the two values are the same.
            Assert.AreEqual(AStaff.HasPerms, TestData);
        }

        [TestMethod]
        public void JoinDateOK()
        {
            // Creates an instance of the Class clsStaff.
            clsStaff AStaff = new clsStaff();
            // Creates some test data to assign to the Property
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property.
            AStaff.JoinDate = TestData;
            // Test to see that the two values are the same.
            Assert.AreEqual(AStaff.JoinDate, TestData);
        }

        [TestMethod]
        public void ContractExpiryOk()
        {
            // Creates an instance of the Class clsStaff.
            clsStaff AStaff = new clsStaff();
            // Creates some test data to assign to the Property
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property.
            AStaff.ContractExpiary = TestData;
            // Test to see that the two values are the same.
            Assert.AreEqual(AStaff.ContractExpiary, TestData);
        }

        [TestMethod]
        public void StaffIDFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 StaffID = 3;
            Found = AStaff.Find(StaffID);
            if (AStaff.StaffId != 3)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FirstNameFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            String Firstname = "Steven";
            Int32 StaffID = 3;
            Found = AStaff.Find(StaffID);
            if (AStaff.FirstName != Firstname)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void LastNameFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            String Lastname = "Williams";
            Int32 StaffID = 3;
            Found = AStaff.Find(StaffID);
            if (AStaff.LastName != Lastname)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void PayeeDetailsFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            String PayeeDetails = "testhash";
            Int32 StaffID = 3;
            Found = AStaff.Find(StaffID);
            if (AStaff.PayeeDetails != PayeeDetails)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void HasPermsFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Boolean Perms = false;
            Int32 StaffID = 3;
            Found = AStaff.Find(StaffID);
            if (AStaff.HasPerms != Perms)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void JoinDateFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 3;
            Found = AStaff.Find(StaffID);
            if (AStaff.JoinDate != Convert.ToDateTime("08/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ContractExpiryFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 3;
            Found = AStaff.Find(StaffID);
            if (AStaff.ContractExpiary != Convert.ToDateTime("09/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}
