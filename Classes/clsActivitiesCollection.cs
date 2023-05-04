using System;
using System.Collections.Generic;

namespace Classes
{
    public class clsActivitiesCollection
    {
        public clsActivitiesCollection()
        {
            //var for index
            Int32 Index = 0;
            //var to store record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection db = new clsDataConnection();
            //execute sproc
            db.Execute("sproc_tblActivities_SelectAll");
            //get the count of the records
            RecordCount = db.Count;
            //while there are records to process
            while (Index<RecordCount)
            {
                //create blank activity
                clsActivities AnActivity = new clsActivities();
                //read in the fields from the current record
                AnActivity.ActivityID = Convert.ToInt32(db.DataTable.Rows[Index]["ActivityID"]);
                AnActivity.ActivityName = Convert.ToString(db.DataTable.Rows[Index]["ActivityName"]);
                AnActivity.ActivityName = Convert.ToString(db.DataTable.Rows[Index]["ActivityName"]);
                AnActivity.ActivityAddress = Convert.ToString(db.DataTable.Rows[Index]["ActivityAddress"]); ;
                AnActivity.ActivityDescription = Convert.ToString(db.DataTable.Rows[Index]["ActivityDescription"]); 
                AnActivity.ActivityPostCode = Convert.ToString(db.DataTable.Rows[Index]["ActivityPostCode"]);
                AnActivity.ActivityPrice = Convert.ToDecimal(db.DataTable.Rows[Index]["ActivityPrice"]);
                //add record the private data member
                mActivitiesList.Add(AnActivity);
                //point to next record
                Index++;
            }

            ////create the item of test data
            //clsActivities TestItem = new clsActivities();
            ////set its properties
            //TestItem.ActivityID = 1;
            //TestItem.ActivityName = "Fishing";
            //TestItem.ActivityCity = "Bath";
            //TestItem.ActivityAddress = "8 Crewbridge Drive";
            //TestItem.ActivityDescription = "go kayaking with ...";
            //TestItem.ActivityPostCode = "LE6 0UE";
            //TestItem.ActivityPrice = 54.99m;
            ////add item to test list
            //mActivitiesList.Add(TestItem);
            ////re initialise the object for some new data
            //TestItem = new clsActivities();
            ////set properties
            //TestItem.ActivityID = 2;
            //TestItem.ActivityName = "Clay Pottery";
            //TestItem.ActivityCity = "London";
            //TestItem.ActivityAddress = "8 Gallowtree Drive";
            //TestItem.ActivityDescription = "Clay pottery work with ...";
            //TestItem.ActivityPostCode = "LO6 0PG";
            //TestItem.ActivityPrice = 24.99m;
            ////add item to the test list
            //mActivitiesList.Add(TestItem);

        }



        //pruvate data member for list
        List<clsActivities> mActivitiesList = new List<clsActivities>();
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

            }
        }
        public clsActivities ThisActivity { get; set; }
    }
}