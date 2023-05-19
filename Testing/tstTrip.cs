using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing
{


    [TestClass]
    public class tstTrip
    {
        //good test data 
        //some test data to pass the method 
        //string TripID = "2";
        string TripDate = DateTime.Now.Date.ToString();
        string TripDestination = "Paris";
        string VehicleType = "Coach";
        string TripSource = "Cardiff";
        decimal TicketCost = 33.00m;
        string TripStartTime = DateTime.Now.Date.ToString();
        string TripEndTime = DateTime.Now.Date.ToString();

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
        public void TripSourcePropertyOK()
        {
            //create an instance of the class
            clsTrip AnTrip = new clsTrip();
            //assign test data
            string TestData = "Birmingham";
            //assign data to property
            AnTrip.TripSource = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnTrip.TripSource, TestData);
        }


        [TestMethod]
        public void TicketCostPropertyOK()
        {
            //create an instance of the class
            clsTrip AnTrip = new clsTrip();
            //assign test data
            decimal TestData = 80.00m;
            //assign data to property
            AnTrip.TicketCost = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AnTrip.TicketCost, TestData);
        }

        [TestMethod]
        public void TripStartTimePropertyOK()
        {
            //create an instance of the class we want to create 
            clsTrip AnTrip = new clsTrip();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property 
            AnTrip.TripStartTime = TestData;
            //t est to see that the two values are the same 
            Assert.AreEqual(AnTrip.TripStartTime, TestData);

        }

        [TestMethod]
        public void TripEndtTimePropertyOK()
        {
            //create an instance of the class we want to create 
            clsTrip AnTrip = new clsTrip();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property 
            AnTrip.TripEndTime = TestData;
            //t est to see that the two values are the same 
            Assert.AreEqual(AnTrip.TripEndTime, TestData);

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
        public void TestTripSourceFound()
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
            if (AnTrip.TripSource != "Birmingham")
            {
                OK = false;
            }
            //test to see the result
            Assert.IsTrue(OK); //
        }


        [TestMethod]
        public void TestTicketCostFound()
        {
            //isntance of the class
            clsTrip AnTrip = new clsTrip();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 TripID = 1;
            //invoke the method
            Found = AnTrip.Find(TripID);
            //check the property
            if (AnTrip.TicketCost != 33.00m)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestTripStartTimeFound()
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
            if (AnTrip.TripStartTime != Convert.ToDateTime("04/04/2023 11:00:00"))
            {
                OK = false;
            }
            //test to see the result
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestTripEndTimeFound()
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
            if (AnTrip.TripEndTime != Convert.ToDateTime("18/05/2023 18:00:00"))
            {
                OK = false;
            }
            //test to see the result
            Assert.IsTrue(OK);
        }












        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message 
            String Error = "";
            //invoke the method 
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]

        public void TripDateExtremeMin()
        {
            //create an instance of the class we want to create 
            clsTrip AnTrip = new clsTrip();
            //string to save any error messages 
            String Error = "";
            //create a variabke to save the test data 
            DateTime TestDate;
            //set the to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //cponvert the date variable to a string variable 
            string TripDate = TestDate.ToString();
            //invoke the method 
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to the result
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TripDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string TripDate = TestDate.ToString();
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TripDateMin()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string TripDate = TestDate.ToString();
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TripDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string TripDate = TestDate.ToString();
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TripDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string TripDate = TestDate.ToString();
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void TripDateInvalidData()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            // set the trip date to a non date value 
            string TripDate = "please enter a valid date ";
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }





        [TestMethod]
        public void TripDestinationMinLessOne()
        {
            //create an instance of the class we want to create 
            clsTrip AnTrip = new clsTrip();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string TripDestination = ""; //error
            //invoke method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }

        public void TripDestinationMin()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TripDestination = "t";
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TripDestinationMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TripDestination = "tt"; //this should be ok
                                           //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TripDestinationMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TripDestination = "ttttttttttttt"; //this should be ok
                                                      //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TripDestinationMax()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TripDestination = "tttttttttttttt"; //this should be ok
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TripDestinationMid()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TripDestination = "ttttttt"; //this should be ok
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void TripDestinationMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TripDestination = "ttttttttttttttt"; //this should be ok
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TripDestinationExtremeMax()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TripDestination = "";
            TripDestination = TripDestination.PadRight(500, 't');
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void VehicleTypeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsTrip AnTrip = new clsTrip();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string VehicleType = ""; //error
            //invoke method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }

        public void VehicleTypeMin()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string VehicleType = "t";
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VehicleTypeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string VehicleType = "tt"; //this should be ok
                                       //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VehicleTypeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string VehicleType = "ttttttttttttt"; //this should be ok
                                                  //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void VehicleTypeMax()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string VehicleType = "tttttttttttttt"; //this should be ok
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void VehicleTypeMid()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string VehicleType = "ttttttt"; //this should be ok
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void VehicleTypeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string VehicleType = "ttttttttttttttt"; //this should be ok
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void VehicleTypeExtremeMax()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TripDestination = "";
            VehicleType = VehicleType.PadRight(500, 't');
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TripSourceMinLessOne()
        {
            //create an instance of the class we want to create 
            clsTrip AnTrip = new clsTrip();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string TripSource = ""; //error
            //invoke method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TripSourceMin()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TripSource = "t";
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void TripSourceMax()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TripSource = "tttttttttttttt"; //this should be ok
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TripSourcenMid()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TripSource = "ttttttt"; //this should be ok
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void TripSourceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TripSource = "ttttttttttttttt"; //this should be ok
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TripSourceExtremeMax()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TripSource = "";
            TripSource = TripSource.PadRight(500, 't');
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void TicketCostMinusOne()
        {
            //instance of class
            clsTrip AnTrip = new clsTrip();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            decimal TicketCost = 0;
            //invoke method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void TripStartTimeExtremeMin()
        {
            //create an instance of the class we want to create 
            clsTrip AnTrip = new clsTrip();
            //string to save any error messages 
            String Error = "";
            //create a variabke to save the test data 
            DateTime TestDate;
            //set the to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //cponvert the date variable to a string variable 
            string TripStartTime = TestDate.ToString();
            //invoke the method 
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to the result
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TripStartTimeMinLessOne()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string TripStartTime = TestDate.ToString();
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TripStartTimeMin()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string TripStartTime = TestDate.ToString();
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TripStartTimeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string TripStartTime = TestDate.ToString();
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TripStartTimeExtremeMax()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string TripStartTime = TestDate.ToString();
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void TripStartTimeInvalidData()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            // set the trip date to a non date value 
            string TripDate = "please enter a valid date ";
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]

        public void TripEndTimeExtremeMin()
        {
            //create an instance of the class we want to create 
            clsTrip AnTrip = new clsTrip();
            //string to save any error messages 
            String Error = "";
            //create a variabke to save the test data 
            DateTime TestDate;
            //set the to todays date 
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //cponvert the date variable to a string variable 
            string TripEndTime = TestDate.ToString();
            //invoke the method 
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to the result
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TripEndTimeMinLessOne()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string TripEndTime = TestDate.ToString();
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TripEndTimeMin()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string TripEndTime = TestDate.ToString();
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TripEndTimeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string TripStartTime = TestDate.ToString();
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TripEndTimeExtremeMax()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string TripStartTime = TestDate.ToString();
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void TripEndTimeInvalidData()
        {
            //create an instance of the class we want to create
            clsTrip AnTrip = new clsTrip();
            //string variable to store any error message
            String Error = "";
            // set the trip date to a non date value 
            string TripDate = "please enter a valid date ";
            //invoke the method
            Error = AnTrip.Valid(TripDate, TripDestination, VehicleType, TripSource, TicketCost, TripStartTime, TripEndTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }















    }











}




