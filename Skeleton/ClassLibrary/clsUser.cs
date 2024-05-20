using System;
using System.Data.Odbc;

namespace ClassLibrary
{
    public class clsUser
    {
        private DateTime mDateofBirth;
        private Int32 mUserId;
        private string mUserName;
        private string mEmail;
        private string mHashedPass;
        private int mPhoneNumber;
        private bool misStaff;

        public int UserId
        {
            get
            {
                return mUserId;
            }
            set
            {
                mUserId = value;
            }
        }

        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public DateTime DateofBirth
        {
            get
            {
                return mDateofBirth;
            }
            set
            {
                mDateofBirth = value;
            }
        }

        public string HashedPass
        {
            get
            {
                return mHashedPass;
            }
            set
            {
                mHashedPass = value;
            }
        }

        public int PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }

        public bool isStaff
        {
            get
            {
                return misStaff;
            }
            set
            {
                misStaff = value;
            }
        }

        public bool Find(int userId)
        {
            // Create an instance of the data base connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the staff id to search for
            DB.AddParameter("@user_Id", userId);
            // Execute our stored procedure
            DB.Execute("sproc_tblUsers_FilterByUserId");
            // Check if a record exists
            if (DB.Count == 1)
            {
                // Copy the data from the database to our private data members
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["user_id"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["username"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["email"]);
                mPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["phone_number"]);
                misStaff = Convert.ToBoolean(DB.DataTable.Rows[0]["isStaff"]);
                mDateofBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["date_of_birth"]);
                mHashedPass = Convert.ToString(DB.DataTable.Rows[0]["hashed_password"]);
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

        public string Valid(string userName, string email, string dateofBirth, int phoneNumber, bool isStaff)
        {
            String Error = "";
            if (userName.Length < 4)
            {
                Error = Error + "The Username must be greater than 4 characters";
            }
            if (userName.Length > 15)
            {
                Error = Error + "The Username must be Less than 15 characters";
            }
            if (email.Length < 5)
            {
                Error = Error + "The Email must be greater than 5 characters";
            }
            if (email.Length > 50)
            {
                Error = Error + "The Email must be Less than 50 characters";
            }
            if (phoneNumber < 6)
            {
                Error = Error + "The phonenumber must be greater than 6 characters";
            }
            if (phoneNumber > 15)
            {
                Error = Error + "The Phone number must be Less than 15 characters";
            }
            return Error;
        }
    }
}