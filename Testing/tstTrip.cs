using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstTrip
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsTrip AnTrip = new clsTrip();
            //test to see that it exists 
            Assert.IsNotNull(AnTrip);

        }

        [TestMethod]
        public void TripIdPropertyOK()
        {
            //create an instance of the class we want to create 
            clsTrip AnTrip = new clsTrip();
            //create some test data to assign to the property 
            Int32 TestData = 4;
            //assign data to the property 
            AnTrip.TripID = TestData;
            //t est to see that the two values are the same 
            Assert.AreEqual(AnTrip.TripID, TestData);

        }

         [TestMethod]
        public void TripDatePropertyOK()
        {
            //create an instance of the class we want to create 
            clsTrip AnTrip = new clsTrip();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property 
            AnTrip.TripDate = TestData;
            //t est to see that the two values are the same 
            Assert.AreEqual(AnTrip.TripDate, TestData);

        }


        [TestMethod]
        public void TripDestinationPropertyOK()
        {
            //create an instance of the class
            clsTrip AnTrip = new clsTrip();
            //assign test data
            string TestData = "London";
            //assign data to property
            AnTrip.TripDestination = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnTrip.TripDestination, TestData);
        }


        [TestMethod]
        public void VehicleTypePropertyOK()
        {
            //create an instance of the class
            clsTrip AnTrip = new clsTrip();
            //assign test data
            string TestData = "Bus";
            //assign data to property
            AnTrip.VehicleType = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnTrip.VehicleType, TestData);
        }





    }


}
