using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;
using System;
using System.Collections.Generic;
using System.Linq;

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
            TestItem.EMail = "trial@gmail.com";
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
            TestBooking.EMail = "trial@gmail.com";
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
            TestItem.EMail = "trial@gmail.com";
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
            TestItem.EMail = "trial@gmail.com";
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
            TestItem.EMail = "trial@gmail.com";
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
            TestItem.EMail = "hello@bbb.co.uk";
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

        //[TestMethod]
        //public void ReportByEMailMethodOK()
        //{
        //    //create an instance of the class we want to create
        //    clsBookingCollection AllBookings = new clsBookingCollection();
        //    //create an instance of filtered data
        //    clsBookingCollection FilteredBooking = new clsBookingCollection();
        //    //apply blank string (should return all records)
        //    FilteredBooking.ReportByEMail("hello@bbb.co.uk");
        //    //test to see that 2 values are the same
        //    Assert.AreEqual(AllBookings.Count, FilteredBooking.Count);

        //}

        [TestMethod]
        public void ReportByEMailMethodOK()
        {
            //create an instance of the class we want to create
            clsBookingCollection AllBookings = new clsBookingCollection();
            //create an instance of filtered data
            clsBookingCollection FilteredBooking = new clsBookingCollection();
            //apply an existing email (should return only records with that email)
            FilteredBooking.ReportByEMail("hello@bbb.co.uk");
            //test to see that 2 values are the same
            Assert.AreEqual(AllBookings.BookingList.Count(b => b.EMail == "hello@bbb.co.uk"), FilteredBooking.Count);
        }

        [TestMethod]
        public void ReportByEMailNoneFound()
        {
            //create an instance of the class we want to create
            clsBookingCollection FilteredBooking = new clsBookingCollection();
            //apply blank string that doesnt exist
            FilteredBooking.ReportByEMail("xxxxxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredBooking.Count);
        }

        [TestMethod]
        public void ReportByEMailTestDataFound()
        {
            //create an instance of the class we want to create
            clsBookingCollection FilteredBooking = new clsBookingCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a city that doesnt exist
            FilteredBooking.ReportByEMail("hello@bbb.co.uk");
            //check that the correct number of records found
            if (FilteredBooking.Count == 2)
            {
                if (FilteredBooking.BookingList[0].BookingID != 2)
                {
                    OK = false;
                }
                if (FilteredBooking.BookingList[1].BookingID != 9)
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