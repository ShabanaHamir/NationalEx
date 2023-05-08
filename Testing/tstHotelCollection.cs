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
            clsHotel TestItem = new clsHotel();
            //set its properties
            TestItem.HotelID = 1;
            TestItem.HotelName = "Holiday Inn";
            TestItem.HotelCity = "Leicester";
            TestItem.HotelPhoneNumber = "23092002";
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
            TestHotel.HotelPhoneNumber = "23092002";
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
            TestItem.HotelPhoneNumber = "23092002";
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
            TestItem.HotelPhoneNumber = "23092002";
            TestItem.HotelPostCode = "LE4 8UE";
            //set thisHotel to test data
            AllHotels.ThisHotel = TestItem;
            PrimaryKey = AllHotels.Add();
            //set pk of the test data
            TestItem.HotelID = PrimaryKey;
            AllHotels.ThisHotel.Find(PrimaryKey);
            Assert.AreEqual(AllHotels.ThisHotel, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //instance
            clsHotelCollection AllHotels = new clsHotelCollection();
            //data to assign to properties
            clsHotel TestItem = new clsHotel();
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.HotelID = 1;
            TestItem.HotelName = "Holiday Inn";
            TestItem.HotelCity = "Leicester";
            TestItem.HotelPhoneNumber = "23092002";
            TestItem.HotelPostCode = "LE4 8UE";
            //set this hotel to test data
            AllHotels.ThisHotel = TestItem;
            //set thisHotel to test data
            PrimaryKey = AllHotels.Add();
            //set pk of the test data
            TestItem.HotelID = PrimaryKey;
            //find record
            AllHotels.ThisHotel.Find(PrimaryKey);
            //delete record
            AllHotels.Delete();
            //find record
            Boolean Found = AllHotels.ThisHotel.Find(PrimaryKey);
            //TEST TO SEE THAT THE RECORD WAS NOT FOUND
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsHotelCollection AllHotels = new clsHotelCollection();
            //create item of test data 
            clsHotel TestItem = new clsHotel();
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.HotelID = 1;
            TestItem.HotelName = "Holiday Inn";
            TestItem.HotelCity = "Leicester";
            TestItem.HotelPhoneNumber = "23092002";
            TestItem.HotelPostCode = "LE4 8UE";
            //set thisHotel to test data
            AllHotels.ThisHotel = TestItem;
            //add record
            PrimaryKey = AllHotels.Add();
            //set pk of the test data
            TestItem.HotelID = PrimaryKey;
            //modify test data
            TestItem.HotelID = 2;
            TestItem.HotelName = "Inn";
            TestItem.HotelCity = "Trial";
            TestItem.HotelPhoneNumber = "234555556";
            TestItem.HotelPostCode = "P36 7UG";
            //find the record 
            AllHotels.ThisHotel.Find(PrimaryKey);
            //delete record
            AllHotels.Update();
            //now find the record
            Boolean Found = AllHotels.ThisHotel.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.AreEqual(AllHotels.ThisHotel, TestItem);

        }

        [TestMethod]
        public void ReportByHotelName() //filter for the staff
        {
            //instance of the class
            clsHotelCollection AllHotels = new clsHotelCollection();
            //an instance of filtered data
            clsHotelCollection FilteredHotels = new clsHotelCollection();
            //apply a blank string (returns all records)
            FilteredHotels.ReportByHotelName("");
            //test that two values are the same
            Assert.AreEqual(AllHotels.Count, FilteredHotels.Count);
        }

        [TestMethod]
        public void ReportByHotelNameNoneFound() //filter for the staff
        {

            //an instance of filtered data
            clsHotelCollection FilteredHotels = new clsHotelCollection();
            //apply a blank string (returns all records)
            FilteredHotels.ReportByHotelName("Hotel Name");
            //test that two values are the same
            Assert.AreEqual(0, FilteredHotels.Count);
        }

        [TestMethod]
        public void ReportByHotelNameTestDataFound() //filter for the staff
        {

            //an instance of filtered data
            clsHotelCollection FilteredHotels = new clsHotelCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that doesnt exist
            FilteredHotels.ReportByHotelName("Buckingham");
            //check that the correct no of records are found
            if (FilteredHotels.Count == 2)
            {
                //check that the first record ID is 10
                if (FilteredHotels.HotelList[0].HotelID != 10)
                {
                    OK = false;
                }
                //check that the first record is 11
                if (FilteredHotels.HotelList[1].HotelID != 11)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test see that there are no records
            Assert.IsTrue(OK);
        }
    }
}

