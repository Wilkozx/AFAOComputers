using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        String Staff_Id = "2";
        String Firstname = "Alex";
        String Lastname = "Purgatory";
        String HasPerms = "false";
        String Sortcode = "523142";
        String AccountNumber = "27364927";
        String Join_Date = DateTime.Now.ToString();
        String Contract_Expiry_Date = DateTime.Now.AddDays(2).ToString();

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
            Int32 StaffID = 1;
            Found = AStaff.Find(StaffID);
            if (AStaff.StaffId != 1)
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
            String Firstname = "Alex";
            Int32 StaffID = 1;
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
            String Lastname = "Talks";
            Int32 StaffID = 1;
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
            String PayeeDetails = "8743b52063cd84097a65d1633f5c74f5";
            Int32 StaffID = 1;
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
            Int32 StaffID = 1;
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
            Int32 StaffID = 1;
            Found = AStaff.Find(StaffID);
            if (AStaff.JoinDate != Convert.ToDateTime("26/07/2024"))
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
            Int32 StaffID = 1;
            Found = AStaff.Find(StaffID);
            if (AStaff.ContractExpiary != Convert.ToDateTime("26/07/2026"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // Create instance of class
            clsStaff AStaff = new clsStaff();
            // Create variable to store error message
            String Error = "";
            // Invoke valid method
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            // test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMinLessOne()
        {
            // Create instance of the class
            clsStaff AStaff = new clsStaff();
            // String to store error message
            String Error = "";
            // Create some test data to pass through to the method
            String Firstname = "";
            // Invoke method
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            // Test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Firstname = "a";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Firstname = "aa";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Firstname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Firstname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Firstname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Firstname = "";
            Firstname = Firstname.PadRight(25, 'a');
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstnameExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Firstname = "";
            Firstname = Firstname.PadRight(500, 'a');
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Lastname = "";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Lastname = "a";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnamePlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Firstname = "aa";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Lastname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Lastname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Lastname = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastnameMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Lastname = "";
            Lastname = Lastname.PadRight(25, 'a');
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastnameExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Lastname = "";
            Firstname = Lastname.PadRight(1000, 'a');
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SortcodeMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Sortcode = "1";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SortcodeMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Sortcode = "12";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SortcodeMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Sortcode = "12345";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SortcodeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Sortcode = "123456";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SortcodeMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Sortcode = "1234567";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SortcodeMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Sortcode = "123";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SortcodeExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Sortcode = "";
            Sortcode = Sortcode.PadRight(500, '1');
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String AccountNumber = "1";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String AccountNumber = "12";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String AccountNumber = "123456789";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String AccountNumber = "1234567890";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String AccountNumber = "12345678901";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String AccountNumber = "12345";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String AccountNumber = "";
            AccountNumber = AccountNumber.PadRight(500, '1');
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HasPermsValid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String HasPerms = "true";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HasPermsInvalid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String HasPerms = "goblins";
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void JoinDateValid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Join_Date = DateTime.Now.ToString();
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContractExpiryValid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Contract_Expiry_Date = DateTime.Now.AddDays(5).ToString();
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JoinDateBeforeExpiryValid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Join_Date = DateTime.Now.ToString();
            String Contract_Expiry_Date = DateTime.Now.AddDays(1).ToString();
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void JoinDateBeforeExpiryInvalid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            String Join_Date = DateTime.Now.ToString();
            String Contract_Expiry_Date = DateTime.Now.ToString();
            Error = AStaff.Valid(Staff_Id, Firstname, Lastname, HasPerms, Sortcode, AccountNumber, Join_Date, Contract_Expiry_Date);
            Assert.AreNotEqual(Error, "");
        }







    }
}
