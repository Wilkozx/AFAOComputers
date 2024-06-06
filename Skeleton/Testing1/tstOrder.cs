using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace Testing6
{
    [TestClass]
    public class tstOrder
    {
        String Order_ID = "1234";
        String Status = "Pending";
        String ShipmentDate = "24/05/2024";
        String PaymentMethod = "ApplePay";
        String ShipmentID = "123456";
        String Quantity = "11";
        String OrderDate = DateTime.Now.ToString();
     
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
            internal int OrderID;

            public string OrderId { get; internal set; }
            public string Status { get; internal set; }
            public string Quantity { get; internal set; }
            public DateTime OrderDate { get; internal set; }
            public string ShipmentId { get; internal set; }
            public string ShipmentID { get; internal set; }
            public string CustomerId { get; internal set; }
            public DateTime ShipmentDate { get; internal set; }
            public string PaymentMethod { get; internal set; }

            internal bool Find(int orderID)
            {
                throw new NotImplementedException();
            }
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
        public void PaymentMethodOK()
        {
            // Creates an instance of the Class clsOrder.
            clsOrder AnOrder = new clsOrder();
            // Creates some test data to assign to the Property
            String TestData = "PaymentMethod";
            // Assign the data to the property.
            AnOrder.PaymentMethod = TestData;
            // Test to see that the two values are the same.
            Assert.AreEqual(AnOrder.PaymentMethod, TestData);

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
            string TestData = "9";
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
            if (AnOrder.OrderID != 1)
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
            Found = AnOrder.Find(OrderID);
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
        public void PaymentMethodFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            String PaymentMethod = "ApplyPay";
            Int32 OrderID = 2;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.PaymentMethod != PaymentMethod)
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
    }


[TestMethod]

public void ValidMethodOK(string OrderID, object Status, object PaymentMethod, object Quantity)
{
    //creating an instance of the class i want to create
    clsOrder AOrder = new clsOrder();
    // Create variable to store error message
    String Error = "";
    // Invoke the method
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void OrderIDNoMinLessOne(object Status, object PaymentMethod, object Quantity)
{
    clsOrder AProduct = new clsOrder();
    //string error to store any error messages
    string Error = "";
    //create some test data to pass the method
    string OrderID = "";
    object AOrder = null;
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    //test to see that the results is correct
    Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void OrderIDNoMinPlusOne(object Status, object PaymentMethod, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    string Error = "";
    string OrderID = "aa";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");
}
[TestMethod]

public void OrderIDNoMin(object Status, object PaymentMethod, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    string Error = "";
    string OrderID = "aa";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");
}
[TestMethod]

public void OrderIDNoMaxLessOne(object Status, object PaymentMethod, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    string Error = "";
    string OrderID = "aaaaaaaaaaa";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");
}
[TestMethod]

public void OrderIDNoMax(object Status, object PaymentMethod, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    string Error = "";
    string OrderID = "aaaaaaaaaaa";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");
}
[TestMethod]

public void OrderIDNoMid(object Status, object PaymentMethod, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    string Error = "";
    string OrderID = "aaaaaaaaaaaaa";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");
}
[TestMethod]

public void OrderIDNoMaxPlusOne(object Status, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    string Error = "";
    string OrderID = "aaaaaaaaaaaaaaaaaaa";
        object PaymentMethod = null;
        Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreNotEqual(Error, "");
}
[TestMethod]

public void OrderIDNoExtreme(object Status, object PaymentMethod, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    string Error = "";
    string OrderID = "";
    OrderID = OrderID.PadRight(250, 'a');
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreNotEqual(Error, "");
}
[TestMethod]

public void StatusMinLessOne(string OrderID, object PaymentMethod, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String Status = "aaaa";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void StatusMin(string OrderID, object PaymentMethod, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String Status = "aaaa";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");
}
[TestMethod]

public void StatusMinPlusOne(string OrderID, object PaymentMethod, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String Status = "aaaaaa";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");
}
[TestMethod]

public void StatusMaxLessOne(string OrderID, object PaymentMethod, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String Status = "aaaa";
    Status = Status.PadRight(50, 'a');
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");
}
[TestMethod]

public void StatusMax(string OrderID, object PaymentMethod, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String Status = "aaaa";
    Status = Status.PadRight(51, 'a');
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity)
    Assert.AreEqual(Error, "");
}
[TestMethod]

public void StatusMaxPlusOne(string OrderID, object PaymentMethod, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String Status = "aaaa";
    Status = Status.PadRight(52, 'a');
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreNotEqual(Error, "");

}
[TestMethod]
public void StatusMid(object OrderID, object PaymentMethod, object Quantity, object AOrder)
{
    clsOrder AUser = new clsOrder();
    String Error = "";
    String Status = "aaaa";
    Status = Status.PadRight(20, 'a');
    Error = AOrder.Valid(OrderID, Status,PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void PaymentMethodLessOne(string OrderID, object Status, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String PaymentMethod = "1111";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreNotEqual(Error, "");



}
[TestMethod]

public void PaymentMethodMin(string OrderID, object Status, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String PaymentMethod = "11111";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");

}
[TestMethod]
public void PaymentMethodMinPlusOne(string OrderID, object Status, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String PaymentMethod = "111111";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");

}
[TestMethod]
public void PaymentMethodMaxLessOne(string OrderID, object Status, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String PaymentMethod = "1111111111111111";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");

}
[TestMethod]
public void PaymentMethodMax(string OrderID, object Status, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String PaymentMethod = "1111111111111111";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");

}
[TestMethod]
public void PaymentMethodMaxPlusOne(string OrderID, object Status, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String PaymentMethod = "111111111111111111";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreNotEqual(Error, "");

}
[TestMethod]
public void PaymentMethodMid(string OrderID, object Status, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String PaymentMethod = "11111111";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");

}
[TestMethod]
public void PaymentMethodExtremMax(string OrderID, object Status, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String PaymentMethod = "11111111111111";
    PaymentMethod = PaymentMethod.PadRight(255, '1');
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreNotEqual(Error, "");

}
public void PaymentMethodValidData(string OrderID, object Status, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    string PaymentMethod = "card";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]

public void PaymentMethodInvalidData(string OrderID, object Status, object Quantity)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String PaymentMethod = "card";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]

public void QuantityMinLessOne(string OrderID, object Status, object PaymentMethod)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String Quantity = "";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreNotEqual(Error, "");

}
[TestMethod]
public void QuantityMin(string OrderID, object Status, object PaymentMethod)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String Quantity = "1";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");

}
[TestMethod]
public void PlusMinPlusOne(string OrderID, object Status, object PaymentMethod)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String Quantity = "15";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");

}
[TestMethod]

public void QuantityMaxLessOne(string OrderID, object Status, object PaymentMethod)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String Quantity = "1000";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");

}
[TestMethod]

public void QuantityMax(string OrderID, object Status, object PaymentMethod)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String Quantity = "1000";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");

}
[TestMethod]
public void QuantityMaxPlusOne(string OrderID, object Status, object PaymentMethod)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String Quantity = "1000";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreNotEqual(Error, "");

}
[TestMethod]
public void QuantityMid(string OrderID, object Status, object PaymentMethod)
{
    clsOrder AOrder = new clsOrder();
    String Error = "";
    String Quantity = "500";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");

}
[TestMethod]

public void QuantityExtremMax(object OrderID, object Status, object PaymentMethod)
{
    clsOrder APOrder = new clsOrder();
    String Error = "";
    String Quantity = "1000";
    Quantity = Status.PadRight(255, '1');
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreNotEqual(Error, "");

}
[TestMethod]

public void QuantityOnlyNumbers(string OrderID, object Status, object PaymentMethod)
{
    clsOrder AOrder = new clsOrder();
    string Error = "";

    // Test with valid quantity containing only numbers 
    string Quantity = "11";
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreEqual(Error, "");

    // Test with invalid quantity containing characters
    Quantity = "1A"; // Non-numeric character 'A' present
    Error = AOrder.Valid(OrderID, Status, PaymentMethod, Quantity);
    Assert.AreNotEqual(Error, ""); // Expecting an error message
}
    }

 [TestClass]
public class tstOrderCollection
{
    private clsOrder clsOrderTestItem;
    private object TestItem;

    [TestMethod]
    public void instanceokay()
    {
        clsOrderCollection AllOrder = new clsOrderCollection();
        //testing to see that it exists:
        Assert.IsNotNull(AllOrder);
    }
    [TestMethod]
    public void OrderListOk()
    {
        //lets create an instance of the class we want to create
        clsOrderCollection AllOrder = new clsOrderCollection();
        //create some test data to assign to the property
        //in this case the data will be list of Order
        List<clsOrder> TestList = new List<clsOrder>();
        //add an Item to the list
        //create the item of test data
        clsOrder TestItem = new clsOrder();
        //setting its properties
        TestItem.Visible = true;
        TestItem.OrderID = 1234;
        TestItem.Status = "Pending";
        TestItem.ShipmentDate = "24/05/2024";
        TestItem.OrderDate = DateTime.Now;
        TestItem.ShipmentID = 123456;
        TestItem.Quantity = "11";
        //Add the item to the test list
        TestList.Add(TestItem);
        //assign the data to the property
        AllOrder.OrderList = TestList;
        //test to see that the two values are the same
        Assert.AreEqual(AllOrder.OrderList, TestList);
    }

    [TestMethod]
    public void ThisOrderPropertyOkay()
    {
        clsOrderCollection AllOrder = new clsOrderCollection();
        clsOrder TestOrder = new clsOrder();
        //set the properties of the test object
        TestOrder.Visible = true;
        TestOrder.OrderID = 1234;
        TestOrder.Status = "Pending";
        TestOrder.ShipmentDate = "24/05/2024";
        TestOrder.OrderDate = DateTime.Now;
        TestOrder.ShipmentID = 123456;
        TestOrder.Quantity = "11";

        //assign the data to the property
        AllOrder.ThisOrder = TestOrder;
        //testing
        Assert.AreEqual(AllOrder.ThisOrder, TestOrder);

    }
    [TestMethod]
    public void ListAndCountOkay()
    {
        clsOrderCollection AllOrder = new clsOrderCollection();
        List<clsOrder> TestList = new List<clsOrder>();
        clsOrder TestItem = new clsOrder();
        TestItem.Visible = true;
        TestItem.OrderID = 1234;
        TestItem.Status = "Pending";
        TestItem.ShipmentDate = "24/05/2024";
        TestItem.OrderDate = DateTime.Now;
        TestItem.ShipmentID = 123456;
        TestItem.Quantity = "11";
        //Add the item to the test list
        TestList.Add(TestItem);
        //assign the data to the property
        AllOrder.OrderList = TestList;
        //test to see that the two values are the same
        Assert.AreEqual(AllOrder.Count, TestList.Count);
    }
    [TestMethod]
    public void AddOrderMethodOk()
    {
        clsOrderCollection AllOrder = new clsOrderCollection();
        //creating the item of test
        clsOrder TestItem = new clsOrder();
        Int32 PrimaryKey = 0;
        //set the properties 
        TestItem.Visible = true;
        TestItem.OrderId = 1234;
        TestItem.Status = "Pending";
        TestItem.ShipmentDate = "24/05/2024";
        TestItem.OrderDate = DateTime.Now;
        TestItem.ShipmentID = 123456;
        TestItem.Quantity = "11";
        //set thisProduct to the test data
        AllOrder.ThisOrder = TestItem;
        //add the record
        PrimaryKey = AllOrder.Add();
        TestItem.OrderId = PrimaryKey;
        AllOrder.ThisOrder.Find(PrimaryKey);

        Assert.AreEqual(AllOrder.ThisOrder, TestItem);

    }
    [TestMethod]
    public void UpdateMethodOkay()
    {
        clsOrderCollection AllOrder = new clsOrderCollection();
        clsOrderTestItem = new clsOrder();
        Int32 PrimaryKey = 0;
        TestItem.Visible = true;
        TestItem.OrderId = 1234;
        TestItem.Status = "Pending";
        TestItem.ShipmentDate = "24/05/2024";
        TestItem.OrderDate = DateTime.Now;
        TestItem.ShipmentID = 123456;
        TestItem.Quantity = "11";
        //setting thisOrder to the test
        AllOrder.ThisOrder = (clsOrder)TestItem;
        //Add the record
        PrimaryKey = AllOrder.Add();
        TestItem.OrderId = PrimaryKey;
        //modify the test record
        TestItem.Visible = true;
        TestItem.OrderId = 1234;
        TestItem.Status = "Pending";
        TestItem.ShipmentDate = "24/05/2024";
        TestItem.OrderDate = DateTime.Now;
        TestItem.ShipmentID = 123456;
        TestItem.Quantity = "11";
        //set the record
        AllOrder.ThisOrder = (clsOrder)TestItem;
        //updating the record
        AllOrder.Update();
        Assert.AreEqual(AllOrder.ThisOrder, TestItem);
    }
    [TestMethod]
    public void DeleteMethodOkay()
    {
        clsOrderCollection AllOrder = new clsOrderCollection();
        //create the item of test data
        clsOrder TestItem = new clsOrder();
        //variable to store the primary key
        Int32 PrimaryKey = 0;
        //set its properties 
        TestItem.Visible = true;
        TestItem.OrderId = 1234;
        TestItem.Status = "Pending";
        TestItem.ShipmentDate = "24/05/2024";
        TestItem.OrderDate = DateTime.Now;
        TestItem.ShipmentID = 123456;
        TestItem.Quantity = "11";
        //set thisProduct to the test data
        AllOrder.ThisOrder = TestItem;
        //add the record
        PrimaryKey = AllOrder.Add();
        //set the primary key of the test data
        TestItem.OrderId = PrimaryKey;
        //fine the record
        AllOrder.ThisOrder.Find(PrimaryKey);
        //delete the record
        AllOrder.Delete();
        //now find the record 
        Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
        //test to see if the record exist
        Assert.IsFalse(Found);

    }
    [TestMethod]
    public void ReportByOrderIDMethodOkay()
    {
        //creating the instanse of the class
        clsOrderCollection AllOrder = new clsOrderCollection();
        //creating an instance of the filtered data
        clsOrderCollection filteredOrders = new clsOrderCollection();
        //apply a blank string (should return all record)
        filteredOrders.ReportByOrderID("");
        //testing
        Assert.AreEqual(AllOrder.Count, filteredOrders.Count);
    }
    [TestMethod]
    public void ReportByOrderIDNoneFound()
    {
        clsOrderCollection FilteredOrders = new clsOrderCollection();
        FilteredOrders.ReportByOrderID("XXXXXX");
        Assert.AreEqual(0, FilteredOrders.Count);
    }

    [TestMethod]

    public void ReportByOrderIDTestDataFound()
    {
        clsOrderCollection filterOrders = new clsOrderCollection();
        //variable to store the outcome
        Boolean OK = true;
        //apply a name that doestnt exist
        filterOrders.ReportByOrderID("1234");
        //check that the correct number of record are found
        if (filterOrders.Count == 3)
        {
            if (filterOrders.OrderList[0].OrderId != 51)
            {
                OK = false;
            }
            if (filterOrders.OrderList[0].OrderId != 49)
            {
                OK = false;
            }
            if (filterOrders.OrderList[0].OrderId != 48)
            {
                OK = false;
            }
            else { OK = false; }
        }
        //test to see that there are no records
        Assert.IsTrue(OK);
    }

}
}
internal class clsOrderCollection
{
    internal List<clsOrder> OrderList;
    internal clsOrder ThisOrder;
    internal int Count;

    internal int Add()
    {
        throw new NotImplementedException();
    }

    internal void Delete()
    {
        throw new NotImplementedException();
    }

    internal void ReportByOrderID(string v)
    {
        throw new NotImplementedException();
    }

    internal void Update()
    {
        throw new NotImplementedException();
    }
}