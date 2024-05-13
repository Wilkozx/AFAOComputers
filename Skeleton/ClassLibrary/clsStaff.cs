using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffId;
        private String mFirstName;
        private String mLastName;
        private String mPayeeDetails;
        private bool mHasPerms;
        private DateTime mJoinDate;
        private DateTime mContractExpiry;

        public Int32 StaffId
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }

        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }

        public string PayeeDetails
        {
            get
            {
                return mPayeeDetails;
            }
            set
            {
                mPayeeDetails = value;
            }
        }

        public bool HasPerms
        {
            get
            {
                return mHasPerms;
            }
            set
            {
                mHasPerms = value;
            }
        }

        public DateTime JoinDate
        {
            get
            {
                return mJoinDate;
            }
            set
            {
                mJoinDate = value;
            }
        }

        public DateTime ContractExpiary
        {
            get
            {
                return mContractExpiry;
            }
            set
            {
                mContractExpiry = value;
            }
        }

        public bool Find(int staffID)
        {
            // Create an instance of the data base connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the staff id to search for
            DB.AddParameter("@StaffId", staffID);
            // Execute our stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            // Check if a record exists
            if (DB.Count == 1)
            {
                // Copy the data from the database to our private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["Staff_Id"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["Firstname"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["Lastname"]);
                mPayeeDetails = Convert.ToString(DB.DataTable.Rows[0]["PayeeDetails"]);
                mHasPerms = Convert.ToBoolean(DB.DataTable.Rows[0]["HasPerms"]);
                mJoinDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Join_Date"]);
                mContractExpiry = Convert.ToDateTime(DB.DataTable.Rows[0]["Contract_Expiry_Date"]);
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