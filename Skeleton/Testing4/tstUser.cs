﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstUser
    {
        int UserId = 1;
        string UserName = "Omar";
        string Email = "omar@gmail.com";
        string DateofBirth = DateTime.Now.AddYears(-18).ToShortDateString();
        string HashedPass = "xxxxxxxx";
        string PhoneNumber = "12345678";
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
            Int32 UserId = 3;
            Found = AUser.Find(UserId);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void UserIdFound()
        {
            clsUser AUser = new clsUser();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 UserId = 3;
            Found = AUser.Find(UserId);
            if (AUser.UserId != 3)
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
            Int32 UserId = 3;
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
            Int32 UserId = 3;
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
            Int32 UserId = 3;
            Found = AUser.Find(UserId);
            if (AUser.DateofBirth != Convert.ToDateTime("29/05/2024"))
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
            Int32 UserId = 3;
            Found = AUser.Find(UserId);
            if (AUser.HashedPass != "12345678")
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
            Int32 UserId = 3;
            Found = AUser.Find(UserId);
            if (AUser.PhoneNumber != 123456789)
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
            Int32 UserId = 3;
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
            Error = AUser.Valid(UserName, Email, DateofBirth,HashedPass,PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMinLessOne() 
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String UserName = "aaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String UserName = "aaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String UserName = "aaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String UserName = "aaaaaaaaaaaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String UserName = "aaaaaaaaaaaaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String UserName = "aaaaaaaaaaaaaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserNameMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String UserName = "aaaaaaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "aaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "aaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "aaaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "";
            Email = Email.PadRight(49, 'a');
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "";
            Email = Email.PadRight(50, 'a');
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "";
            Email = Email.PadRight(51, 'a');
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            String Email = "";
            Email = Email.PadRight(25, 'a');
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            Int64 PhoneNumber = 11111;
            string PhoneNumberString = PhoneNumber.ToString();
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumberString);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMin()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            Int64 PhoneNumber = 111111;
            string PhoneNumberString = PhoneNumber.ToString();
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumberString);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            Int64 PhoneNumber = 1111111;
            string PhoneNumberString = PhoneNumber.ToString();
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumberString);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            Int64 PhoneNumber = 1111111111;
            string PhoneNumberString = PhoneNumber.ToString();
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumberString);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMax()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            Int64 PhoneNumber = 11111111111;
            string PhoneNumberString = PhoneNumber.ToString();
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumberString);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            Int64 PhoneNumber = 111111111111;
            string PhoneNumberString = PhoneNumber.ToString();
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumberString);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PhoneNumberMid()
        {
            clsUser AUser = new clsUser();
            String Error = "";
            Int64 PhoneNumber = 11111111;
            string PhoneNumberString = PhoneNumber.ToString();
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumberString);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMinMinusOne()
        {
            clsUser AUser = new clsUser();
            string Error = "";
            string HashedPass = "aaaaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMin()
        {
            clsUser AUser = new clsUser();
            string Error = "";
            string HashedPass = "aaaaaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMinplusOne()
        {
            clsUser AUser = new clsUser();
            string Error = "";
            string HashedPass = "aaaaaaaaa";
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxMinusOne()
        {
            clsUser AUser = new clsUser();
            string Error = "";
            string HashedPass = "";
            HashedPass = HashedPass.PadRight(49, 'a');
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMax()
        {
            clsUser AUser = new clsUser();
            string Error = "";
            string HashedPass = "";
            HashedPass = HashedPass.PadRight(50, 'a');
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            clsUser AUser = new clsUser();
            string Error = "";
            string HashedPass = "";
            HashedPass = HashedPass.PadRight(51, 'a');
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PasswordMid()
        {
            clsUser AUser = new clsUser();
            string Error = "";
            string HashedPass = "";
            HashedPass = HashedPass.PadRight(30, 'a');
            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserDateMin()
        {

            clsUser AUser = new clsUser();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-18);

            string DateofBirth = TestDate.ToString();

            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserDateMinPlusOne()
        {

            clsUser AUser = new clsUser();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-17);

            string DateofBirth = TestDate.ToString();

            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UserDateMinMinusOne()
        {

            clsUser AUser = new clsUser();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-19);

            string DateofBirth = TestDate.ToString();

            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserDateMaxMinusOne()
        {

            clsUser AUser = new clsUser();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-151);

            string DateofBirth = TestDate.ToString();

            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserDateMax()
        {

            clsUser AUser = new clsUser();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-150);

            string DateofBirth = TestDate.ToString();

            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserDateMaxPlusOne()
        {

            clsUser AUser = new clsUser();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-149);

            string DateofBirth = TestDate.ToString();

            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UserDateMid()
        {

            clsUser AUser = new clsUser();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-70);

            string DateofBirth = TestDate.ToString();

            Error = AUser.Valid(UserName, Email, DateofBirth, HashedPass, PhoneNumber);

            Assert.AreEqual(Error, "");
        }
        [TestClass]
        public class tstUserCollection
        {
            [TestMethod]
            public void InstanceOK()
            {
                clsUserCollection AllUsers = new clsUserCollection();

                Assert.IsNotNull(AllUsers);
            }
            [TestMethod]
            public void UserListOK()
            {
                clsUserCollection AllUsers = new clsUserCollection();

                List<clsUser> TestList = new List<clsUser>();

                clsUser TestItem = new clsUser();

                TestItem.isStaff = true;
                TestItem.UserId = 1;
                TestItem.UserName = "omarrrrr";
                TestItem.Email = "omar@gmail.com";
                TestItem.PhoneNumber = 12345678;
                TestItem.DateofBirth = Convert.ToDateTime("01/01/2000");
                TestList.Add(TestItem);
                AllUsers.UserList = TestList;

                Assert.AreEqual(AllUsers.UserList, TestList);

            }
            
            [TestMethod]
            public void ThisUserPropertyOK() 
            {
                clsUserCollection AllUsers = new clsUserCollection();

                clsUser TestAddress = new clsUser();

                TestAddress.isStaff = true;
                TestAddress.UserId = 1;
                TestAddress.UserName = "omar";
                TestAddress.PhoneNumber = 123456789;
                TestAddress.Email = "omar@gmail.com";
                TestAddress.HashedPass = "aaaaaaaaaa";
                TestAddress.DateofBirth = Convert.ToDateTime("01/01/2000");
                AllUsers.ThisUser = TestAddress;
                Assert.AreEqual(AllUsers.ThisUser, TestAddress);
            }
            [TestMethod]
            public void ListAndCountOK()
            {
                // create an instance of the class we want to create
                clsUserCollection AllUsers = new clsUserCollection();
                // create some test data for the property
                List<clsUser> TestList = new List<clsUser>();
                // add an item to the list
                // create test item for the list
                clsUser TestItem = new clsUser();
                // set it's properties
                TestItem.UserId = 1;
                TestItem.UserName = "omar";
                TestItem.Email = "omar@gmail.com";
                TestItem.isStaff = false;
                TestItem.DateofBirth = DateTime.Now;
                TestItem.HashedPass = "Test";
                TestItem.PhoneNumber = 123456789;
                // add test item to the test list
                TestList.Add(TestItem);
                // assign data to property
                AllUsers.UserList = TestList;
                // test to see if the two values are the same
                Assert.AreEqual(AllUsers.Count, TestList.Count);
            }

            [TestMethod]
            public void AddMethodOK()
            {
                // create an instance of the class we want to create
                clsUserCollection AllUsers = new clsUserCollection();
                // create the test data for it
                clsUser TestItem = new clsUser();
                // variable to store the primary key
                Int32 PrimaryKey = 0;
                // set it's properties
                TestItem.UserName = "Test";
                TestItem.HashedPass = "Test";
                TestItem.Email = "omar@gmail.com";
                TestItem.isStaff = false;
                TestItem.DateofBirth = DateTime.Now;
                TestItem.PhoneNumber = 123456789;
                // set ThisStaff to the test data
                AllUsers.ThisUser = TestItem;
                // add the record   
                PrimaryKey = AllUsers.Add();
                // set the primary key of the test data
                TestItem.UserId = PrimaryKey;
                // find the record
                AllUsers.ThisUser.Find(PrimaryKey);
                // test to see if thw two values are the same
                Assert.AreEqual(AllUsers.ThisUser, TestItem);
            }
            [TestMethod]
             public void UpdateMethodOK()
            {
                // create an instance of the class we want to create
                clsUserCollection AllUsers = new clsUserCollection();
                // create the test data for it
                clsUser TestItem = new clsUser();
                // variable to store the primary key
                Int32 PrimaryKey = 0;
                // set it's properties
                TestItem.UserName = "Test";
                TestItem.HashedPass = "Test";
                TestItem.Email = "omar@gmail.com";
                TestItem.isStaff = false;
                TestItem.DateofBirth = DateTime.Now;
                TestItem.PhoneNumber = 123456789;
                // set ThisUser to the test data
                AllUsers.ThisUser = TestItem;
                // add the record   
                PrimaryKey = AllUsers.Add();
               
                // set the primary key of the test data
                TestItem.UserId = PrimaryKey;
                // modify test
                TestItem.UserName = "Test2";
                TestItem.HashedPass = "Test2";
                TestItem.Email = "omar2@gmail.com";
                TestItem.isStaff = true;
                TestItem.DateofBirth = DateTime.Now;
                TestItem.PhoneNumber = 12345678;
                // set thisUser to the test data
                AllUsers.ThisUser = TestItem;
                //update the record
                AllUsers.Update();
                // find the record
                AllUsers.ThisUser.Find(PrimaryKey);
                // test to see if thw two values are the same
                Assert.AreEqual(AllUsers.ThisUser, TestItem);
            }
            [TestMethod]
            public void DeleteMethodOk() 
            {
                clsUserCollection AllUsers = new clsUserCollection();
                clsUser TestItem = new clsUser();

                Int32 PrimaryKey = 0;
                TestItem.UserName = "Test";
                TestItem.HashedPass = "Test";
                TestItem.UserId = 1;
                TestItem.Email= "omar@gmail.com";
                TestItem.isStaff = false;
                TestItem.DateofBirth= DateTime.Now;
                TestItem.PhoneNumber = 12345678;
                AllUsers.ThisUser = TestItem;
                PrimaryKey = AllUsers.Add();
                TestItem.UserId = PrimaryKey;
                AllUsers.ThisUser.Find(PrimaryKey);
                AllUsers.Delete();
                Boolean Found = AllUsers.ThisUser.Find(PrimaryKey);
                Assert.IsFalse(Found);
            }
            [TestMethod]
            public void ReportByUserNameMethodOk()
            {
                clsUserCollection AllUsers = new clsUserCollection();
                clsUserCollection FilteredUserNames = new clsUserCollection();

                FilteredUserNames.ReportByUserName("");
                Assert.AreEqual(AllUsers.Count, FilteredUserNames.Count);
            }
            [TestMethod]
            public void ReportByUserNameNoneFound()
            {
                clsUserCollection FilteredUserNames = new clsUserCollection();

                FilteredUserNames.ReportByUserName("TestNotFound");

                Assert.AreEqual(0, FilteredUserNames.Count);    
            }
            public void ReportByUserNameTestDataFound()
            {
                clsUserCollection FilteredUserNames = new clsUserCollection();
                Boolean OK = true;

                FilteredUserNames.ReportByUserName("TestData2");

                if (FilteredUserNames.Count == 2)
                {
                    if (FilteredUserNames.UserList[0].UserId != 2014)
                    {
                        OK = false;
                    }
                    if (FilteredUserNames.UserList[1].UserId != 2015)
                    {
                        OK = false;
                    }
                }
                else 
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }


        }

    }
}



