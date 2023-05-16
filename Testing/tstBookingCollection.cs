using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;
using System;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class tstBookingCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsBookingCollection AllBookings = new clsBookingCollection();
            //test to see that it exists
            Assert.IsNotNull(AllBookings);
        }

        [TestMethod]
        public void BookingListOK()
        {
            //create an instance of the class
            clsBookingCollection AllBookings = new clsBookingCollection();
            //create test data
            List<clsBooking> TestList = new List<clsBooking>();
            //add an item to the list
            clsBooking TestItem = new clsBooking();
            //set its properties
            TestItem.BookingID = 1;
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.PaymentType = "Mastercard";
            TestItem.BookingDetails = "21/09/2018 1x double bed. Room 89. 2x Kayaking London 21/09/2018 12:30";
            TestItem.FirstName = "Sara";
            TestItem.UserID = 1;
            TestItem.TotalCost = 80.00m;
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllBookings.BookingList = TestList;
            //test tp see that the two values are the same
            Assert.AreEqual(AllBookings.BookingList, TestList);
            //
        }

        [TestMethod]
        public void ThisBookingPropertyOK()
        {
            //create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            //create test data to assign to the property
            clsBooking TestBooking = new clsBooking();
            //set its properties
            TestBooking.BookingID = 1;
            TestBooking.BookingDate = DateTime.Now.Date;
            TestBooking.PaymentType = "Mastercard";
            TestBooking.BookingDetails = "21/09/2018 1x double bed. Room 89. 2x Kayaking London 21/09/2018 12:30";
            TestBooking.FirstName = "Sara";
            TestBooking.UserID = 1;
            TestBooking.TotalCost = 80.00m;
            //assign the data to the property
            AllBookings.ThisBooking = TestBooking;
            //test to see that the two values are the same
            Assert.AreEqual(AllBookings.ThisBooking, TestBooking);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            //create test data
            List<clsBooking> TestList = new List<clsBooking>();
            //add an item to the list
            clsBooking TestItem = new clsBooking();
            //set its properties
            TestItem.BookingID = 1;
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.PaymentType = "Mastercard";
            TestItem.BookingDetails = "21/09/2018 1x double bed. Room 89. 2x Kayaking London 21/09/2018 12:30";
            TestItem.FirstName = "Sara";
            TestItem.UserID = 1;
            TestItem.TotalCost = 80.00m;
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllBookings.BookingList = TestList;
            //test tp see that the two values are the same
            Assert.AreEqual(AllBookings.BookingList, TestList);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of the class
            clsBookingCollection AllBookings = new clsBookingCollection();
            //create item of test data
            clsBooking TestItem = new clsBooking();
            //var to store pk
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.BookingID = 1;
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.PaymentType = "Mastercard";
            TestItem.BookingDetails = "21/09/2018 1x double bed. Room 89. 2x Kayaking London 21/09/2018 12:30";
            TestItem.FirstName = "Sara";
            TestItem.UserID = 1;
            TestItem.TotalCost = 80.00m;
            //set ThisActivity to test data
            AllBookings.ThisBooking = TestItem;
            //add record
            PrimaryKey = AllBookings.Add();
            //set pk of test data
            TestItem.BookingID = PrimaryKey;
            //find record
            AllBookings.ThisBooking.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllBookings.ThisBooking, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            //create item of test data
            clsBooking TestItem = new clsBooking();
            //var to store pk
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.BookingID = 1;
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.PaymentType = "Mastercard";
            TestItem.BookingDetails = "21/09/2018 1x double bed. Room 89. 2x Kayaking London 21/09/2018 12:30";
            TestItem.FirstName = "Sara";
            TestItem.UserID = 1;
            TestItem.TotalCost = 80.00m;
            //set ThisActivity to test data
            AllBookings.ThisBooking = TestItem;
            //add record
            PrimaryKey = AllBookings.Add();
            //find record
            AllBookings.ThisBooking.Find(PrimaryKey);
            //de;ete
            AllBookings.Delete();
            //find the record
            Boolean Found = AllBookings.ThisBooking.Find(PrimaryKey);
            //test to see that the record wasnt found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            //create item of test data
            clsBooking TestItem = new clsBooking();
            //var to store pk
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.BookingID = 2;
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.PaymentType = "Visa Debit";
            TestItem.BookingDetails = "2x Kayaking London ";
            TestItem.FirstName = "Jake";
            TestItem.UserID = 4;
            TestItem.TotalCost = 35.00m;
            //set ThisActivity to test data
            AllBookings.ThisBooking = TestItem;
            //add record
            PrimaryKey = AllBookings.Add();
            //set the pk of the testdata
            TestItem.BookingID = PrimaryKey;
            //modify test data
            TestItem.BookingDate = DateTime.Now.Date;
            TestItem.PaymentType = "PayPal";
            TestItem.BookingDetails = "3x Kayaking London ";
            TestItem.TotalCost = 35.00m;
            //set record based on new test data
            AllBookings.ThisBooking = TestItem;
            //update record
            AllBookings.Update();
            //find record
            AllBookings.ThisBooking.Find(PrimaryKey);
            //test to see that this activity matches the test data
            Assert.AreEqual(AllBookings.ThisBooking, TestItem);
        }






    }

}