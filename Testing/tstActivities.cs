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
        string ActivityAddress = "45 crosshedge close";
        string ActivityPostCode = "LE5 0UE";
        string ActivityDescription = "options of paddle boards and kayaks";
        int NoOfPeople = 2;

        decimal ActivityPrice = 21.50m;   //try decimal instead of Decimal -Shahd
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
        public void NoOfPeopleOK()
        {
            //instance of the class
            clsActivities AnActivity = new clsActivities();
            //test data to assign to property
            int TestData = 5;
            //assign data
            AnActivity.NoOfPeople = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnActivity.NoOfPeople, TestData);
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
        public void TestNoOfPeopleFound()
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
            if (AnActivity.NoOfPeople != 2)
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
            if (AnActivity.ActivityCity != "London")
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
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ActivityNameMinusOne()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityName = "";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ActivityNameMin()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityName = "a";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ActivityNameMax()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityName = "pppppppppppppppppppppppppppppppppppppppppppppppppp";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ActivityNamePlusOne()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityName = "ppppppppppppppppppppppppppppppppppppppppppppppppppp";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ActivityCityMinusOne()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityCity = "";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ActivityCityMin()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityCity = "a";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ActivityCityMax()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityCity = "pppppppppppppppppppppppppppppppppppppppppppppppppp";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ActivityCityPlusOne()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityCity = "ppppppppppppppppppppppppppppppppppppppppppppppppppp";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ActivityPostCodeMinusOne()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityPostCode = "";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ActivityPostCodeMin()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityPostCode = "a";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ActivityPostcodeMax()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityPostCode = "ppppppppppppppp";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ActivityPostCodePlusOne()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityPostCode = "pppppppppppppppp";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice); 
            // test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ActivityAddressMinusOne()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityAddress = "";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ActivityAddressMin()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityAddress = "a";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ActivityAddressMax()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityAddress = "pppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppp";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ActivityAddressPlusOne()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityAddress = "pppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppp";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void NoOfPeopleMinLessOne()
        {
            //create an instance of the class we want to create 
            clsActivities AnActivity = new clsActivities();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            int NoOfPeople = -1;
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            // Test to see if the result is correct (expecting an error)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NoOfPeopleMaxPlusOne()
        {
            // Instance of the class
            clsActivities AnActivity = new clsActivities();
            // String variable for error message
            String Error = "";
            // Create some test data to pass to the method
            int NoOfPeople = 101; // Value greater than the maximum allowed (100)
                                  // Invoke the method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            // Test to see if the result is correct (expecting an error)
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ActivityDescriptionMinusOne()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityDescription = "";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ActivityDescriptionMin()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityDescription = "a";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ActivityDescriptionMax()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityDescription = "pppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppp";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ActivityDescriptionPlusOne()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string ActivityDescription = "ppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppp";
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ActivityPriceMinusOne()
        {
            //instance of class
            clsActivities AnActivity = new clsActivities();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            decimal ActivityPrice = 0;
            //invoke method
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, NoOfPeople, ActivityPrice);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}