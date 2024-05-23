using System;
using System.Collections.Generic;
using System.Xml.Linq;


namespace ClassLibrary


{
    public class clsProductCollection
    {
        List<clsProduct> mProductList = new List<clsProduct>();
        //private data for collection
        clsProduct mThisProduct = new clsProduct();
        public List<clsProduct> ProductList
        {
           
            get { return mProductList;
            }
            set { mProductList = value;  }
        }
        public int Count {
            get { return mProductList.Count;}
            set { 
            }
                }
        public clsProduct ThisProduct {
            get
            {
                return mThisProduct;
            }
            set { mThisProduct =value;
            }
            }

        public clsProductCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //EXECUTE 
            DB.Execute("sproc_tblProducts_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);



        }

        public int Add()
        {
          clsDataConnection DB =new clsDataConnection();
            DB.AddParameter("@SKU", mThisProduct.SKU);
            DB.AddParameter("@Name", mThisProduct.Name);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@Date_Added", mThisProduct.DateAdded);
            DB.AddParameter("@Description", mThisProduct.Description);
            DB.AddParameter("@IsVisible", mThisProduct.Visible);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblProducts_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", mThisProduct.ProductId);
            DB.AddParameter("@SKU", mThisProduct.SKU);
            DB.AddParameter("@Name", mThisProduct.Name);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@Date_Added", mThisProduct.DateAdded);
            DB.AddParameter("@Description", mThisProduct.Description);
            DB.AddParameter("@IsVisible", mThisProduct.Visible);

            //execute the query returning the primary key value
            DB.Execute("sproc_tblProducts_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductId", mThisProduct.ProductId);
            //execute the store procedure 
            DB.Execute("sproc_tblProducts_Delete");
        }

        public void ReportByName(string Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", Name);
            //executing the stored procedure 
            DB.Execute("sproc_tblProducts_FilterByName");
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
            mProductList = new List<clsProduct>();
            //while there are no records to process
            while(Index < RecordCount){
               clsProduct AProduct = new clsProduct();
                //creating the blank products current record
                AProduct.ProductId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                AProduct.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AProduct.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                AProduct.SKU = Convert.ToInt32(DB.DataTable.Rows[Index]["SKU"]);
                AProduct.Price = Convert.ToString(DB.DataTable.Rows[Index]["Price"]);
                AProduct.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date_Added"]);
                AProduct.Visible = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsVisible"]);
                mProductList.Add(AProduct);
                //point at the next record 
                Index++;    

            }
        }
    }

}