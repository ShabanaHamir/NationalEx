using System;

namespace Classes
{
    
    public class clsUser
    {
        //priv data member for the fields
        private Int32 mUserID;
        private string mFirstName;
        private string mLastName;
        private string mEmail;
        private string mPassword;
        private string mAccountType;
        private Boolean mActive;
        private Boolean mIsAdmin;
        public clsUser()
        {
        }
        public int UserID
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
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
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        public string AccountType
        {
            get
            {
                return mAccountType;
            }
            set
            {
                mAccountType = value;
            }
        }
        public string TempPW
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
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public bool IsAdmin
        {
            get
            {
                return mIsAdmin;
            }
            set
            {
                mIsAdmin = value;
            }
        }

        public bool Find(int UserID)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@UserID", UserID);
            db.Execute("sproc_Users_FilterByUserID");

            if (db.Count == 1)
            {
                //copy the data from db to private data members
                mUserID = Convert.ToInt32(db.DataTable.Rows[0]["UserID"]);
                mFirstName = Convert.ToString(db.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(db.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(db.DataTable.Rows[0]["Email"]);
                mPassword = Convert.ToString(db.DataTable.Rows[0]["Password"]);
                mAccountType = Convert.ToString(db.DataTable.Rows[0]["AccountType"]);
                mActive = Convert.ToBoolean(db.DataTable.Rows[0]["Active"]);
                mIsAdmin = Convert.ToBoolean(db.DataTable.Rows[0]["IsAdmin"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string FirstName, string LastName, string Email, string Password, string AccountType)
        {
            String Error = "";
            //if the AName is blank
            if (FirstName.Length == 0)
            {
                //record error
                Error = Error + "First name may not be blank: ";
            }
            //if AName is over max
            if (FirstName.Length > 50)
            {
                Error = Error + "First name is too long: ";
            }
            if (LastName.Length == 0)
            {
                //record error
                Error = Error + "Last name may not be blank: ";
            }
            //if AName is over max
            if (LastName.Length > 50)
            {
                Error = Error + "Last name is too long: ";
            }

            if (Email.Length == 0)
            {
                //record error
                Error = Error + "Email may not be blank: ";
            }
            //if AName is over max
            if (Email.Length > 50)
            {
                Error = Error + "Email is too long: ";
            }

            if (Password.Length == 0)
            {
                //record error
                Error = Error + "Password  may not be blank: ";
            }
            //if AName is over max
            if (Password.Length > 50)
            {
                Error = Error + "Password  is too long: ";
            }

            //if AName is over max
            if (AccountType.Length > 10)
            {
                Error = Error + "AccountType   is too long: ";
            }

            return Error;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}