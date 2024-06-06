using System;

namespace ClassLibrary
{
    public class clsUserAccount
    {
        // private data member for user id 
        private Int32 mUserID;
        // private data member for username 
        private string mUsername;
        // private dat amember for password
        private string mPassword;
        // private data member for department
        private string mDepartment;

        public int UserID
        {
            get
            {
                // return private data
                return mUserID;
            }
            set
            {
                // set private data
                mUserID = value;
            }
        }

        public string Username
        {
            get
            {
                // return private data
                return mUsername;
            }
            set
            {
                // set private data
                mUsername = value;
            }
        }

        public string Password
        {
            get
            {
                // return private data
                return mPassword;
            }
            set
            {
                // set private data
                mPassword = value;
            }
        }

        public string Department
        {
            get
            {
                // return private data
                return mDepartment;
            }
            set
            {
                // set private data
                mDepartment = value;
            }
        }

        public bool FindAccount(string username, string password)
        {
            // create an instanace of data connection
            clsDataConnection DB = new clsDataConnection();
            // add parameters for username and pass to search for
            DB.AddParameter("@Username", username);
            DB.AddParameter("@Password", password);
            // execute procedure
            DB.Execute("sproc_tblUser_FindUserNamePw");
            // if one record is found (should either be 1 or none)
            if (DB.Count == 1)
            {
                // copy the dat afrom the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["AccountID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                // return true to confirm it work
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}