using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            // Create an instance
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Create a list of clsStaff's
            List<clsStaff> TestList = new List<clsStaff>();
            // Create a test item of test data for it
            clsStaff TestItem = new clsStaff();
            // Set the test item data
            TestItem.StaffId = 1;
            TestItem.FirstName = "Test";
            TestItem.LastName = "Test";
            TestItem.HasPerms = false;
            // add sortcode acc number here
            TestItem.JoinDate = DateTime.Now;
            TestItem.ContractExpiary = DateTime.Now.AddDays(1);
            // add item to list
            TestList.Add(TestItem);
            // assign the data to the property 
            AllStaff.StaffList = TestList;
            // test to see if the values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            // create an instance of the class to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data for the property
            clsStaff TestStaff = new clsStaff();
            // set the properties of the test object
            TestStaff.StaffId = 1;
            TestStaff.FirstName = "Test";
            TestStaff.LastName = "Test";
            TestStaff.HasPerms = false;
            TestStaff.JoinDate = DateTime.Now;
            TestStaff.ContractExpiary= DateTime.Now.AddDays(1);
            // assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data for the property
            List<clsStaff> TestList = new List<clsStaff>();
            // add an item to the list
            // create test item for the list
            clsStaff TestItem = new clsStaff();
            // set it's properties
            TestItem.StaffId = 1;
            TestItem.FirstName = "Test";
            TestItem.LastName = "Test";
            TestItem.HasPerms = false;
            TestItem.JoinDate = DateTime.Now;
            TestItem.ContractExpiary = DateTime.Now.AddDays(1);
            // add test item to the test list
            TestList.Add(TestItem);
            // assign data to property
            AllStaff.StaffList = TestList;
            // test to see if the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }




    }
}
