using System;

namespace ClassLibrary
{
    public class clsProduct

    {
        //private data for the address id Property;
        private Int32 mProductId;
        private DateTime mDateAdded;
        private string mName;
        private string mDescription;
        private string mPrice;
        private Int32 mSKU;
        private Boolean mVisibility;
        public bool Visible
        {
            get
            {
                return mVisibility;
            }
            set
            {
                mVisibility = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public Int32 ProductId
        {
            //this get method sends data out of the property
            get
            {
                return mProductId;
            }
            //this method allows data into the property
            set
            {
                mProductId = value;
            }
        }
        public string Description
        {
            get
            {
                return mDescription;
            }
            set
            {
                mDescription = value;
            }
        }
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public string Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public int SKU
        {
            get
            {
                return mSKU;
            }
            set
            {
                mSKU = value;
            }
        }

        //*******Find Method***********//
        public bool Find(int ProductId)
        {
            //Create an instance of the dataConnection
            clsDataConnection DB = new clsDataConnection();
            //adding the parameter for the Product ID to search for
            DB.AddParameter("@ProductId", ProductId);
            //Executing the store procedure
            DB.Execute("sproc_tblProducts_filterbyProductId");
            //if one record is found there will be either one or zero;
            if (DB.Count == 1)
            {
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mSKU = Convert.ToInt32(DB.DataTable.Rows[0]["SKU"]);
                mPrice = Convert.ToString(DB.DataTable.Rows[0]["Price"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["Date_Added"]);
                mVisibility = Convert.ToBoolean(DB.DataTable.Rows[0]["IsVisible"]);
                //Returning that everything is Working
                return true;
            }
            else
            {
                //showing that there is a problem
                return false;
            }
        }

    }
}