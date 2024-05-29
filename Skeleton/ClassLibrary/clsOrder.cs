using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        private String mOrderID;
        private bool mStatus;
        private DateTime mShipmentDate;
        private String mCustomerID;
        private String mShipmentID;
        private int mQuantity;
        private DateTime mOrderDate;

        public String OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }

        public bool Satus
        {
            get
            {
                return mStatus;
            }
            set
            {
                mStatus = value;
            }
        }

        public DateTime ShipmentDate
        {
            get
            {
                return mShipmentDate;
            }
            set
            {
                mShipmentDate = value;
            }
        }

        public string CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }


        public String ShipmentID
        {
            get
            {
                return mShipmentID;
            }
            set
            {
                mShipmentID = value;
            }
        }

        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        public bool Find(int OrderID)
        {
            // Create an instance of the data base connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the staff id to search for
            DB.AddParameter("@OrderID", OrderID);
            // Execute our stored procedure
            DB.Execute("sproc_tblStaff_FilterByOrderId");
            // Check if a record exists
            if (DB.Count == 1)
            {
                // Copy the data from the database to our private data members
                mOrderID = Convert.ToString(DB.DataTable.Rows[0]["Order_ID"]);
                mStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["Status"]);
                mShipmentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Shipment_Date"]);
                mCustomerID = Convert.ToString(DB.DataTable.Rows[0]["Customer_ID"]);
                mShipmentID = Convert.ToString(DB.DataTable.Rows[0]["Shipment_ID"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Order_Date"]);
                // Return that everything worked ok!
                return true;
            }
            // If no record is found then...
            else
            {
                // Return false indicating that there is a problem
                return false;
            }
        }
    }
}




