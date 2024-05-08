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

        public void ActiveUserOK()
        {
            clsUser AUser = new clsUser();
            Boolean TestData = true;
            AUser.Active = TestData;
            Assert.AreEqual(AUser.Active, TestData);
        }
        public void DateofBirthPropertyOK() 
        {
            clsUser AUser = new clsUser();  

            DateTime TestData = DateTime.Now.Date;
            AUser.DateofBirth = TestData;
            Assert.AreEqual(AUser.DateofBirth, TestData);
        }
        public void UserIdPropertyOK() 
        {
            clsUser AUser = new clsUser();
            int TestData = 1;
            AUser.UserId = TestData;
            Assert.AreEqual(AUser.UserId, TestData);
        }
        public void UserNamePropertyOK() 
        {
            clsUser AUser = new clsUser();
            string TestData = "Omar";
            AUser.UserName = TestData;
            Assert.AreEqual(AUser.UserName, TestData);
        }
        public void EmailPropertyOK()
        {
            clsUser AUser = new clsUser();
            string TestData = "Omar";
            AUser.Email = TestData;
            Assert.AreEqual(AUser.Email, TestData);
        }
        public void PasswordPropertyOK()
        {
            clsUser AUser = new clsUser();
            string TestData = "12345678aa";
            AUser.Password = TestData;
            Assert.AreEqual(AUser.Password, TestData);
        }
        public void PhoneNumberPropertyOK()
        {
            clsUser AUser = new clsUser();
            int TestData = 12345678;
            AUser.PhoneNumber = TestData;
            Assert.AreEqual(AUser.PhoneNumber, TestData);
        }


    }
}
