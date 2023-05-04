using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class tstActivitiesColection
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
            TestItem.ActivityDescription = "go kayaking with ...";
            TestItem.ActivityPostCode = "LE6 0UE";
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
            TestActivity.ActivityDescription = "go kayaking with ...";
            TestActivity.ActivityPostCode = "LE6 0UE";
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
            TestItem.ActivityDescription = "go kayaking with ...";
            TestItem.ActivityPostCode = "LE6 0UE";
            TestItem.ActivityPrice = 54.99m;
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllActivities.ActivitiesList = TestList;
            //test tp see that the two values are the same
            Assert.AreEqual(AllActivities.ActivitiesList, TestList);
        }

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //create instance of the class
        //    clsActivitiesCollection AllActivities = new clsActivitiesCollection();
        //    //test to see that the two values are the same 
        //    Assert.AreEqual(AllActivities.Count, 2);
        //}
    }
}
