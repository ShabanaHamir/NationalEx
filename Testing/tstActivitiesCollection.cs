using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class tstActivitiesCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsActivitiesCollection AllActivities = new clsActivitiesCollection();
            //test to see that it exists
            Assert.IsNotNull(AllActivities);
        }

        [TestMethod]
        public void ActivitiesListOK()
        {
            //create an instance of the class
            clsActivitiesCollection AllActivities = new clsActivitiesCollection();
            //create test data
            List<clsActivities> TestList = new List<clsActivities>();
            //add an item to the list
            clsActivities TestItem = new clsActivities();
            //set its properties
            TestItem.ActivityID = 1;
            TestItem.ActivityName = "Kayaking";
            TestItem.ActivityCity = "London";
            TestItem.ActivityAddress = "8 Crewbridge Drive";
            TestItem.ActivityPostCode = "LE6 0UE";
            TestItem.ActivityDescription = "go kayaking with ...";
            TestItem.NoOfPeople = 2;
            TestItem.ActivityPrice = 54.99m;
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllActivities.ActivitiesList = TestList;
            //test tp see that the two values are the same
            Assert.AreEqual(AllActivities.ActivitiesList, TestList);
            //
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    clsActivitiesCollection AllActivities = new clsActivitiesCollection();
        //    //create some test data to assign to the property
        //    Int32 SomeCount = 2;
        //    //assign data to the property
        //    AllActivities.Count = SomeCount;
        //    //test to see tjay yje two values are the same
        //    Assert.AreEqual(AllActivities.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisActivityPropertyOK()
        {
            //create an instance of the class we want to create
            clsActivitiesCollection AllActivities = new clsActivitiesCollection();
            //create test data to assign to the property
            clsActivities TestActivity = new clsActivities();
            //set properties of test object
            TestActivity.ActivityID = 1;
            TestActivity.ActivityName = "Kayaking";
            TestActivity.ActivityCity = "London";
            TestActivity.ActivityAddress = "8 Crewbridge Drive";
            TestActivity.ActivityPostCode = "LE6 0UE";
            TestActivity.ActivityDescription = "go kayaking with ...";
            TestActivity.NoOfPeople = 2;
            TestActivity.ActivityPrice = 54.99m;
            //assign the data to the property
            AllActivities.ThisActivity = TestActivity;
            //test to see that the two values are the same
            Assert.AreEqual(AllActivities.ThisActivity, TestActivity);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsActivitiesCollection AllActivities = new clsActivitiesCollection();
            //create test data
            List<clsActivities> TestList = new List<clsActivities>();
            //add an item to the list
            clsActivities TestItem = new clsActivities();
            //set its properties
            TestItem.ActivityID = 1;
            TestItem.ActivityName = "Kayaking";
            TestItem.ActivityCity = "London";
            TestItem.ActivityAddress = "8 Crewbridge Drive";
            TestItem.ActivityPostCode = "LE6 0UE";
            TestItem.ActivityDescription = "go kayaking with ...";
            TestItem.NoOfPeople = 2;
            TestItem.ActivityPrice = 54.99m;
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllActivities.ActivitiesList = TestList;
            //test tp see that the two values are the same
            Assert.AreEqual(AllActivities.ActivitiesList, TestList);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of the class
            clsActivitiesCollection AllActivities = new clsActivitiesCollection();
            //create item of test data
            clsActivities TestItem = new clsActivities();
            //var to store pk
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ActivityID = 1;
            TestItem.ActivityName = "Kayaking";
            TestItem.ActivityCity = "London";
            TestItem.ActivityAddress = "8 Crewbridge Drive";
            TestItem.ActivityPostCode = "LE6 0UE";
            TestItem.ActivityDescription = "go kayaking with ...";
            TestItem.NoOfPeople = 2;
            TestItem.ActivityPrice = 54.99m;
            //set ThisActivity to test data
            AllActivities.ThisActivity = TestItem;
            //add record
            PrimaryKey = AllActivities.Add();
            //set pk of test data
            TestItem.ActivityID = PrimaryKey;
            //find record
            AllActivities.ThisActivity.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllActivities.ThisActivity, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsActivitiesCollection AllActivities = new clsActivitiesCollection();
            //create item of test data
            clsActivities TestItem = new clsActivities();
            //var to store pk
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ActivityID = 1;
            TestItem.ActivityName = "Kayaking";
            TestItem.ActivityCity = "London";
            TestItem.ActivityAddress = "8 Crewbridge Drive";
            TestItem.ActivityPostCode = "LE6 0UE";
            TestItem.ActivityDescription = "go kayaking with ...";
            TestItem.NoOfPeople = 2;
            TestItem.ActivityPrice = 54.99m;
            //set ThisActivity to test data
            AllActivities.ThisActivity = TestItem;
            //add record
            PrimaryKey = AllActivities.Add();
            //find record
            AllActivities.ThisActivity.Find(PrimaryKey);
            //de;ete
            AllActivities.Delete();
            //find the record
            Boolean Found = AllActivities.ThisActivity.Find(PrimaryKey);
            //test to see that the record wasnt found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsActivitiesCollection AllActivities = new clsActivitiesCollection();
            //create item of test data
            clsActivities TestItem = new clsActivities();
            //var to store pk
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ActivityID = 1;
            TestItem.ActivityName = "Kayaking";
            TestItem.ActivityCity = "London";
            TestItem.ActivityAddress = "8 Crewbridge Drive";
            TestItem.ActivityPostCode = "LE6 0UE";
            TestItem.ActivityDescription = "go kayaking with ...";
            TestItem.NoOfPeople = 2;
            TestItem.ActivityPrice = 54.99m;
            //set ThisActivity to test data
            AllActivities.ThisActivity = TestItem;
            //add record
            PrimaryKey = AllActivities.Add();
            //set the pk of the testdata
            TestItem.ActivityID = PrimaryKey;
            //modify test data
            TestItem.ActivityName = "Kayaking Yay";
            TestItem.ActivityCity = "Luton";
            TestItem.ActivityAddress = "8 Crewbridge Road";
            TestItem.ActivityDescription = "go kayaking with your friends ...";
            TestItem.ActivityPostCode = "LU6 0UE";
            TestItem.NoOfPeople = 5;
            TestItem.ActivityPrice = 53.99m;
            //set record based on new test data
            AllActivities.ThisActivity = TestItem;
            //update record
            AllActivities.Update();
            //find record
            AllActivities.ThisActivity.Find(PrimaryKey);
            //test to see that this activity matches the test data
            Assert.AreEqual(AllActivities.ThisActivity, TestItem);
        }

        [TestMethod]
        public void ReportByActivityCityMethodOK()
        {
            //create an instance of the class we want to create
            clsActivitiesCollection AllActivities = new clsActivitiesCollection();
            //create an instance of filtered data
            clsActivitiesCollection FilteredActivity = new clsActivitiesCollection();
            //apply blank string (should return all records)
            FilteredActivity.ReportByActivityCity("");
            //test to see that 2 values are the same
            Assert.AreEqual(AllActivities.Count, FilteredActivity.Count);

        }

        [TestMethod]
        public void ReportByActivityCityNoneFound()
        {
            //create an instance of the class we want to create
            clsActivitiesCollection FilteredActivity = new clsActivitiesCollection();
            //apply blank string that doesnt exist
            FilteredActivity.ReportByActivityCity("xxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredActivity.Count);
        }

        [TestMethod]
        public void ReportByActivityCityTestDataFound()
        {
            //create an instance of the class we want to create
            clsActivitiesCollection FilteredActivity = new clsActivitiesCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a city that doesnt exist
            FilteredActivity.ReportByActivityCity("Bath");
            //check that the correct number of records found
            if (FilteredActivity.Count == 2)
            {
                if (FilteredActivity.ActivitiesList[0].ActivityID != 3)
                {
                    OK = false;
                }
                if (FilteredActivity.ActivitiesList[1].ActivityID != 18)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see there are no records
            Assert.IsTrue(OK);
        }
    }
}
