using System;

namespace ClassLibrary
{
    public class clsOrderAccount
    {
        // private data member for Order id 
        private string mOrderID;
        // private data member for Status
        private bool mStatus;
        // private dat amember for Shipment Date
        private DateTime mShipmentDate;
        // private data member for Quantity
        private int mQuantity;

        public string OrderID
        {
            get
            {
                // return private data
                return mOrderID;
            }
            set
            {
                // set private data
                mOrderID = value;
            }
        }

        public bool Status
        {
            get
            {
                // return private data
                return mStatus;
            }
            set
            {
                // set private data
                mStatus = value;
            }
        }

        public DateTime ShipmentDate
        {
            get
            {
                // return private data
                return mShipmentDate;
            }
            set
            {
                // set private data
                mShipmentDate = value;
            }
        }

        public int Quantity
        {
            get
            {
                // return private data
                return mQuantity;
            }
            set
            {
                // set private data
                mQuantity = value;
            }
        }

        public clsOrderAccount()
        {
        }

        public bool FindAccount(string username, string password)
        {
            // create an instanace of data connection
            clsDataConnection DB = new clsDataConnection();
            // add parameters for username and pass to search for
            DB.AddParameter("@Username", username);
            DB.AddParameter("@Password", password);
            // execute procedure
            DB.Execute("sproc_tblOrder_FindUserNamePw");
            // if one record is found (should either be 1 or none)
            if (DB.Count == 1)
            {
                // copy the dat afrom the database to the private data members
                mOrderID = Convert.ToString(DB.DataTable.Rows[0]["OrderID"]);
                mStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["Status"]);
                mShipmentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ShipmentDate"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                // return true to confirm it work
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
