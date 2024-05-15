using System;
using System.Text.RegularExpressions;

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

        public string Valid(String name, String description, String sKU, String Date_Added, String Price)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime Datetemp;

            if (name.Length == 0) {
                Error = Error + "The Name cannot be blank";
            }
            if (name.Length > 25)
            {
                Error = Error + "The Product name must be less than 25 : ";
            }
            try
            {
                //copying the dateAdded value to the DateTemp Variable
                Datetemp = Convert.ToDateTime(Date_Added);
                //i chech to see if the date is less than todays date
                if (Datetemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past: ";
                }
                if (Datetemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the Future: ";
                }
            }catch
            {
                Error = Error + "The Date was not a Valid Date : ";
            }
            if (description.Length == 0)
            {
                Error = Error + "The Description cannot be Empty: ";
            }
            if (description.Length > 2550)
            {
                Error = Error + "The Description Must be less than 2550 Characters: ";

            }
            if (string.IsNullOrEmpty(sKU))
            {
                Error = "SKU cannot be empty";
            }

            else
            {
                // Check if SKU contains only digits
                if (!Regex.IsMatch(sKU, @"^\d+$"))
                {
                    Error = "SKU must contain only digits";
                }
                else if (sKU.Length < 4)
                {
                    Error = "SKU must be at least 5 digits long";
                }
                else if (sKU.Length > 16)
                {
                    Error = "SKU must not be more than 16 digits long";
                }
            }
            if (string.IsNullOrEmpty(Price))
            {
                Error = "Price Field cannot be blank";
            }
            else
            {
                // Check if Price contains only numbers and decimals
                if (!Regex.IsMatch(Price, @"^\d+(\.\d+)?$"))
                {
                    Error = "Price must contain only numbers and decimals";
                }
                else if (Price.Length > 16)
                {
                    Error = "Price cannot be more than 16 digits";
                }
            }

            return Error;
        }
    }
}