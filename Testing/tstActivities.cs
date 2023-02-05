using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing
{
    [TestClass]
    public class tstActivities
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsActivities AnActivity = new clsActivities();
            Assert.IsNotNull(AnActivity);
        }

        [TestMethod]
        public void ActivityCity()
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
        public void ActivityDescription()
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
        public void ActivityName()
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
        public void ActivityPostCode()
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
        public void ActivityPrice()
        {
            //instance of the class
            clsActivities AnActivity = new clsActivities();
            //test data to assign to property
            decimal TestData = 59.99M;
            //assign data
            AnActivity.ActivityPrice = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnActivity.ActivityPrice, TestData);
        }
    }   
}
