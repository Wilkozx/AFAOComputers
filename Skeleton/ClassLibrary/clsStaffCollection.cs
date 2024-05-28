using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        // private data member for the list
        private List<clsStaff> mStaffList = new List<clsStaff>();
        // private member data for thisStaff
        clsStaff mThisStaff = new clsStaff();

        // public property for stafflist
        public List<clsStaff> StaffList
        {
            get
            {
                // return private data
                return mStaffList;
            }
            set
            {
                // set value of private data
                mStaffList = value;
            }
        }

        // public property of count
        public int Count
        {
            get
            {
                // return count of list
                return mStaffList.Count;
            }
            set
            {

            }
        }

        public clsStaff ThisStaff 
        { 
            get
            {
                // return the private data
                return mThisStaff;
            }
            set
            {
                // set the private data
                mThisStaff = value;

            }
        }

        public clsStaffCollection()
        {
            // object for the database connect
            clsDataConnection DB = new clsDataConnection();
            // execute stored procedure 
            DB.Execute("sproc_tblStaff_SelectAll");
            // populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            // adds a record to the database based on the values of mThisAddress
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the stores procedure
            DB.AddParameter("@Firstname", mThisStaff.FirstName);
            DB.AddParameter("@Lastname", mThisStaff.LastName);
            DB.AddParameter("@PayeeDetails", mThisStaff.PayeeDetails);
            DB.AddParameter("@HasPerms", mThisStaff.HasPerms);
            DB.AddParameter("@Join_Date", mThisStaff.JoinDate);
            DB.AddParameter("@Contract_Expiry_Date", mThisStaff.ContractExpiary);

            // execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            // update an existing record based on the values of thisAddress
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // set the parameters
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@Firstname", mThisStaff.FirstName);
            DB.AddParameter("@Lastname", mThisStaff.LastName);
            DB.AddParameter("@PayeeDetails", mThisStaff.PayeeDetails);
            DB.AddParameter("@HasPerms", mThisStaff.HasPerms);
            DB.AddParameter("@Join_Date", mThisStaff.JoinDate);
            DB.AddParameter("@Contract_Expiry_Date", mThisStaff.ContractExpiary);

            // execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            // deletes the record pointed to by thisStaff
            // connect to the datbase
            clsDataConnection DB = new clsDataConnection();
            // set the parameters for the procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            // execute the procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByFirstname(string Firstname)
        {
            // filteres the records based on full or partial firstname
            // connnect to the database
            clsDataConnection DB = new clsDataConnection();
            // send the firstname parameter to the database
            DB.AddParameter("@Firstname", Firstname);
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByFirstname");
            // populate the array list with the data table
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
            mStaffList = new List<clsStaff>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank staff 
                clsStaff AStaff = new clsStaff();
                // read in the fiels for the current record
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_Id"]);
                AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["Firstname"]);
                AStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["Lastname"]);
                AStaff.HasPerms = Convert.ToBoolean(DB.DataTable.Rows[Index]["hasPerms"]);
                AStaff.JoinDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Join_Date"]);
                AStaff.ContractExpiary = Convert.ToDateTime(DB.DataTable.Rows[Index]["Contract_Expiry_Date"]);
                // add the record to the private data member
                mStaffList.Add(AStaff);
                // point to next record
                Index++;
            }
        }






    }
}