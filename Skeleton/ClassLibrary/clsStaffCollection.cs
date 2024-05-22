using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        // private data member for the list
        private List<clsStaff> mStaffList = new List<clsStaff>();

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

        public clsStaff ThisStaff { get; set; }

        // variable for the index
        Int32 Index = 0;
        // variable to store the record count
        Int32 RecordCount = 0;
        // object for the database connect
        clsDataConnection DB = new clsDataConnection();
        // execute stored procedure 
        DB.Execute("sproc_tblStaff_SelectAll");
        // get the count of records 
        RecordCount = DB.Count;

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