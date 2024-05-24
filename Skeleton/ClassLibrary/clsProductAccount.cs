using System;

namespace ClassLibrary
{
    public class clsProductAccount
    {
        private Int32 mAccountId;
        private String mUserName;
        private String mPassWord;
        private String mDepartment;
        
        public int AccountId {
            get
            {
                return mAccountId;
            }
            set { mAccountId = value; }
        }
        public string UserName {
            get { return mUserName; }
            set
            {
                mUserName = value;
            }
        }
        public string PassWord {
            get
            {
                return mPassWord;
            }
            set { mPassWord = value;
            }
        }
        public string Department {
            get
            {
                return mDepartment;
            }
                set{
                    mDepartment = value;
                }
            }

        public bool FindAccount(string UserName, string PassWord)
        {
           
            //creating an instance of the data connection
        clsDataConnection DB = new clsDataConnection();
            //adding the parameters 
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@PassWord", PassWord);
            //EXECUTING
            DB.Execute("sproc_tblAccounts_FindUserNamePw");
            //IF one record is found(there should be either one or none)
            if (DB.Count == 1 ) {
                mAccountId = Convert.ToInt32(DB.DataTable.Rows[0]["AccountId"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassWord = Convert.ToString(DB.DataTable.Rows[0]["PassWord"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}