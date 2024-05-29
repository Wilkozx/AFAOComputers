using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace ClassLibrary
{
    public class clsUserCollection
        
    {
        List<clsUser> mUserList = new List<clsUser>();
        clsUser mThisUser = new clsUser();
        public List<clsUser> UserList
        {
            get
            {
                return mUserList;
            }
            set
            {
                mUserList = value;
            }
        }
        public int Count
        {
            get
            {
                return mUserList.Count;
            }
            set
            {
                //
            }
        }
        public clsUser ThisUser
        {
            get
            {
                return mThisUser;
            }
            set
            {
                mThisUser = value;
            }
        }
        public clsUserCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblUsers_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            // populates the array list based on the data table in the parameter DB
            // variable for the index
            Int32 Index = 0;
            // variable to store record count
            Int32 RecordCount;
            // get number of records
            RecordCount = DB.Count;
            // clear the private array list
            mUserList = new List<clsUser>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank staff 
                clsUser AUser = new clsUser();
                // read in the fiels for the current record
                AUser.HashedPass = Convert.ToString(DB.DataTable.Rows[Index]["hashed_password"]);
                AUser.UserId = Convert.ToInt32(DB.DataTable.Rows[Index]["user_id"]);
                AUser.UserName = Convert.ToString(DB.DataTable.Rows[Index]["username"]);
                AUser.Email = Convert.ToString(DB.DataTable.Rows[Index]["email"]);
                AUser.isStaff = Convert.ToBoolean(DB.DataTable.Rows[Index]["isStaff"]);
                AUser.DateofBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["date_of_Birth"]);
                AUser.PhoneNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["Phone_number"]);
                // add the record to the private data member
                mUserList.Add(AUser);
                // point to next record
                Index++;
            }
        }

        public int Add()
        {
            // adds a record to the database based on the values of mThisAddress
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stores procedure
            DB.AddParameter("@UserName", mThisUser.UserName);
            DB.AddParameter("@Email", mThisUser.Email);
            DB.AddParameter("@HashedPass", mThisUser.HashedPass);
            DB.AddParameter("@isStaff", mThisUser.isStaff);
            DB.AddParameter("@Date_of_Birth", mThisUser.DateofBirth);
            DB.AddParameter("@PhoneNumber", mThisUser.PhoneNumber);

            // execute the query returning the primary key value
            return DB.Execute("sproc_tblUser_Insert");
        }

        public void Update()
        {
            // adds a record to the database based on the values of mThisAddress
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stores procedure
            DB.AddParameter("@UserId", mThisUser.UserId);
            DB.AddParameter("@UserName", mThisUser.UserName);
            DB.AddParameter("@Email", mThisUser.Email);
            DB.AddParameter("@HashedPass", mThisUser.HashedPass);
            DB.AddParameter("@isStaff", mThisUser.isStaff);
            DB.AddParameter("@Date_of_Birth", mThisUser.DateofBirth);
            DB.AddParameter("@PhoneNumber", mThisUser.PhoneNumber);

            // execute the query returning the primary key value
            DB.Execute("sproc_tblUsers_Update");
        }
    }
}