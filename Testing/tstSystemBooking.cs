using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstSystemBooking
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsSystemBooking ABooking = new clsSystemBooking();
            //test to see that it exists
            Assert.IsNotNull(ABooking);
        }

        [TestMethod]
        public void BookingIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsSystemBooking ABooking = new clsSystemBooking();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign data to the property
            ABooking.BookingID = TestData;
            //test to see that it exists
            Assert.AreEqual(ABooking.BookingID, TestData);
        }

        [TestMethod]
        public void BookingDataPropertyOK()
        {
            //create an instance of the class we want to create 
            clsSystemBooking ABooking = new clsSystemBooking();
            //create some test data to assign to the property 
           DateTime TestData = DateTime.Now.Date;
            //assign data to the property
            ABooking.BookingDate = TestData;
            //test to see that it exists
            Assert.AreEqual(ABooking.BookingDate, TestData);
        }

        [TestMethod]
        public void BookingPaymentInfoPropertyOK()
        {
            //create an instance of the class we want to create 
            clsSystemBooking ABooking = new clsSystemBooking();
            //create some test data to assign to the property 
            string TestData = "Credit";
            //assign data to the property
            ABooking.BookingPaymentInfo = TestData;
            //test to see that it exists
            Assert.AreEqual(ABooking.BookingPaymentInfo, TestData);
        }

        [TestMethod]
        public void BookingTypePropertyOK()                                     //can be taken out
        {
            //create an instance of the class we want to create 
            clsSystemBooking ABooking = new clsSystemBooking();
            //create some test data to assign to the property 
            string TestData = "";
            //assign data to the property
            ABooking.BookingType = TestData;
            //test to see that it exists
            Assert.AreEqual(ABooking.BookingType, TestData);
        }
    }
}
