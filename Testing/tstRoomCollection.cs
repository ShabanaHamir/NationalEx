using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class tstRoomCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //instance of the class I want to create
            clsRoomCollection AllRooms = new clsRoomCollection();
            Assert.IsNotNull(AllRooms);
        }

        [TestMethod]
        public void RoomlListOK()
        {
            //instance of the class I want to create
            clsRoomCollection AllRooms = new clsRoomCollection();
            //list of objrcts for the data
            List<clsRoom> TestList = new List<clsRoom>();
            //add an item to the list
            //create item of the test data
            clsRoom TestItem = new clsRoom();
            //set its properties
            TestItem.RoomID = 1;
            TestItem.HotelID = 1;
            TestItem.HotelName = "Holiday Inn";
            TestItem.RoomNumber = 47;
            TestItem.FloorNumber = 4;
            TestItem.RoomType = "Single";
            TestItem.NumberOfBeds = 1;
            TestItem.RoomPrice = 120;
            TestItem.RoomDescription = "Modern Single Room with a Garden View";
            TestItem.RoomFacilities = "TV, Wifi, Fridge, Coffe Machine";
            TestItem.Occupied = false;
            //add item to list
            TestList.Add(TestItem);
            //assign data to property
            AllRooms.RoomList = TestList;
            //test two values are same
            Assert.AreEqual(AllRooms.RoomList, TestList);


        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //    clsRoomCollection AllRooms = new clsRoomCollection();
        //    Int32 SomeCount = 2;
        //    AllRooms.Count = SomeCount;
        //    Assert.AreEqual(AllRooms.Count, SomeCount);
        //}

        [TestMethod]
        public void ThiRoomPropertyOK()
        {
            clsRoomCollection AllRooms = new clsRoomCollection();
            clsRoom TestRoom = new clsRoom();
            //set properties of the test object
            TestRoom.RoomID = 1;
            TestRoom.HotelID = 1;
            TestRoom.HotelName = "Holiday Inn";
            TestRoom.RoomNumber = 47;
            TestRoom.FloorNumber = 4;
            TestRoom.RoomType = "Single";
            TestRoom.NumberOfBeds = 1;
            TestRoom.RoomPrice = 120;
            TestRoom.RoomDescription = "Modern Single Room with a Garden View";
            TestRoom.RoomFacilities = "TV, Wifi, Fridge, Coffe Machine";
            TestRoom.Occupied = false;
            //assign data to the property
            AllRooms.ThisRoom = TestRoom;
            Assert.AreEqual(AllRooms.ThisRoom, TestRoom);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsRoomCollection AllRooms = new clsRoomCollection();
            //create test data to assign to proprty
            //list of objrcts for the data
            List<clsRoom> TestList = new List<clsRoom>();
            //test data
            clsRoom TestItem = new clsRoom();
            //set properties
            //set its properties
            TestItem.RoomID = 1;
            TestItem.HotelID = 1;
            TestItem.HotelName = "Holiday Inn";
            TestItem.RoomNumber = 47;
            TestItem.FloorNumber = 4;
            TestItem.RoomType = "Single";
            TestItem.NumberOfBeds = 1;
            TestItem.RoomPrice = 120;
            TestItem.RoomDescription = "Modern Single Room with a Garden View";
            TestItem.RoomFacilities = "TV, Wifi, Fridge, Coffe Machine";
            TestItem.Occupied = false;
            //add the item to test list
            TestList.Add(TestItem);
            //assign data to property
            AllRooms.RoomList = TestList;
            //test that two values are the same
            Assert.AreEqual(AllRooms.Count, TestList.Count);

        }

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    clsRoomCollection AllRooms = new clsRoomCollection();
        //    Assert.AreEqual(AllRooms.Count, 2);
        //}

        [TestMethod]
        public void AddMethodOK()
        {
            clsRoomCollection AllRooms = new clsRoomCollection();
            clsRoom TestItem = new clsRoom();
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.RoomID = 1;
            TestItem.HotelID = 1;
            TestItem.HotelName = "Holiday Inn";
            TestItem.RoomNumber = 47;
            TestItem.FloorNumber = 4;
            TestItem.RoomType = "Single";
            TestItem.NumberOfBeds = 1;
            TestItem.RoomPrice = 120;
            TestItem.RoomDescription = "Modern Single Room with a Garden View";
            TestItem.RoomFacilities = "TV, Wifi, Fridge, Coffe Machine";
            TestItem.Occupied = false;
            //set thisHotel to test data
            AllRooms.ThisRoom = TestItem;
            PrimaryKey = AllRooms.Add();
            //set pk of the test data
            TestItem.RoomID = PrimaryKey;
            AllRooms.ThisRoom.Find(PrimaryKey);
            Assert.AreEqual(AllRooms.ThisRoom, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsRoomCollection AllRooms = new clsRoomCollection();
            clsRoom TestItem = new clsRoom();
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.RoomID = 1;
            TestItem.HotelID = 1;
            TestItem.HotelName = "Holiday Inn";
            TestItem.RoomNumber = 47;
            TestItem.FloorNumber = 4;
            TestItem.RoomType = "Single";
            TestItem.NumberOfBeds = 1;
            TestItem.RoomPrice = 120;
            TestItem.RoomDescription = "Modern Single Room with a Garden View";
            TestItem.RoomFacilities = "TV, Wifi, Fridge, Coffe Machine";
            TestItem.Occupied = false;
            AllRooms.ThisRoom = TestItem;
            PrimaryKey = AllRooms.Add();
            TestItem.RoomID = PrimaryKey;
            AllRooms.ThisRoom.Find(PrimaryKey);
            AllRooms.Delete();
            Boolean Found = AllRooms.ThisRoom.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsRoomCollection AllRooms = new clsRoomCollection();
            clsRoom TestItem = new clsRoom();
            Int32 PrimaryKey = 0;
            //set properties
            TestItem.RoomID = 1;
            TestItem.HotelID = 1;
            TestItem.HotelName = "Holiday Inn";
            TestItem.RoomNumber = 47;
            TestItem.FloorNumber = 4;
            TestItem.RoomType = "Single";
            TestItem.NumberOfBeds = 1;
            TestItem.RoomPrice = 120;
            TestItem.RoomDescription = "Modern Single Room with a Garden View";
            TestItem.RoomFacilities = "TV, Wifi, Fridge, Coffe Machine";
            TestItem.Occupied = false;
            //set thisroom to test data
            AllRooms.ThisRoom = TestItem;
            //add record
            PrimaryKey = AllRooms.Add();
            //set pk of the test data
            TestItem.RoomID = PrimaryKey;
            //modify test data
            TestItem.RoomID = 2;
            TestItem.HotelID = 1;
            TestItem.HotelName = "Holiday Inn";
            TestItem.RoomNumber = 21;
            TestItem.FloorNumber = 2;
            TestItem.RoomType = "Double";
            TestItem.NumberOfBeds = 2;
            TestItem.RoomPrice = 141;
            TestItem.RoomDescription = "Modern";
            TestItem.RoomFacilities = "TV, Free Wifi, Pets";
            TestItem.Occupied = true;
            //assign the modified TestItem object to AllRooms.ThisRoom
            AllRooms.ThisRoom = TestItem;
            //find 
            AllRooms.ThisRoom.Find(PrimaryKey);
            //update
            AllRooms.Update();
            //find record
            Boolean Found = AllRooms.ThisRoom.Find(PrimaryKey);
            //test to see that record was found and updated
            Assert.IsTrue(Found);
            //test to see that the data matches the modified TestItem object
            Assert.AreEqual(AllRooms.ThisRoom, TestItem);
        }


        [TestMethod]
        public void ReportByHotelName() //filter for the staff
        {
            //instance of the class
            clsRoomCollection AllRooms = new clsRoomCollection();
            //an instance of filtered data
            clsRoomCollection FilteredRooms = new clsRoomCollection();
            //apply a blank string (returns all records)
            FilteredRooms.ReportByHotelName("");
            //test that two values are the same
            Assert.AreEqual(AllRooms.Count, FilteredRooms.Count);
        }


        [TestMethod]
        public void ReportByHotelNameNoneFound() //filter for the staff
        {
            //instance
            clsRoomCollection FilteredRooms = new clsRoomCollection();
            //apply a hotelID that doesn't exist
            FilteredRooms.ReportByHotelName("xxxxxx");
            Assert.AreEqual(0, FilteredRooms.Count);
        }



        //[TestMethod]
        //public void ReportByHotelNameTestDataFound() //filter for the staff
        //{
        //    clsRoomCollection FilteredRooms = new clsRoomCollection();
        //    Boolean OK = true;
        //    FilteredRooms.ReportByHotelName("Holiday Inn");
        //    //check that correct no of records are found
        //    if (FilteredRooms.Count == 2)
        //    {
        //        //first record if is 1
        //        if (FilteredRooms.RoomList[0].RoomID != 1)
        //        {
        //            OK = false;
        //        }
        //        //first record if is 2
        //        if (FilteredRooms.RoomList[0].RoomID != 2)
        //        {
        //            OK = false;
        //        }
        //    }
        //    else
        //    {
        //        OK = false;
        //    }
        //    Assert.IsTrue(OK);
        //}
    }
}
