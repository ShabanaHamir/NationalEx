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

        public void ReportByUserName(string userNameFilter)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
