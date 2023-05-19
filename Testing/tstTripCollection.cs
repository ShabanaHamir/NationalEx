using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class tstTripCollection
    {



        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsTripCollection AllTrips = new clsTripCollection();
            //test to see if it is there 
            Assert.IsNotNull(AllTrips);
        }

        [TestMethod]
        public void TripListOK()
        {
            //create an instance of the class we want to create 
            clsTripCollection AllTrips = new clsTripCollection();
            //create test data to assign to proprty
            //list of objects for the data
            List<clsTrip> TestList = new List<clsTrip>();
            //add an item to the list
            //create item of the test data
            clsTrip TestItem = new clsTrip();
            //set its properties
            TestItem.TripID = 1;
            TestItem.TripDate = DateTime.Now.Date;
            TestItem.TripDestination = "London";
            TestItem.VehicleType = "Bus";
            TestItem.TripSource = "Birmingham";
            TestItem.TicketCost = 33.00m;
            TestItem.TripStartTime = DateTime.Now.Date;
            TestItem.TripEndTime = DateTime.Now.Date;
            //add item to the test list
            TestList.Add(TestItem);
            //assign data to property
            AllTrips.TripList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllTrips.TripList, TestList);

        }

        [TestMethod]
        public void ThisTripPropertyOK()
        {
            clsTripCollection AllTrips = new clsTripCollection();
            clsTrip TestTrip = new clsTrip();
            //set properties of the test object
            TestTrip.TripID = 1;
            TestTrip.TripDate = DateTime.Now.Date;
            TestTrip.TripDestination = "London";
            TestTrip.VehicleType = "Bus";
            TestTrip.TripSource = "Birmingham";
            TestTrip.TicketCost = 33.00m;
            TestTrip.TripStartTime = DateTime.Now.Date;
            TestTrip.TripEndTime = DateTime.Now.Date;
            //assign data to the property
            AllTrips.ThisTrip = TestTrip;
            Assert.AreEqual(AllTrips.ThisTrip, TestTrip);

        }
        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    clsTripCollection AllTrips = new clsTripCollection();
        //    Int32 SomeCount = 2;
        //    AllTrips.Count = SomeCount;
        //    Assert.AreEqual(AllTrips.Count, SomeCount);
        //}

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsTripCollection AllTrips = new clsTripCollection();
            //create test data to assign to proprty
            //list of objects for the data
            List<clsTrip> TestList = new List<clsTrip>();
            //add an item to the list
            //create item of the test data
            clsTrip TestItem = new clsTrip();
            //set its properties
            TestItem.TripID = 1;
            TestItem.TripDate = DateTime.Now.Date;
            TestItem.TripDestination = "London";
            TestItem.VehicleType = "Bus";
            TestItem.TripSource = "Birmingham";
            TestItem.TicketCost = 33.00m;
            TestItem.TripStartTime = DateTime.Now.Date;
            TestItem.TripEndTime = DateTime.Now.Date;
            //add item to the test list
            TestList.Add(TestItem);
            //assign data to property
            AllTrips.TripList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllTrips.Count, TestList.Count);


        }


        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    //create an instance of the class we want to create 
        //    clsTripCollection AllTrips = new clsTripCollection();

        //    //test to see the two values are the same
        //    Assert.AreEqual(AllTrips.Count, 2);


        //}

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsTripCollection AllTrips = new clsTripCollection();
            //add an item to the list
            //create item of the test data
            clsTrip TestItem = new clsTrip();
            //variable to save the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.TripID = 1;
            TestItem.TripDate = DateTime.Now.Date;
            TestItem.TripDestination = "London";
            TestItem.VehicleType = "Bus";
            TestItem.TripSource = "Birmingham";
            TestItem.TicketCost = 33.00m;
            TestItem.TripStartTime = DateTime.Now.Date;
            TestItem.TripEndTime = DateTime.Now.Date;
            //set thistrip to the test data
            AllTrips.ThisTrip = TestItem;
            //add the record 
            PrimaryKey = AllTrips.Add();
            //set the primary key of the test data 
            TestItem.TripID = PrimaryKey;
            //set the trip to the test data 
            AllTrips.ThisTrip.Find(PrimaryKey);
            //add the record 

            //test to see the two values are the same
            Assert.AreEqual(AllTrips.ThisTrip, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsTripCollection AllTrips = new clsTripCollection();
            //add an item to the list
            //create item of the test data
            clsTrip TestItem = new clsTrip();
            //variable to save the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.TripID = 1;
            TestItem.TripDate = DateTime.Now.Date;
            TestItem.TripDestination = "London";
            TestItem.VehicleType = "Bus";
            TestItem.TripSource = "Birmingham";
            TestItem.TicketCost = 33.00m;
            TestItem.TripStartTime = DateTime.Now.Date;
            TestItem.TripEndTime = DateTime.Now.Date;
            //set thistrip to the test data
            AllTrips.ThisTrip = TestItem;
            //add the record 
            PrimaryKey = AllTrips.Add();
            //set the primary key of the test data 
            TestItem.TripID = PrimaryKey;
            //set the trip to the test data 
            AllTrips.ThisTrip.Find(PrimaryKey);
            //delete the record
            AllTrips.Delete();
            //find the record
            Boolean Found = AllTrips.ThisTrip.Find(PrimaryKey);

            //test to see the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create 
            clsTripCollection AllTrips = new clsTripCollection();
            //add an item to the list
            //create item of the test data
            clsTrip TestItem = new clsTrip();
            //variable to save the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.TripID = 1;
            TestItem.TripDate = DateTime.Now.Date;
            TestItem.TripDestination = "London";
            TestItem.VehicleType = "Bus";
            TestItem.TripSource = "Birmingham";
            TestItem.TicketCost = 33.00m;
            TestItem.TripStartTime = DateTime.Now.Date;
            TestItem.TripEndTime = DateTime.Now.Date;
            //set thistrip to the test data
            AllTrips.ThisTrip = TestItem;
            //add the record 
            PrimaryKey = AllTrips.Add();
            //set the primary key of the test data 
            TestItem.TripID = PrimaryKey;
            //set the trip to the test data 
            TestItem.TripID = 2;
            TestItem.TripDate = DateTime.Now.Date;
            TestItem.TripDestination = "Paris";
            TestItem.VehicleType = "Coach";
            TestItem.TripSource = "Cardiff";
            TestItem.TicketCost = 167.00m;
            TestItem.TripStartTime = DateTime.Now.Date;
            TestItem.TripEndTime = DateTime.Now.Date;
            AllTrips.ThisTrip.Find(PrimaryKey);
            AllTrips.Update();
            Boolean Found = AllTrips.ThisTrip.Find(PrimaryKey);

            //find the record

            //test to see the two values are the same
            Assert.AreEqual(AllTrips.ThisTrip, TestItem);
        }


        [TestMethod]
        public void ReportByTripDestination()
        {
            clsTripCollection AllTrips = new clsTripCollection();
            clsTripCollection FilteredTrips = new clsTripCollection();
            FilteredTrips.ReportByTripDestination("");
            Assert.AreEqual(AllTrips.Count, FilteredTrips.Count);

        }


        [TestMethod]
        public void ReportByTripDestinationNoneFound()
        {
            clsTripCollection FilteredTrips = new clsTripCollection();
            FilteredTrips.ReportByTripDestination("Trip Destination");
            Assert.AreEqual(0, FilteredTrips.Count);
        }


        //[TestMethod]
        //public void ReportByTripDestinationTestDataFound()
        //{
        //    clsTripCollection FilterTrips = new clsTripCollection();
        //    Boolean OK = true;
        //    FilterTrips.ReportByTripDestination("London");
        //    if (FilterTrips.Count == 2)
        //    {
        //        if (FilterTrips.TripList[0].TripID != 1)
        //        {
        //            OK = false;
        //        }
        //        if (FilterTrips.TripList[1].TripID != 6)
        //        {
        //            OK = false;
        //        }
        //    }
        //    else
        //    {
        //        OK = false;
        //    }
        //    Assert.IsTrue(OK);

        //}







    }
}






