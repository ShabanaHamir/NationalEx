﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


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
            // Use the instance to get the connection string
            string connectionString = db.GetConnectionString();
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

        public clsActivities GetActivityByID(int activityID)
        {
            clsDataConnection dataConnection = new clsDataConnection();
            // Retrieve the connection string from your clsDataConnection object
            string connectionString = dataConnection.GetConnectionString();

            // Set up the SQL command text
            string sql = "SELECT * FROM tblActivities WHERE ActivityID = @ActivityID";

            // Set up the SQL command and connection
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Add the parameter to the command
                    cmd.Parameters.AddWithValue("@ActivityID", activityID);

                    // Open the connection
                    conn.Open();

                    // Execute the command and get the results
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a new activity and populate it with the data from the reader
                            clsActivities activity = new clsActivities();
                            activity.ActivityID = (int)reader["ActivityID"];
                            activity.ActivityName = (string)reader["ActivityName"];
                            activity.ActivityPrice = (decimal)reader["ActivityPrice"];
                            // ... populate the rest of the activity fields ...

                            // Return the activity
                            return activity;
                        }
                        else
                        {
                            // If no activity was found with the provided ID, return null
                            return null;
                        }
                    }
                }
            }
        }


    }
}