using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing
{
    [TestClass]
    public class tstActivities
    {
        //good test data
        string ActivityName = "Kayaking";
        string ActivityCity = "London";
        Decimal ActivityPrice = 21.50m;
        string ActivityPostCode = "LE5 0UE";
        string ActivityAddress = "45 crosshedge close";
        string mActivityDescription = "options of paddle boards and kayaks";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsActivities AnActivity = new clsActivities();
            Assert.IsNotNull(AnActivity);
        }

        [TestMethod]
        public void ActivityIDOK()
        {
            //instance of the class
            clsActivities AnActivity = new clsActivities();
            //test data to assign to property
            Int32 TestData = 1;
            //assign data
            AnActivity.ActivityID = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnActivity.ActivityID, TestData);
        }

        [TestMethod]
        public void ActivityCityOK()
        {
            //instance of the class
            clsActivities AnActivity = new clsActivities();
            //test data to assign to property
            string TestData = "London";
            //assign data
            AnActivity.ActivityCity = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnActivity.ActivityCity, TestData);
        }

        [TestMethod]
        public void ActivityAddressOK()
        {
            //instance of the class
            clsActivities AnActivity = new clsActivities();
            //test data to assign to property
            string TestData = "45 crosshedge close";
            //assign data
            AnActivity.ActivityAddress = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnActivity.ActivityAddress, TestData);
        }

        [TestMethod]
        public void ActivityDescriptionOK()
        {
            //instance of the class
            clsActivities AnActivity = new clsActivities();
            //test data to assign to property
            string TestData = "London";
            //assign data
            AnActivity.ActivityDescription = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnActivity.ActivityDescription, TestData);
        }

        [TestMethod]
        public void ActivityNameOK()
        {
            //instance of the class
            clsActivities AnActivity = new clsActivities();
            //test data to assign to property
            string TestData = "Kayaking";
            //assign data
            AnActivity.ActivityName = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnActivity.ActivityName, TestData);
        }

        [TestMethod]
        public void ActivityPostCodeOK()
        {
            //instance of the class
            clsActivities AnActivity = new clsActivities();
            //test data to assign to property
            string TestData = "LE3 4EQ";
            //assign data
            AnActivity.ActivityPostCode = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnActivity.ActivityPostCode, TestData);
        }

        [TestMethod]
        public void ActivityPriceOK()
        {
            //instance of the class
            clsActivities AnActivity = new clsActivities();
            //test data to assign to property
            decimal TestData = 59.99m;
            //assign data
            AnActivity.ActivityPrice = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnActivity.ActivityPrice, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create instance of class
            clsActivities AnActivity = new clsActivities();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //test data to use with the method               
            Int32 ActivityID = 1;
            //invoke the method
            Found = AnActivity.Find(ActivityID);
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestActivityIDFound()
        {
            //isntance of the class
            clsActivities AnActivity = new clsActivities();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 ActivityID = 1;
            //invoke the method
            Found = AnActivity.Find(ActivityID);
            //check activity name
            if (AnActivity.ActivityID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActivityNameFound()
        {
            //isntance of the class
            clsActivities AnActivity = new clsActivities();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 ActivityID = 1;
            //invoke the method
            Found = AnActivity.Find(ActivityID);
            //check activity name
            if (AnActivity.ActivityName != "Kayaking")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActivityAddressFound()
        {
            //isntance of the class
            clsActivities AnActivity = new clsActivities();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 ActivityID = 1;
            //invoke the method
            Found = AnActivity.Find(ActivityID);
            //check activity name
            if (AnActivity.ActivityAddress != "45 crosshedge close")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActivityCityFound()
        {
            //instance of the class
            clsActivities AnActivity = new clsActivities();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 ActivityID = 1;
            //invoke method
            Found = AnActivity.Find(ActivityID);
            //check city
            if (AnActivity.ActivityCity != "London, Birmingham, Leeds")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActivityPriceFound()
        {
            //instance of the class
            clsActivities AnActivity = new clsActivities();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 ActivityID = 1;
            //invoke method
            Found = AnActivity.Find(ActivityID);
            //check city
            if (AnActivity.ActivityPrice != 21.50m)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActivityPostCodeFound()
        {
            //instance of the class
            clsActivities AnActivity = new clsActivities();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 ActivityID = 1;
            //invoke method
            Found = AnActivity.Find(ActivityID);
            //check city
            if (AnActivity.ActivityPostCode != "LE5 0UE")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActivityDescriptionFound()
        {
            //instance of the class
            clsActivities AnActivity = new clsActivities();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 ActivityID = 1;
            //invoke method
            Found = AnActivity.Find(ActivityID);
            //check city
            if (AnActivity.ActivityDescription != "options of paddle boards and kayaks")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an sintance of the class
            clsActivities AnActivity = new clsActivities();
            //string variable to store error message
            String Error = "";
            //invoke the method
            Error = AnActivity.Valid(ActivityNameOK, ActivityCityOK, ActivityAddressOK, ActivityDescriptionOK, ActivityPostCodeOK, ActivityPriceOK);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }
    }   
}