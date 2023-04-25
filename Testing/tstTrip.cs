using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Class_Library;
using System;

namespace Testing
{


    [TestClass]
    public class tstTrip
    {
        //good test data 
        //some test data to pass the method 
        string TripID = "2";
        string TripDate = DateTime.Now.Date.ToString();
        string TripDestination = "Paris";
            string VehicleType ="Coach";

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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsTrip AnTrip = new clsTrip();
            //assign test data
            Boolean Found = false;
            //create test data to test the method
            Int32 TripID = 1;
            // execute the method 
            Found = AnTrip.Find(TripID);
            //test to see the result
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestTripIDFound()
        {
            //create an instance of the class
            clsTrip AnTrip = new clsTrip();
            //assign test data
            Boolean Found = false;
            //record the data if it is ok 
            Boolean OK = true;
            //create test data to test the method
            Int32 TripID = 1;
            // execute the method 
            Found = AnTrip.Find(TripID);
            //check the trip ID 
            if (AnTrip.TripID != 1)
            {
                OK = false;
            }
            //test to see the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTripDateFound()
        {
            //create an instance of the class
            clsTrip AnTrip = new clsTrip();
            //assign test data
            Boolean Found = false;
            //record the data if it is ok 
            Boolean OK = true;
            //create test data to test the method
            Int32 TripID = 1;
            // execute the method 
            Found = AnTrip.Find(TripID);
            //check the trip ID 
            if (AnTrip.TripDate != Convert.ToDateTime("04/04/2023"))
            {
                OK = false;
            }
            //test to see the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTripDestinationFound()
        {
            //create an instance of the class
            clsTrip AnTrip = new clsTrip();
            //assign test data
            Boolean Found = false;
            //record the data if it is ok 
            Boolean OK = true;
            //create test data to test the method
            Int32 TripID = 1;
            // execute the method 
            Found = AnTrip.Find(TripID);
            //check the trip ID 
            if (AnTrip.TripDestination != "London")
            {
                OK = false;
            }
            //test to see the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestVehicleTypeFound()
        {
            //create an instance of the class
            clsTrip AnTrip = new clsTrip();
            //assign test data
            Boolean Found = false;
            //record the data if it is ok 
            Boolean OK = true;
            //create test data to test the method
            Int32 TripID = 1;
            // execute the method 
            Found = AnTrip.Find(TripID);
            //check the trip ID 
            if (AnTrip.VehicleType != "Bus")
            {
                OK = false;
            }
            //test to see the result
            Assert.IsTrue(OK); //
        }


        [TestMethod]
        public void ValidMethodOK ()
        {
            //create an instance of the class
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message 
            String Error = "";
            //invoke the method 
            Error = AnTrip.Valid(TripID,TripDate,TripDestination,VehicleType);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }












    }


}
