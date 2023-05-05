using System;
using System.Collections.Generic;

namespace Classes
{
    public class clsActivitiesCollection
    {
        //private data member for list
        List<clsActivities> mActivitiesList = new List<clsActivities>();
        //private data member for thisActivity
        clsActivities mThisActivity = new clsActivities();
        public clsActivitiesCollection()
        {

            //object for data connection
            clsDataConnection db = new clsDataConnection();
            //execute sproc
            db.Execute("sproc_tblActivities_SelectAll");
            //populate array
            PopulateArray(db);
        }

        public List<clsActivities> ActivitiesList
        {
            get
            {
                //return private data
                return mActivitiesList;
            }
            set
            {
                //set provate data
                mActivitiesList = value;
            }
        }
        

        public int Count
        {
            get
            {
                //return the count of the list
                return mActivitiesList.Count;
            }
            set
            {
                //
            }
        }
        public clsActivities ThisActivity 
        {
            get
            {
                //get priv data
                return mThisActivity;
            }
            set
            {
                //set priv data
                mThisActivity = value;
            }
        }

        //public int Add()
        //{
        //    clsDataConnection db = new clsDataConnection();
        //    //set thee parameters for sproc
        //    db.AddParameter("@ActivityName", mThisActivity.ActivityName);
        //    db.AddParameter("@ActivityCity", mThisActivity.ActivityCity);
        //    db.AddParameter("@ActivityAddress", mThisActivity.ActivityAddress);
        //    db.AddParameter("@ActivityPostCode", mThisActivity.ActivityPostCode);
        //    db.AddParameter("@ActivityDescription", mThisActivity.ActivityDescription);
        //    db.AddParameter("@ActivityPrice", mThisActivity.ActivityPrice);
        //    //execute sproc returning the pk value
        //    return db.Execute("sproc_tblActivities_Insert");
        //}

        public void Delete()
        {
            //delete activities pointed to by ThisActivity]
            //connect to db
            clsDataConnection db = new clsDataConnection();
            //set parameter
            db.AddParameter("ActivityID", mThisActivity.ActivityID);
            //execute sproc
            db.Execute("sproc_tblActivities_Delete");
        }

        public void Update()
        {
            //update exisiting records
            clsDataConnection db = new clsDataConnection();
            //set parameters
            db.AddParameter("@ActivityID", mThisActivity.ActivityID);
            db.AddParameter("@ActivityName", mThisActivity.ActivityName);
            db.AddParameter("@ActivityCity", mThisActivity.ActivityCity);
            db.AddParameter("@ActivityAddress", mThisActivity.ActivityAddress);
            db.AddParameter("@ActivityPostCode", mThisActivity.ActivityPostCode);
            db.AddParameter("@ActivityDescription", mThisActivity.ActivityDescription);
            db.AddParameter("@ActivityPrice", mThisActivity.ActivityPrice);
            //execute sproc
            db.Execute("sproc_tblActivities_Update");
        }

        public void FilterByActivitiesName(string ActivityName)
        {
            //connect to db
            clsDataConnection db = new clsDataConnection();
            //send first name parameter
            db.AddParameter("@ActivityName", ActivityName);
            //execute sproc
            db.Execute("sproc_tblActivities_FilterByActivityName");
            //populate array list
            PopulateArray(db);
        }
        void PopulateArray(clsDataConnection db)
        {
            //var for index 
            Int32 Index = 0;
            //var to store record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = db.Count;
            //clear the private array list
            mActivitiesList = new List<clsActivities>();
            //WHILE THERE ARE RECORDS TO PROCESS
            while (Index < RecordCount)
            {
                //create a blank staff
                clsActivities AnActivity = new clsActivities();
                //read in the fields from the cyurrent record
                AnActivity.ActivityID = Convert.ToInt32(db.DataTable.Rows[Index]["ActivityID"]);
                AnActivity.ActivityName = Convert.ToString(db.DataTable.Rows[Index]["ActivityName"]);
                AnActivity.ActivityCity = Convert.ToString(db.DataTable.Rows[Index]["ActivityCity"]);
                AnActivity.ActivityAddress = Convert.ToString(db.DataTable.Rows[Index]["ActivityAddress"]); ;
                AnActivity.ActivityDescription = Convert.ToString(db.DataTable.Rows[Index]["ActivityDescription"]);
                AnActivity.ActivityPostCode = Convert.ToString(db.DataTable.Rows[Index]["ActivityPostCode"]);
                AnActivity.ActivityPrice = Convert.ToDecimal(db.DataTable.Rows[Index]["ActivityPrice"]);
                //add the record to the private member
                mActivitiesList.Add(AnActivity);
                //point to next record
                Index++;
            }

        }
    }
}