using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstProductsAccounts
    {
        [TestMethod]
        public void instanceok()
        {
            clsProductAccount AnAccount = new clsProductAccount();
            //testing 
            Assert.IsNotNull(AnAccount);
        }
        [TestMethod]
        public void AccountIdPropertyOkay() {
            //creating the instance of the class
            clsProductAccount AnAccount = new clsProductAccount();
            Int32 TestData = 1;
            //Assign the data to the property
            AnAccount.AccountId = TestData;
            Assert.AreEqual(AnAccount.AccountId, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOkay()
        {
            //creating the instance of the class
            clsProductAccount AnAccount = new clsProductAccount();
            String TestData = "Festus";
            //Assign the data to the property
            AnAccount.UserName = TestData;
            Assert.AreEqual(AnAccount.UserName, TestData);
        }
        [TestMethod]
        public void PassWordPropertyOkay()
        {
            //creating the instance of the class
            clsProductAccount AnAccount = new clsProductAccount();
            String TestData = "Holddat";
            //Assign the data to the property
            AnAccount.PassWord = TestData;
            Assert.AreEqual(AnAccount.PassWord, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOkay()
        {
            //creating the instance of the class
            clsProductAccount AnAccount = new clsProductAccount();
            String TestData = "Products Management";
            //Assign the data to the property
            AnAccount.Department = TestData;
            Assert.AreEqual(AnAccount.Department, TestData);
        }

        [TestMethod]
        public void FindAccountMethodOkay()
        {
            //creating the instance of the class
            clsProductAccount AnAccount = new clsProductAccount();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            //creating some test
            string UserName = "Festus";
            string PassWord = "Holddat";
            //invoke the method
            Found = AnAccount.FindAccount(UserName, PassWord);
            //test to see if the results is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsProductAccount AnAccount = new clsProductAccount();
            //create a boolean variable to store the results of the validation
            Boolean Found = false;
            Boolean OK = true;
            //creating some test
            string UserName = "Festus";
            string PassWord = "Holddat";
            //invoke the method
            Found = AnAccount.FindAccount(UserName, PassWord);
            //check the user id method property
            if (AnAccount.UserName !=UserName && AnAccount.PassWord != PassWord)
            {
                OK = false;
            }
            //testing to see 
            Assert.IsTrue(OK);

        }
    }
}
