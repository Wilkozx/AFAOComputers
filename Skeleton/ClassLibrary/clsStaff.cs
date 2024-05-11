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
            mStaffId = 3;
            mFirstName = "Steven";
            mLastName = "Williams";
            mPayeeDetails = "testhash";
            mHasPerms = false;
            mJoinDate = Convert.ToDateTime("08/05/2024");
            mContractExpiry = Convert.ToDateTime("09/05/2024");
            return true;
        }
    }
}