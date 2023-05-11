using System;
using System.Collections.Generic;
using System.Data;

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

        //public List<clsActivities> GetAllActivities()
        //{
        //    // Create a new list to store the activities
        //    List<clsActivities> activitiesList = new List<clsActivities>();

        //    // Create an instance of the data connection
        //    clsDataConnection db = new clsDataConnection();

        //    // Execute the stored procedure to get all activities
        //    db.Execute("sproc_tblActivities_SelectAll");

        //    // Loop through each row in the returned data table
        //    foreach (DataRow row in db.DataTable.Rows)
        //    {
        //        // Create a new instance of the clsActivities class
        //        clsActivities activity = new clsActivities();

        //        // Copy the data from the row to the activity object
        //        activity.ActivityID = Convert.ToInt32(row["ActivityID"]);
        //        activity.ActivityName = Convert.ToString(row["ActivityName"]);
        //        activity.ActivityCity = Convert.ToString(row["ActivityCity"]);
        //        activity.ActivityAddress = Convert.ToString(row["ActivityAddress"]);
        //        activity.ActivityPostCode = Convert.ToString(row["ActivityPostCode"]);
        //        activity.ActivityDescription = Convert.ToString(row["ActivityDescription"]);
        //        activity.NoOfPeople = Convert.ToInt32(row["NoOfPeople"]);
        //        activity.ActivityPrice = Convert.ToDecimal(row["ActivityPrice"]);

        //        // Add the activity object to the activities list
        //        activitiesList.Add(activity);
        //    }

        //    // Return the list of activities
        //    return activitiesList;


        //}

        public List<clsActivities> GetAllActivities()
        {
            // Create a new list to store the activities
            List<clsActivities> activitiesList = new List<clsActivities>();

            // Create an instance of the data connection
            clsDataConnection db = new clsDataConnection();

            try
            {
                // Execute the stored procedure to get all activities
                db.Execute("sproc_tblActivities_SelectAll");

                // Loop through each row in the returned data table
                foreach (DataRow row in db.DataTable.Rows)
                {
                    // Create a new instance of the clsActivities class
                    clsActivities activity = new clsActivities();

                    // Copy the data from the row to the activity object
                    activity.ActivityID = Convert.ToInt32(row["ActivityID"]);
                    activity.ActivityName = Convert.ToString(row["ActivityName"]);
                    activity.ActivityCity = Convert.ToString(row["ActivityCity"]);
                    activity.ActivityAddress = Convert.ToString(row["ActivityAddress"]);
                    activity.ActivityPostCode = Convert.ToString(row["ActivityPostCode"]);
                    activity.ActivityDescription = Convert.ToString(row["ActivityDescription"]);
                    activity.NoOfPeople = Convert.ToInt32(row["NoOfPeople"]);
                    activity.ActivityPrice = Convert.ToDecimal(row["ActivityPrice"]);

                    // Add the activity object to the activities list
                    activitiesList.Add(activity);
                }
            }
            catch (Exception ex)
            {
                // Log the error message (optional)
                // Return an empty list if there is an exception
                return new List<clsActivities>();
            }

            // Return the list of activities
            return activitiesList;
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

        public int Add()
        {
            clsDataConnection db = new clsDataConnection();
            //set thee parameters for sproc
            db.AddParameter("@ActivityName", mThisActivity.ActivityName);
            db.AddParameter("@ActivityCity", mThisActivity.ActivityCity);
            db.AddParameter("@ActivityAddress", mThisActivity.ActivityAddress);
            db.AddParameter("@ActivityPostCode", mThisActivity.ActivityPostCode);
            db.AddParameter("@ActivityDescription", mThisActivity.ActivityDescription);
            db.AddParameter("@NoOfPeople", mThisActivity.NoOfPeople); // Add this line
            db.AddParameter("@ActivityPrice", mThisActivity.ActivityPrice);
            //execute sproc returning the pk value
            return db.Execute("sproc_tblActivities_Insert");
        }


        //public int Add()
        //{
        //    clsDataConnection db = new clsDataConnection();
        //    //set the parameters for sproc
        //    db.AddParameter("@ActivityName", mThisActivity.ActivityName);
        //    db.AddParameter("@ActivityCity", mThisActivity.ActivityCity);
        //    db.AddParameter("@ActivityAddress", mThisActivity.ActivityAddress);
        //    db.AddParameter("@ActivityPostCode", mThisActivity.ActivityPostCode);
        //    db.AddParameter("@ActivityDescription", mThisActivity.ActivityDescription);
        //    db.AddParameter("@ActivityPrice", mThisActivity.ActivityPrice);
        //    //execute sproc
        //    DataTable dt = db.Execute("sproc_tblActivities_Insert");

        //    // If the returned DataTable has rows, extract the first row's first column value as the primary key (assuming it's an int)
        //    if (dt.Rows.Count > 0)
        //    {
        //        return Convert.ToInt32(dt.Rows[0][0]);
        //    }
        //    else
        //    {
        //        // Return an appropriate value (e.g., -1) to indicate that something went wrong
        //        return -1;
        //    }
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
            db.AddParameter("@NoOfPeople", mThisActivity.NoOfPeople);
            db.AddParameter("@ActivityPrice", mThisActivity.ActivityPrice);
            //execute sproc
            db.Execute("sproc_tblActivities_Update");
        }


        public void ReportByActivityName(string ActivityName)
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
                AnActivity.ActivityAddress = Convert.ToString(db.DataTable.Rows[Index]["ActivityAddress"]);
                AnActivity.ActivityPostCode = Convert.ToString(db.DataTable.Rows[Index]["ActivityPostCode"]);
                AnActivity.ActivityDescription = Convert.ToString(db.DataTable.Rows[Index]["ActivityDescription"]);
                AnActivity.NoOfPeople = Convert.ToInt32(db.DataTable.Rows[Index]["NoOfPeople"]);
                AnActivity.ActivityPrice = Convert.ToDecimal(db.DataTable.Rows[Index]["ActivityPrice"]);
                //add the record to the private member
                mActivitiesList.Add(AnActivity);
                //point to next record
                Index++;
            }

        }

        public void ReportByActivityCity(string ActivityCity)
        {
            clsDataConnection db = new clsDataConnection();
            //send postcode param to the db
            db.AddParameter("@ActivityCity", ActivityCity);
            //execute sproc
            db.Execute("sproc_tblActivities_FilterByActivityCity");
            //populate array list
            PopulateArray(db);
        }
    }
}