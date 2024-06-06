using System;
using System.Collections.Generic;
using System.Xml.Linq;


namespace ClassLibrary


{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data for collection
        clsOrder mThisOrder = new clsOrder();
       

        public List<clsOrder> OrderList
        {

            get
            {
                return mOrderList;
            }
            set { mOrderList = value; }
        }
        public int Count
        {
            get { return mOrderList.Count; }
            set
            {
            }
        }
        public clsOrder ThisProduct
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //EXECUTE 
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);



        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.AddParameter("@ShipmentDate", mThisOrder.ShipmentDate);
            DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);
            DB.AddParameter("@ShipmentID", mThisOrder.ShipmentID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblProducts_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@Status", mThisOrder.Status);
            DB.AddParameter("@ShipmentDate", mThisOrder.ShipmentDate);
            DB.AddParameter("@PaymentMethod", mThisOrder.PaymentMethod);
            DB.AddParameter("@ShipmentID", mThisOrder.ShipmentID);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);

            //execute the query returning the primary key value
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //execute the store procedure 
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByCustomerID(string CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            //executing the stored procedure 
            DB.Execute("sproc_tblOrder_FilterByCustomerID");
            //Populate the array list with the data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //getting the count of the record 
            RecordCount = DB.Count;
            //clearing the private array list
            mOrderList = new List<clsOrder>();
            //while there are no records to process
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                //creating the blank products current record
                AnOrder.OrderID = Convert.ToString(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.Status = Convert.ToBoolean(DB.DataTable.Rows[Index]["Status"]);
                AnOrder.ShipmentDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Shipment_Date"]);
                AnOrder.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);
                AnOrder.ShipmentID = Convert.ToString(DB.DataTable.Rows[Index]["ShipmentID"]);
                AnOrder.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Order_Date"]);
                mOrderList.Add(AnOrder);
                //point at the next record 
                Index++;

            }
        }
    }

}
