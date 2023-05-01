using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class tstHotelCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //instance of the class I want to create
            clsHotelCollection AllHotels = new clsHotelCollection();
            Assert.IsNotNull(AllHotels);
        }
        [TestMethod]
        public void HotelListOK()
        {
            //instance of the class I want to create
            clsHotelCollection AllHotels = new clsHotelCollection();
            //create test data to assign to proprty
            //list of objrcts for the data
            List<clsHotel> TestList = new List<clsHotel>();
            //add an item to the list
            //create item of the test data
            clsHotel TestItem =new clsHotel();
            //set its properties
            TestItem.HotelID = 1;
            TestItem.HotelName = "Inn";
            TestItem.HotelPhoneNumber = 01234567891;
            TestItem.HotelPostCode = "XXX XXX";
            //add item to the test list
            TestList.Add(TestItem);
            //assign data to property
            AllHotels.HotelList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllHotels.HotelList, TestList);

        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsHotelCollection AllHotels = new clsHotelCollection();
            Int32 SomeCount = 0;
            AllHotels.Count = SomeCount;
            Assert.AreEqual(AllHotels.Count, SomeCount);
        }
        [TestMethod]
        public void ThisHotelPropertyOK()
        {
            clsHotelCollection AllHotels = new clsHotelCollection();
            clsHotel TestHotel = new clsHotel();
            //set properties of the test object
            TestHotel.HotelID = 1;
            TestHotel.HotelName = "Inn";
            TestHotel.HotelPhoneNumber = 01234567891;
            TestHotel.HotelPostCode = "XXX XXX";
            //assign data to the property
            AllHotels.ThisHotel = TestHotel;
            Assert.AreEqual(AllHotels.ThisHotel, TestHotel);

        }
    }
}
