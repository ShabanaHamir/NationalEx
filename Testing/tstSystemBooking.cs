using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing       //sql changes 
{
    [TestClass]
    public class tstSystemBooking
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsBooking ABooking = new clsBooking();
            //test to see that it exists
            Assert.IsNotNull(ABooking);
        }

        [TestMethod]
        public void BookingIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign data to the property
            ABooking.BookingID = TestData;
            //test to see that it exists
            Assert.AreEqual(ABooking.BookingID, TestData);
        }

        [TestMethod]
        public void BookingDatePropertyOK()
        {
            //create an instance of the class we want to create 
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            ABooking.BookingDate = TestData;
            //test to see that it exists
            Assert.AreEqual(ABooking.BookingDate, TestData);
        }

        [TestMethod]
        public void PaymentTypePropertyOK()
        {
            //create an instance of the class we want to create 
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property 
            string TestData = "MasterCard";
            //assign data to the property
            ABooking.PaymentType = TestData;
            //test to see that it exists
            Assert.AreEqual(ABooking.PaymentType, TestData);
        }

        [TestMethod]
        public void BookingDetailsPropertyOK()                                     //can be taken out
        {
            //create an instance of the class we want to create 
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property 
            string TestData = "Hotel: Transylvania x2. Activity: Kayaking x2. Time: 10:30";
            //assign data to the property
            ABooking.BookingDetails = TestData;
            //test to see that it exists
            Assert.AreEqual(ABooking.BookingDetails, TestData);
        }

        [TestMethod]
        public void UserFNamePropertyOK()                                     //can be taken out
        {
            //create an instance of the class we want to create 
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property 
            string TestData = "Sara";
            //assign data to the property
            ABooking.UserFName = TestData;
            //test to see that it exists
            Assert.AreEqual(ABooking.UserFName, TestData);
        }

        [TestMethod]
        public void TotalCostPropertyOK()                                     //can be taken out
        {
            //create an instance of the class we want to create 
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property 
            decimal TestData = 25.50m;
            //assign data to the property
            ABooking.TotalCost = TestData;
            //test to see that it exists
            Assert.AreEqual(ABooking.TotalCost, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create instance of class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //test data to use with the method               
            Int32 BookingID = 2618936;
            //invoke the method
            Found = ABooking.Find(BookingID);
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookingIDFound()
        {
            //isntance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 BookingID = 17;
            //invoke the method
            Found = ABooking.Find(BookingID);
            //check Booking name
            if (ABooking.BookingID != 17)
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        public void TestBookingDateFound()
        {
            //isntance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 BookingID = 17;
            //invoke the method
            Found = ABooking.Find(BookingID);
            //check the property
            if (ABooking.BookingDate != Convert.ToDateTime("18/06/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestUserFNameFound()
        {
            //isntance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 BookingID = 17;
            //invoke the method
            Found = ABooking.Find(BookingID);
            //check the property
            if (ABooking.UserFName != "Sara")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestBookingDetailsFound()
        {
            //isntance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 BookingID = 17;
            //invoke the method
            Found = ABooking.Find(BookingID);
            //check the property
            if (ABooking.BookingDetails != "Hotel: Transylvania x2. Activity: Kayaking x2. Time: 10:30")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void TestPaymentTypeFound()
        {
            //isntance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 BookingID = 17;
            //invoke the method
            Found = ABooking.Find(BookingID);
            //check the property
            if (ABooking.PaymentType != "MasterCard")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        public void TestTotalCostFound()
        {
            //isntance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 BookingID = 17;
            //invoke the method
            Found = ABooking.Find(BookingID);
            //check the property
            if (ABooking.TotalCost != 25.50m)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}