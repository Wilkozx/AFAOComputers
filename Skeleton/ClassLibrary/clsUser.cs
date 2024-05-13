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
            mUserId = 2;
            mUserName = "omar";
            mEmail = "omar@gmail.com";
            mDateofBirth = Convert.ToDateTime("23/12/2022");
            mHashedPass = "xxxxxxxxxx";
            mPhoneNumber = 12345678;
            misStaff = true;
            return true;
        }

    }
}