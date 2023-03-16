using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstRoom
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance
            clsRoom ARoom = new clsRoom();
            Assert.IsNotNull(ARoom);
        }
        //[TestMethod]
        //public void RoomIDPropertyOK()
        //{
        //    //create instance
        //    clsRoom ARoom = new clsRoom();
        //    //create tests data to assign to property
        //    Int32 TestData = 22;
        //    //assign data to property
        //    ARoom.RoomID = TestData;
        //    //test to see that too values are the same
        //    Assert.AreEqual(ARoom.RoomID, TestData);
        //}
        [TestMethod]
        public void HotelIDPropertyOK()                         //Do I need this?
        {
            //create instance
            clsRoom ARoom = new clsRoom();
            //create tests data to assign to property
            Int32 TestData = 22;
            //assign data to property
            ARoom.HotelID = TestData;
            //test to see that too values are the same
            Assert.AreEqual(ARoom.HotelID, TestData);
        }

        [TestMethod]
        public void RoomNumberPropertyOK()
        {
            //create instance
            clsRoom ARoom = new clsRoom();
            //create tests data to assign to property
            Int32 TestData = 22;
            //assign data to property
            ARoom.RoomNumber = TestData;
            //test to see that too values are the same
            Assert.AreEqual(ARoom.RoomNumber, TestData);
        }
        [TestMethod]
        public void RoomTypePropertyOK()
        {
            //create instance
            clsRoom ARoom = new clsRoom();
            //create tests data to assign to property
            string TestData = "Single";
            //assign data to property
            ARoom.RoomType = TestData;
            //test to see that too values are the same
            Assert.AreEqual(ARoom.RoomType, TestData);
        }
        //[TestMethod]                                              // do i need this
        //public void Valid()
        //{
        //    //create an instance of the class we want to create 
        //    clsHotel ARoom = new clsHotel();
        //    //test to see if valid method exists 
        //    ARoom.Valid("Single");
        //}

        [TestMethod]
        public void FindMethodOK()
        {
            //create instance
            clsRoom ARoom = new clsRoom();
            //bool var to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 RoomID = 1;
            //invoke the method
            Found = ARoom.Find(RoomID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
           
        }

        [TestMethod]
        public void TestRoomIDFound()
        {
            //create instance
            clsRoom ARoom = new clsRoom();
            //bool var to store the result of the validation
            Boolean Found = false;
            //bool var to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 RoomID = 1;
            //invoke the method
            Found = ARoom.Find(RoomID);
            //check the room id
            if (ARoom.RoomID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestRoomNumberFound()
        {
            //create instance
            clsRoom ARoom = new clsRoom();
            //bool var to store the result of the validation
            Boolean Found = false;
            //bool var to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 RoomID = 1;
            //invoke the method
            Found = ARoom.Find(RoomID);
            //check the room id
            if (ARoom.RoomNumber != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestRoomTypeFound()
        {
            //create instance
            clsRoom ARoom = new clsRoom();
            //bool var to store the result of the validation
            Boolean Found = false;
            //bool var to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 RoomID = 1;
            //invoke the method
            Found = ARoom.Find(RoomID);
            //check the room id
            if (ARoom.RoomType != "Single")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestHotelIDFound()                                      //not sure if it should be there?
        {
            //create instance
            clsRoom ARoom = new clsRoom();
            //bool var to store the result of the validation
            Boolean Found = false;
            //bool var to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 RoomID = 1;
            //invoke the method
            Found = ARoom.Find(RoomID);
            //check the room id
            if (ARoom.HotelID != 134)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
    }
}
