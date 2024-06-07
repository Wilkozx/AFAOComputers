using System;
using System.CodeDom.Compiler;
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

        public Int32 UserId
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

        public bool Find(int UserId)
        {
            // Create an instance of the data base connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the staff id to search for
            DB.AddParameter("@user_Id", UserId);
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

        public string Valid(string userName, string email, string dateofBirth,string HashedPass, string PhoneNumber)
        {
            String Error = "";
            if (userName.Length < 4)
            {
                Error = Error + "The Username must be greater than 4 characters :";
            }

            if (userName.Length > 15)
            {
                Error = Error + "The Username must be Less than 15 characters :";
            }

            if (email.Length < 5)
            {
                Error = Error + "The Email must be greater than 4 characters :";
            }

            if (email.Length > 50)
            {
                Error = Error + "The Email must be Less than 50 characters :";
            }

            if(HashedPass.Length < 8) 
            {
                Error = Error + "The password must be Greater than 7 characters :";
            }

            if (HashedPass.Length > 50)
            {
                Error = Error + "The password must be less than 51 characters :";
            }
            
            if (PhoneNumber.ToString().Length < 6)
            {
                Error = Error + "The Phonenumber must be Greater than 5 characters :";
            }
            if (PhoneNumber.ToString().Length > 11)
            {
                Error = Error + "The Phonenumber must be less than 5 characters :";
            }
            DateTime TempDate = DateTime.Now.Date;
            try
            {
               
                
               DateTime dateofB = Convert.ToDateTime(dateofBirth);
                Int32 Age = TempDate.Year - dateofB.Year;
                
               
                
                if (Age < 18)
                {
                    Error = Error + "The User Must be Above 18: ";
                }
            }

            catch
            {
                //record the error
                Error = Error + "The date was not a valid date";
            }



            return Error;
        }
    }
}