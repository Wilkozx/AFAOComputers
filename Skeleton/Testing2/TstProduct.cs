using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
        string Date_Added = "12/05/2024";
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
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 7;
            Found = AProduct.Find(ProductId);
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
            Error = AProduct.Valid(Name, Description, SKU,Date_Added, Price);
            Assert.AreEqual(Error, "");
        }
    }

}
