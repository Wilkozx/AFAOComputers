using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstUser
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the we want to create
            clsUser AUser = new clsUser();
            //test to see that it exists
            Assert.IsNotNull(AUser);
        }
        [TestMethod]
        public void ActiveUserOK()
        {
            //create an instance of the we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AUser.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Active, TestData);
        }
        [TestMethod]
        public void DateofBirthPropertyOK() 
        {
            //create an instance of the we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AUser.DateofBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.DateofBirth, TestData);
        }
        [TestMethod]
        public void UserIdPropertyOK() 
        {
            //create an instance of the we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AUser.UserId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.UserId, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK() 
        {
            //create an instance of the we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "Omar";
            //assign the data to the property
            AUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.UserName, TestData);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "Omar";
            //assign the data to the property
            AUser.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Email, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "12345678aa";
            //assign the data to the property
            AUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Password, TestData);
        }
        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            //create an instance of the we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            int TestData = 12345678;
            //assign the data to the property
            AUser.PhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.PhoneNumber, TestData);
        }


    }
}
