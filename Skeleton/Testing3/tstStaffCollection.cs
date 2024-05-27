using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

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

        [TestMethod]
        public void AddMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create the test data for it
            clsStaff TestItem = new clsStaff();
            // variable to store the primary key
            Int32 PrimaryKey = 0;
            // set it's properties
            TestItem.FirstName = "Test";
            TestItem.LastName = "Test";
            // generate sort code & account number
            string sortCode = "123456";
            string accountNumber = "12324123";
            string unhashedPayeeDetails = sortCode + accountNumber;
            TestItem.PayeeDetails = unhashedPayeeDetails;
            TestItem.HasPerms = false;
            TestItem.JoinDate = DateTime.Now;
            TestItem.ContractExpiary= DateTime.Now.AddDays(1);
            // set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            // add the record   
            PrimaryKey = AllStaff.Add();
            // set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            // find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            // test to see if thw two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // create an instance of the class we want to test
            clsStaffCollection StaffList = new clsStaffCollection();
            // create the item for test data
            clsStaff TestItem = new clsStaff();
            // Variable to store the primary key
            Int32 PrimaryKey = 0;
            // set it's properties
            TestItem.FirstName= "Test";
            TestItem.LastName= "Test";
            // generate sort code & account number
            string sortCode = "123456";
            string accountNumber = "12324123";
            string unhashedPayeeDetails = sortCode + accountNumber;
            TestItem.PayeeDetails = unhashedPayeeDetails;
            TestItem.HasPerms = false;
            TestItem.JoinDate = DateTime.Now;
            TestItem.ContractExpiary = DateTime.Now.AddDays(1);
            // set thisAddress to the test data
            StaffList.ThisStaff = TestItem;
            // add the record
            PrimaryKey = StaffList.Add();
            // set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            // modify the test record
            TestItem.FirstName = "TestChanged";
            TestItem.LastName = "TestChanged";
            TestItem.HasPerms = true;
            TestItem.JoinDate = DateTime.Now.AddDays(31);
            TestItem.ContractExpiary= DateTime.Now.AddDays(52);
            // set the record based on new data
            StaffList.ThisStaff = TestItem;
            // update the record
            StaffList.Update();
            // find the record
            StaffList.ThisStaff.Find(PrimaryKey);
            // test to see if ThisStaff matches the test data
            Assert.AreEqual(StaffList.ThisStaff, TestItem);
            
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // create an instance of the class we want to create
            clsStaffCollection StaffList = new clsStaffCollection();
            // create the item of test data
            clsStaff TestItem = new clsStaff();
            // Variable to store primary key
            Int32 PrimaryKey = 0;
            // set it's properties
            TestItem.FirstName = "Test";
            TestItem.LastName = "Test";
            // generate sort code & account number
            string sortCode = "123456";
            string accountNumber = "12324123";
            string unhashedPayeeDetails = sortCode + accountNumber;
            TestItem.PayeeDetails = unhashedPayeeDetails;
            TestItem.HasPerms = false;
            TestItem.JoinDate = DateTime.Now;
            TestItem.ContractExpiary = DateTime.Now.AddDays(1);
            //set ThisStaff to the test data
            StaffList.ThisStaff = TestItem;
            // add the record
            PrimaryKey = StaffList.Add();
            // set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            // find the record
            StaffList.ThisStaff.Find(PrimaryKey);
            // delete the record
            StaffList.Delete();
            // now find the record
            Boolean Found = StaffList.ThisStaff.Find(PrimaryKey);
            // test to see that the record was not found
            Assert.IsFalse(Found);
        }




    }
}
