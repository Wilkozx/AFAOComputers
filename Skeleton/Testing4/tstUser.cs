﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstUser
    {
        int UserId = 1;
        string UserName = "Omar";
        string Email = "omar@gmail.com";
        string DateofBirth = DateTime.Now.ToShortDateString();
        string HashedPass = "xxxxx";
        int PhoneNumber = 12345678;
        bool isStaff = true;
        
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the we want to create
            clsUser AUser = new clsUser();
            //test to see that it exists
            Assert.IsNotNull(AUser);
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
            AUser.HashedPass = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.HashedPass, TestData);
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
        public void isStaffPropertyOK()
        {
            //create an instance of the we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            bool TestData = false;
            //assign the data to the property
            AUser.isStaff = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.isStaff, TestData);
        }

        [TestMethod]
        public void FindUserID()
        {

            clsUser AUser = new clsUser();
            Boolean Found = false;
            Int32 UserId = 2;
            Found = AUser.Find(UserId);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void UserIdFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 UserId = 2;
            Found = AUser.Find(UserId);
            if (AUser.UserId != 2)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void UserNameFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 UserId = 2;
            Found = AUser.Find(UserId);
            if (AUser.UserName != "omar")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void EmailFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 UserId = 2;
            Found = AUser.Find(UserId);
            if (AUser.Email != "omar@gmail.com")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void DateofBirthFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 UserId = 2;
            Found = AUser.Find(UserId);
            if (AUser.DateofBirth != Convert.ToDateTime("23/12/2022"))
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void HashedPassFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 UserId = 2;
            Found = AUser.Find(UserId);
            if (AUser.HashedPass != "xxxxxxxxxx")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void PhoneNumberFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 UserId = 2;
            Found = AUser.Find(UserId);
            if (AUser.PhoneNumber != 12345678)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void isStaffFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 UserId = 2;
            Found = AUser.Find(UserId);
            if (AUser.isStaff != true)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ValidMethodOK() {
            clsUser AUser = new clsUser();
            String Error = "";
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMinLessOne() 
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Username = "aaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Username = "aaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Username = "aaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Username = "aaaaaaaaaaaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Username = "aaaaaaaaaaaaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Username = "aaaaaaaaaaaaaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Username = "aaaaaaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        public void EmailMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "aaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        public void EmailMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "aaaaa";
            Error = AUser.Valid(UserId, UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        public void EmailMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "aaaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        public void EmailMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "aaaa";
            Email = Email.PadRight(49, 'a');
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        public void EmailMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "aaaa";
            Email = Email.PadRight(50, 'a');
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        public void EmailMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "aaaa";
            Email = Email.PadRight(51, 'a');
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");

        }
        public void EmailMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "aaaa";
            Email = Email.PadRight(25, 'a');
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        public void PhoneNumberMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            int Number = 11111;
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        public void PhoneNumberMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            int Number = 111111;
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        public void PhoneNumberMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            int Number = 1111111;
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        public void PhoneNumberMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            Int64 Number = 11111111111111;
            
            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        public void PhoneNumberMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            Int64 Number = 111111111111111;

            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        public void PhoneNumberMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            Int64 Number = 1111111111111111;

            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }
        public void PhoneNumberMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            Int64 Number = 1111111111;

            Error = AUser.Valid(UserName, Email, DateofBirth, PhoneNumber, isStaff);
            Assert.AreNotEqual(Error, "");
        }

    }
}



