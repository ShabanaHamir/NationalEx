﻿using Classes;
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
            clsHotel TestItem = new clsHotel();
            //set its properties
            TestItem.HotelID = 1;
            TestItem.HotelName = "Holiday Inn";
            TestItem.HotelCity = "Leicester";
            TestItem.HotelPhoneNumber = 23092002;
            TestItem.HotelPostCode = "LE4 8UE";
            //add item to the test list
            TestList.Add(TestItem);
            //assign data to property
            AllHotels.HotelList = TestList;
            //test to see the two values are the same
            Assert.AreEqual(AllHotels.HotelList, TestList);

        }
        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    clsHotelCollection AllHotels = new clsHotelCollection();
        //    Int32 SomeCount = 2;
        //    AllHotels.Count = SomeCount;
        //    Assert.AreEqual(AllHotels.Count, SomeCount);
        //}
        [TestMethod]
        public void ThisHotelPropertyOK()
        {
            clsHotelCollection AllHotels = new clsHotelCollection();
            clsHotel TestHotel = new clsHotel();
            //set properties of the test object
            TestHotel.HotelID = 1;
            TestHotel.HotelName = "Holiday Inn";
            TestHotel.HotelCity = "Leicester";
            TestHotel.HotelPhoneNumber = 23092002;
            TestHotel.HotelPostCode = "LE4 8UE";
            //assign data to the property
            AllHotels.ThisHotel = TestHotel;
            Assert.AreEqual(AllHotels.ThisHotel, TestHotel);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsHotelCollection AllHotels = new clsHotelCollection();
            //create test data to assign to proprty
            //list of objrcts for the data
            List<clsHotel> TestList = new List<clsHotel>();
            //test data
            clsHotel TestItem = new clsHotel();
            //set properties
            //set its properties
            TestItem.HotelID = 1;
            TestItem.HotelName = "Holiday Inn";
            TestItem.HotelCity = "Leicester";
            TestItem.HotelPhoneNumber = 23092002;
            TestItem.HotelPostCode = "LE4 8UE";
            //add the item to test list
            TestList.Add(TestItem);
            //assign data to property
            AllHotels.HotelList = TestList;
            //test that two values are the same
            Assert.AreEqual(AllHotels.Count, TestList.Count);

        }

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    clsHotelCollection AllHotels = new clsHotelCollection();
        //    Assert.AreEqual(AllHotels.Count, 2);
        //}

        [TestMethod]
        public void AddMethodOK()
        {
            clsHotelCollection AllHotels = new clsHotelCollection();
            clsHotel TestItem = new clsHotel();
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.HotelID = 1;
            TestItem.HotelName = "Holiday Inn";
            TestItem.HotelCity = "Leicester";
            TestItem.HotelPhoneNumber = 23092002;
            TestItem.HotelPostCode = "LE4 8UE";
            //set thisHotel to test data
            PrimaryKey = AllHotels.Add();
            //set pk of the test data
            TestItem.HotelID = PrimaryKey;
            AllHotels.ThisHotel.Find(PrimaryKey);
            Assert.AreEqual(AllHotels.ThisHotel, TestItem);
        }
    }
}
