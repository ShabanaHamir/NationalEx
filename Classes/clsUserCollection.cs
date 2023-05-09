using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class clsUserCollection
    {
        //private data member for list
        List<clsUser> mUserList = new List<clsUser>();
        clsUser mThisUser = new clsUser();
        public clsUserCollection()
        {

            //object for data connection
            clsDataConnection db = new clsDataConnection();
            //execute sproc
            db.Execute("sproc_Users_SelectAll");
            //populate array
            PopulateArray(db);
        }

        public List<clsUser> UserList
        {
            get
            {
                return mUserList;
            }
            set
            {
                mUserList = value;
            }
        }
        public int Count
        {
            get
            {
                return mUserList.Count;
            }
            set
            {
                //
            }
        }
        public clsUser ThisUser
        {
            get
            {
                //get priv data
                return mThisUser;
            }
            set
            {
                //set priv data
                mThisUser = value;
            }
        }

        public int Add()
        {
            clsDataConnection db = new clsDataConnection();
            //set thee parameters for sproc
            db.AddParameter("@FirstName ", mThisUser.FirstName);
            db.AddParameter("@LastName ", mThisUser.LastName);
            db.AddParameter("@Email ", mThisUser.Email);
            db.AddParameter("@Password ", mThisUser.Password);
            db.AddParameter("@AccountType ", mThisUser.AccountType);
            db.AddParameter("@Active ", mThisUser.Active); // Add this line
            db.AddParameter("@IsAdmin", mThisUser.IsAdmin);
            //execute sproc returning the pk value
            return db.Execute("sproc_Users_Insert");
        }

        public void ReportByUserName(string FirstName)
        {
            clsDataConnection db = new clsDataConnection();
            //send postcode param to the db
            db.AddParameter("@FirstName", FirstName);
            //execute sproc
            db.Execute("sproc_Users_FilterByFirstName");
            //populate array list
            PopulateArray(db);
        }

        public void Delete()
        {
            //delete activities pointed to by ThisActivity]
            //connect to db
            clsDataConnection db = new clsDataConnection();
            //set parameter
            db.AddParameter("UserID", mThisUser.UserID);
            //execute sproc
            db.Execute("sproc_Users_Delete");
        }

        private void PopulateArray(clsDataConnection db)
        {
            //var for index 
            Int32 Index = 0;
            //var to store record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = db.Count;
            //clear the private array list
            mUserList = new List<clsUser>();
            //WHILE THERE ARE RECORDS TO PROCESS
            while (Index < RecordCount)
            {
                //create a blank staff
                clsUser AUser = new clsUser();
                //read in the fields from the cyurrent record
                AUser.UserID = Convert.ToInt32(db.DataTable.Rows[Index]["UserID"]);
                AUser.FirstName = Convert.ToString(db.DataTable.Rows[Index]["FirstName"]);
                AUser.LastName = Convert.ToString(db.DataTable.Rows[Index]["LastName"]);
                AUser.Email = Convert.ToString(db.DataTable.Rows[Index]["Email"]);
                AUser.Password = Convert.ToString(db.DataTable.Rows[Index]["Password"]);
                AUser.AccountType = Convert.ToString(db.DataTable.Rows[Index]["AccountType"]);
                AUser.Active = Convert.ToBoolean(db.DataTable.Rows[Index]["Active"]);
                AUser.IsAdmin = Convert.ToBoolean(db.DataTable.Rows[Index]["IsAdmin"]);
                //add the record to the private member
                mUserList.Add(AUser);
                //point to next record
                Index++;
            }
        }

        public void Update()
        {
            //update existing records
            clsDataConnection db = new clsDataConnection();
            //set parameters
            db.AddParameter("@UserID", mThisUser.UserID);
            db.AddParameter("@FirstName ", mThisUser.FirstName);
            db.AddParameter("@LastName ", mThisUser.LastName);
            db.AddParameter("@Email ", mThisUser.Email);
            db.AddParameter("@Password ", mThisUser.Password);
            db.AddParameter("@AccountType ", mThisUser.AccountType);
            //     db.AddParameter("@TempPW", mThisUser.TempPW);
            db.AddParameter("@Active", mThisUser.Active);
            db.AddParameter("@IsAdmin", mThisUser.IsAdmin);
            //execute sproc
            db.Execute("sproc_Users_Update");
        }


    }
}
