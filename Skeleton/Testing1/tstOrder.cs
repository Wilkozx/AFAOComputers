using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing6
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void TestMethod1()
        {

            // Create an instance of the class clsOrder
            clsOrder AOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AOrder);
        }

        [TestMethod]
        public void OrderIdOK()
        {
            // Creates an instance of the Class clsOrder.
            clsOrder AnOrder = new clsOrder();
            // Creates some test data to assign to the Property
            String TestData = "Order Id";
            // Assign the data to the property.
            AnOrder.OrderId = TestData;
            // Test to see that the two values are the same.
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        internal class clsOrder
        {
        }
        [TestMethod]
        public void StatusOK()
        {
            // Creates an instance of the Class clsOrder.
            clsOrder AnOrder = new clsOrder();
            // Creates some test data to assign to the Property
            String TestData = "pending";
            // Assign the data to the property.
            AnOrder.Status = TestData;
            // Test to see that the two values are the same.
            Assert.AreEqual(AnOrder.Status, TestData);
        }
        [TestMethod]
        public void ShipmentDateOK()
        {
            // Creates an instance of the Class clsOrder.
            clsOrder AnOrder = new clsOrder();
            // Creates some test data to assign to the Property
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property.
            AnOrder.ShipmentDate = TestData;
            // Test to see that the two values are the same.
            Assert.AreEqual(AnOrder.ShipmentDate, TestData);
        }
        [TestMethod]
        public void CustomerIdOK()
        {
            // Creates an instance of the Class clsOrder.
            clsOrder AnOrder = new clsOrder();
            // Creates some test data to assign to the Property
            String TestData = "CustomerId";
            // Assign the data to the property.
            AnOrder.CustomerId = TestData;
            // Test to see that the two values are the same.
            Assert.AreEqual(AnOrder.CustomerId, TestData);

        }
        [TestMethod]
        public void ShipmentIDOK()
        {
            // Creates an instance of the Class clsOrder.
            clsOrder AnOrder = new clsOrder();
            // Creates some test data to assign to the Property
            String TestData = "ShipmentID";
            // Assign the data to the property.
            AnOrder.ShipmentID = TestData;
            // Test to see that the two values are the same.
            Assert.AreEqual(AnOrder.ShipmentID, TestData);
        }
        [TestMethod]
        public void QuantityOK()
        {
            // Creates an instance of the Class clsOrder.
            clsOrder AnOrder = new clsOrder();
            // Creates some test data to assign to the Property
            Int TestData = "ProductID";
            // Assign the data to the property.
            AnOrder.Quantity = TestData;
            // Test to see that the two values are the same.
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }
        [TestMethod]
        public void OrderDateOK()
        {
            // Creates an instance of the Class clsOrder.
            clsOrder AnOrder = new clsOrder();
            // Creates some test data to assign to the Property
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property.
            AnOrder.OrderDate = TestData;
            // Test to see that the two values are the same.
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderId != 1)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void StatusFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            String Status = "Pending";
            Int32 OrderID = 1;
            Found = AStaff.Find(OrderID);
            if (AnOrder.Status != Status)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ShipmentDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.ShipmentDate != Convert.ToDateTime("20/05/2024"))
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void CustomerIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            String CustomerId = "123456789";
            Int32 OrderID = 2;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.CustomerId != CustomerId)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void ShipmentIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            String ShipmentId = "CUST123456789";
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.ShipmentId != ShipmentId)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void QuantityFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 OrderID = 2;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.Quantity != "22")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void OrderDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderDate != Convert.ToDateTime("20/05/2024"))
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

