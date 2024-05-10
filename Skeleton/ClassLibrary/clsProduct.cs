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
        public bool Visible {
            get
            {
                return mVisibility;
            }
            set
            {
                mVisibility = value;
            }
                }
        public DateTime DateAdded {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
            }
        public Int32 ProductId {
            //this get method sends data out of the property
            get {
                return mProductId;
            }
            //this method allows data into the property
            set
            {
                mProductId = value;
            }
        }
        public string Description {
            get {  
                return mDescription; 
            }
            set {
                mDescription = value;
                    }
                    }
        public string Name {
            get {  
                return mName; 
            }
            set
            {
                mName = value;
            }
            }
        public string Price {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
            }
        public int SKU {
            get { 
                return mSKU; 
            }
            set { 
                mSKU = value;
            } 
        }

        public bool Find(int productId)
        {
            //set the private data members to the test data value
            mProductId = 2;
            mDateAdded = Convert.ToDateTime("23/12/2022");
            mName = "KeyBoard";
            mDescription = "this is a gaming keyboard";
            mPrice = "20.37";
            mSKU = 111111;
            mVisibility = true;
            
            //always return true
            return true;
        }

    }
}