using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing       //sql changes 
{
    [TestClass]
    public class tstSystemBooking
    {
        //create good test data
        string BookingDate = DateTime.Now.Date.ToString();
        string UserFName = "Shannon";
        string BookingDetails = "21/09/2018 1x double bed. Room 89. 2x Kayaking London 21/09/2018 12:30";
        string PaymentType = "MasterCard";
        decimal TotalCost = 80.00m;                                                                          

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
            string TestData = "Mastercard";
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
            string TestData = "21/09/2018 1x double bed. Room 89. 2x Kayaking London 21/09/2018 12:30";
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
            string TestData = "Shannon";
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
            decimal TestData = 80.00m;
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
            Int32 BookingID = 1;
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
            Int32 BookingID = 1;
            //invoke the method
            Found = ABooking.Find(BookingID);
            //check Booking name
            if (ABooking.BookingID != 1)
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookingDateFound()
        {
            //isntance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 BookingID = 1;
            //invoke the method
            Found = ABooking.Find(BookingID);
            //check the property
            if (ABooking.BookingDate != Convert.ToDateTime("10/09/2018"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestUserFNameFound()
        {
            //isntance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 BookingID = 1;
            //invoke the method
            Found = ABooking.Find(BookingID);
            //check the property
            if (ABooking.UserFName != "Shannon")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBookingDetailsFound()
        {
            //isntance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 BookingID = 1;
            //invoke the method
            Found = ABooking.Find(BookingID);
            //check the property
            if (ABooking.BookingDetails != "21/09/2018 1x double bed. Room 89. 2x Kayaking London 21/09/2018 12:30")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentTypeFound()
        {
            //isntance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 BookingID = 1;
            //invoke the method
            Found = ABooking.Find(BookingID);
            //check the property
            if (ABooking.PaymentType != "Mastercard")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalCostFound()
        {
            //isntance of the class
            clsBooking ABooking = new clsBooking();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 BookingID = 1;
            //invoke the method
            Found = ABooking.Find(BookingID);
            //check the property
            if (ABooking.TotalCost != 80.00m)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable to store error message
            String Error = "";
            //invoke method
            Error = ABooking.Valid(BookingDate, UserFName, PaymentType, BookingDetails, PaymentType);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}