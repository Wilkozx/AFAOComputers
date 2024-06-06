using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstUserAccount
    {
        [TestMethod]
        public void InstanceOk()
        {
            // create an instance of the class we want to create
            clsUserAccount AnAccount = new clsUserAccount();
            // test to see that it exists
            Assert.IsNotNull(AnAccount);
        }
        [TestMethod]
        public void UserIDPropertyOK()
        {
            // create an instance of the class
            clsUserAccount AnAccount = new clsUserAccount();
            // create some test data to assign to the property
            Int32 TestData = 1;
            // assign the data to the property
            AnAccount.UserID = TestData;
            // test to see if the values are the same
            Assert.AreEqual(AnAccount.UserID, TestData);
        }
        [TestMethod]
        public void UsernamePropertyOK()
        {
            // create an instance of the class
            clsUserAccount AnAccount = new clsUserAccount();
            // create some test data to assign to the property
            string TestData = "Omar";
            // assign the data to the property
            AnAccount.Username = TestData;
            // test to see if the values are the same
            Assert.AreEqual(AnAccount.Username, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            // create an instance of the class
            clsUserAccount AnAccount = new clsUserAccount();
            // create some test data to assign to the property
            string TestData = "Pass1234";
            // assign the data to the property
            AnAccount.Password = TestData;
            // test to see if the values are the same
            Assert.AreEqual(AnAccount.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            // create an instance of the class
            clsUserAccount AnAccount = new clsUserAccount();
            // create some test data to assign to the property
            string TestData = "Customer Management";
            // assign the data to the property
            AnAccount.Department = TestData;
            // test to see if the values are the same
            Assert.AreEqual(AnAccount.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            // create an instance of the class
            clsUserAccount AnAccount = new clsUserAccount();
            // create a bool to store results of validation
            Boolean Found = false;
            // create some test data
            string Username = "Omar";
            string Password = "Pass1234";
            // invoke the method
            Found = AnAccount.FindAccount(Username, Password);
            // test to see if result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUsernamePWFound()
        {
            // create an instance of the class
            clsUserAccount AnAccount = new clsUserAccount();
            // create a bool to store result of search
            Boolean Found = false;
            // create a boolean to record if data is ok
            Boolean OK = true;
            // create some test data to use with method
            string Username = "Omar";
            string Password = "Pass1234";
            // invoke the method
            Found = AnAccount.FindAccount(Username, Password);
            // check the user id property
            if (AnAccount.Username != Username && AnAccount.Password != Password)
            {
                OK = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(OK);
        }
    }
}
