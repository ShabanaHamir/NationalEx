using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;
using System;

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
        public void ActivitiesListOK()
        {
            ////create an instance of the class
            //clsBookingCollection AllBookings = new clsBookingCollection();
            ////create test data
            //List<clsBooking> TestList = new List<clsBooking>();
            ////add an item to the list
            //clsBooking TestItem = new clsBooking();
            ////set its properties
            //TestItem.BookingID = 1;
            //TestItem.BookingDate = "Kayaking";
            //TestItem.PaymentType = "London";
            //TestItem.BookingDetails = "8 Crewbridge Drive";
            //TestItem.FirstName = "LE6 0UE";
            //TestItem.UserID = "go kayaking with ...";
            //TestItem.TotalCost = 54.99m;
            ////add item to the test list
            //TestList.Add(TestItem);
            ////assign the data to the property
            //AllBookings.BookingList = TestList;
            ////test tp see that the two values are the same
            //Assert.AreEqual(AllBookings.BookingList, TestList);
            ////
        }
    }
}
