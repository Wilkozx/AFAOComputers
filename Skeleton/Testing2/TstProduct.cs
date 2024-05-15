using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Reflection;

namespace Testing2
{
    [TestClass]
    public class TstProduct
    {
        string Name = "Laptop";
        string Description = "Acer Laptop";
        string SKU = "1234";
        String Price = "200.0000";
        string Date_Added = DateTime.Now.Date.ToString();
        [TestMethod]
        public void TestMethod1()
        {
            clsProduct AProduct = new clsProduct();
            Assert.IsNotNull(AProduct);
        }

        [TestMethod]
        public void VisibityOk()
        {
            clsProduct AProduct = new clsProduct();
            Boolean TestData = true;

            AProduct.Visible = TestData;
            Assert.AreEqual(AProduct.Visible, TestData);
        }

        [TestMethod]
        public void DateaDDEDOk()
        {
            clsProduct AProduct = new clsProduct();

            DateTime TestDate = DateTime.Now.Date;
            AProduct.DateAdded = TestDate;
            Assert.AreEqual(AProduct.DateAdded, TestDate);

        }
        [TestMethod]
        public void isProductIdok()
        {
            clsProduct AProduct = new clsProduct();
            int TestData = 3;
            AProduct.ProductId = TestData;
            Assert.AreEqual(AProduct.ProductId, TestData);
        }
        [TestMethod]
        public void isDescriptionOk()
        {
            clsProduct AProduct = new clsProduct();
            string TestData = "Gaming keyboard";
            AProduct.Description = TestData;
            Assert.AreEqual(AProduct.Description, TestData);
        }
        [TestMethod]
        public void Nameok()
        {
            clsProduct AProduct = new clsProduct();
            String TestData = "KeyBoard";
            AProduct.Name = TestData;
            Assert.AreEqual(AProduct.Name, TestData);

        }
        [TestMethod]
        public void PriceOk()
        {
            clsProduct AProduct = new clsProduct();
            String TestData = "10.50";
            AProduct.Price = TestData;
            Assert.AreEqual(AProduct.Price, TestData);
        }
        [TestMethod]
        public void IsSKUOk()
        {
            clsProduct AProduct = new clsProduct();
            int TestData = 1111;
            AProduct.SKU = TestData;
            Assert.AreEqual(AProduct.SKU, TestData);

        }
        [TestMethod]
        public void FindMethodOkay()
        {
            //create the instance of the class i want
            clsProduct AProduct = new clsProduct();
            //Creating a Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 ProductId = 7;
            //invoke the method
            Found = AProduct.Find(ProductId);
            //test to see if the results is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void FindProductIdFound()
        {
            //creating an instance of the class we want to make
            clsProduct AProduct = new clsProduct();
            //Create a Boolean variable to store the results of the search
            Boolean Found = false;
            //Creating a boolean variable to record if the data is OK
            Boolean OK = true;
            //creating a test to use with the method
            Int32 ProductId = 7;
            //invokinhg the method;
            Found = AProduct.Find(ProductId);
            //check the Address id
            if (AProduct.ProductId != 7)
            {
                OK = false;
            }
            //Testing to see that the results is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 7;
            Found = AProduct.Find(ProductId);
            if (AProduct.DateAdded != Convert.ToDateTime("12/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNameFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 7;
            Found = AProduct.Find(ProductId);
            if (AProduct.Name != "Laptop")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDescriptionFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 7;
            Found = AProduct.Find(ProductId);
            if (AProduct.Description != "Acer Laptop")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean OK = true;
            Int32 ProductId = 7;
            AProduct.Find(ProductId);
            if (AProduct.Price != "200.0000")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSKUFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 7;
            Found = AProduct.Find(ProductId);
            if (AProduct.SKU != 1234)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestVisibilityFound()
        {
            clsProduct AProduct = new clsProduct();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 7;
            Found = AProduct.Find(ProductId);
            if (AProduct.Visible != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOkay()
        {
            //creating an instance of the class i want to create
            clsProduct AProduct = new clsProduct();
            //string variable to store any error messages 
            String Error = "";
            //invoke the method
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void NameNoMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            //string error to store any error messages
            string Error = "";
            //create some test data to pass the method
            string Name = "";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            //test to see that the results is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameNoMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Name = "ke";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameNoMin()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Name = "k";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameNoMaxLessOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameNoMax()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameNoMid()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Name = "aaaaaaaaaaaaa";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameNoMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameNoExtreme()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            string Name = "";
            Name = Name.PadRight(255, 'a');
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string Date_Added = TestDate.ToString();
            //invoke the method
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedExtremMax()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string Date_Added = TestDate.ToString();
            //invoke the method
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string Date_Added = TestDate.ToString();
            //invoke the method
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;

            //convert the date variable to a string variable
            string Date_Added = TestDate.ToString();
            //invoke the method
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedPlusOne()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(1);
            //convert the date variable to a string variable
            string Date_Added = TestDate.ToString();
            //invoke the method
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Date_Added = "this is invalid Date";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "a";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "aa";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMaxLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "";
            Description = Description.PadRight(2549, 'a');
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "";
            Description = Description.PadRight(2550, 'a');
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "";
            Description = Description.PadRight(2551, 'a');
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DescriptionMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Description = "";
            Description = Description.PadRight(1280, 'a');
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void SKUMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String SKU = "111";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreNotEqual(Error, "");



        }
        [TestMethod]
        public void SKUMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String SKU = "11111";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SKUMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String SKU = "111111";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SKUMaxLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String SKU = "111111111111111";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SKUMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String SKU = "1111111111111111";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SKUMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String SKU = "111111111111111111";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SKUMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String SKU = "11111111";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SKUExtremMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String SKU = "1";
            SKU = SKU.PadRight(255, '1');
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void SKUvalidData()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            // Test with SKU containing only digits
            string SKU = "1234567890123456"; // 16 digits
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]

        public void SKUInvalidData()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";
            // Test with SKU containing non-digit characters
            string SKU = "1234567890A"; // 16 digits
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreNotEqual(Error, "");// Expecting an error message
        }
        [TestMethod]

        public void PriceMinLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Price = "";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]

        public void PriceMin()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Price = "1";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");

        }
        public void PlusMinPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Price = "12";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Price = "121212121212121";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Price = "1212121212121212";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Price = "12121212121212121";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PriceMid()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Price = "12121212";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void PriceExtremMax()
        {
            clsProduct AProduct = new clsProduct();
            String Error = "";
            String Price = "1";
            Price = SKU.PadRight(255, '1');
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PriceOnlyNumbersAndDecimals()
        {
            clsProduct AProduct = new clsProduct();
            string Error = "";

            // Test with valid price containing only numbers and decimals
            string Price = "123.45";
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreEqual(Error, "");

            // Test with invalid price containing characters
            Price = "123.45A"; // Non-numeric character 'A' present
            Error = AProduct.Valid(Name, Description, SKU, Date_Added, Price);
            Assert.AreNotEqual(Error, ""); // Expecting an error message
        }
    }
}


