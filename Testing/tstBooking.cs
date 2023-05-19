using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing       //sql changes 
{
    [TestClass]
    public class tstBooking
    {
        //create good test data
        int BookingID = 1;
        string BookingDate = DateTime.Now.Date.ToString();
        string PaymentType = "MasterCard";
        string BookingDetails = "21/09/2018 1x double bed. Room 89. 2x Kayaking London 21/09/2018 12:30";
        string FirstName = "Sara";
        string EMail = "trial@gmail.com";
        int UserID = 1;
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
        public void FirstNamePropertyOK()                                     //can be taken out
        {
            //create an instance of the class we want to create 
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property 
            string TestData = "Shannon";
            //assign data to the property
            ABooking.FirstName = TestData;
            //test to see that it exists
            Assert.AreEqual(ABooking.FirstName, TestData);
        }

        [TestMethod]
        public void EMailPropertyOK()                                  
        {
            //create an instance of the class we want to create 
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property 
            string TestData = "trial@gmail.com";
            //assign data to the property
            ABooking.EMail = TestData;
            //test to see that it exists
            Assert.AreEqual(ABooking.EMail, TestData);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsBooking ABooking = new clsBooking();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign data to the property
            ABooking.UserID = TestData;
            //test to see that it exists
            Assert.AreEqual(ABooking.UserID, TestData);
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
        public void TestFirstNameFound()
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
            if (ABooking.FirstName != "Sara")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEMailFound()
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
            if (ABooking.EMail != "trial@gmail.com")
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

        public void TestUserIDFound()
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
            if (ABooking.UserID != 1)
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
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookingDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsBooking ABooking = new clsBooking();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string BookingDate = TestDate.ToString();
            //invoke the method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookingDatePlusOne()
        {
            //create an instance of the class we want to create
            clsBooking ABooking = new clsBooking();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string BookingDate = TestDate.ToString();
            //invoke the method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookingDateInvalidData()
        {
            //create an instance of the class we want to create
            clsBooking ABooking = new clsBooking();
            //string variable to store any error message
            String Error = "";
            string BookingDate = "This is not a date.";
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookingDateMin()
        {
            //create an instance of the class we want to create
            clsBooking ABooking = new clsBooking();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string BookingDate = TestDate.ToString();
            //invoke the method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentTypeMinusOne()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string PaymentType = "";
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentTypeMin()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string PaymentType = "a";
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentTypeMax()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string PaymentType = "pppppppppppppppppppppppppppppppppppppppppppppppppp";
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentTypePlusOne()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string PaymentType = "ppppppppppppppppppppppppppppppppppppppppppppppppppp";
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void BookingDetailsMinusOne()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string BookingDetails = "";
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BookingDetailsMin()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string BookingDetails = "a";
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookingDetailsMax()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string BookingDetails = "";
            BookingDetails = BookingDetails.PadRight(500, 'p');
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BookingDetailsPlusOne()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string BookingDetails = "";
            BookingDetails = BookingDetails.PadRight(501, 'p');
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EMailMinusOne()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string EMail = "";
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EMailMin()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string EMail = "a";
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EMailMax()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string EMail = "pppppppppppppppppppppppppppppppppppppppppppppppppp";
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EMailPlusOne()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string EMail = "ppppppppppppppppppppppppppppppppppppppppppppppppppp";
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMinusOne()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string FirstName = "";
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string FirstName = "a";
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string FirstName = "pppppppppppppppppppppppppppppppppppppppppppppppppp";
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNamePlusOne()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            string FirstName = "ppppppppppppppppppppppppppppppppppppppppppppppppppp";
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void TotalCostMinusOne()
        {
            //instance of class
            clsBooking ABooking = new clsBooking();
            //string variable for error message
            String Error = "";
            //create some test data to pass to message
            decimal TotalCost = 0;
            //invoke method
            Error = ABooking.Valid(BookingDate, PaymentType, BookingDetails, EMail, FirstName, TotalCost);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}