using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

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

        public string Valid(String staff_Id, String firstname, String lastname, String hasPerms, String sortcode, String accountNumber, String join_Date, String contract_Expiry_Date)
        {
            // Create our error string
            String Error = "";

            // Add validation for staff_id 'because it can be modified on the frontend

            // Firstname Validation

            // If firstname blank add error cannot be blank.
            if (firstname == "")
            {
                // Append the error to our error string.
                Error = Error += "Firstname cannot be blank : ";
                Error += "Firstname cannot be blank : ";
            }

            // If firstname is longer than 50 characters add error cannot exceed 50 characters.
            if (firstname.Length > 50)
            {
                Error += "Firstname cannot exceed 50 Characters : ";
            }

            // Lastname Validation

            // If lastname blank add error cannot be blank.
            if (lastname == "")
            {
                Error += "Lastname cannot be blank : ";
            }

            // If lastname is longer than 50 characters add error cannot exceed 50 characters.
            if (lastname.Length > 50)
            {
                Error += "Firstname cannot exceed 50 Characters : ";
            }

            // Sortcode Validation

            if ((sortcode.Length == 6) || sortcode.Length == 0)
            {
                if (accountNumber.Length == 0)
                {
                    Error += "Accountnumber cannot be empty while Sortcode is filled : ";
                }
                
            } else
            {
                Error += "Sortcode is not valid : ";
            }

            // Accountnumber Validation

            if ((accountNumber.Length >= 8 && accountNumber.Length <= 10) || accountNumber.Length == 0)
            {
                if (sortcode.Length == 0)
                {
                    Error += "Sortcode cannot be empty while Account number is filled : ";
                }

            } else
            {
                Error += "Accountnumber is not valid : ";
            }

            // HasPerms Validation

            try
            {
                Convert.ToBoolean(hasPerms);
            } catch (Exception e)
            {
                Error += "HasPerms is invalid : ";
            }

            // Joindate & Expiry Validation 

            if (join_Date.Length == 0)
            {
                Error += "Join date cannot be blank : ";
            }

            if (contract_Expiry_Date.Length == 0)
            {
                Error += "Contract Expiry Date cannot be blank : ";
            }

            return Error;
        }
    }
}