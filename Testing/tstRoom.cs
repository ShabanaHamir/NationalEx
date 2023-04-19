using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstRoom
    {

        //good test data
        //create some test data to pass to the method

        string HotelID = "22";
        string RoomNumber = "34";
        string RoomType = "Double";



        [TestMethod]
        public void InstanceOK()
        {
            //create instance
            clsRoom ARoom = new clsRoom();
            Assert.IsNotNull(ARoom);
        }
        [TestMethod]
        public void RoomIDPropertyOK()
        {
            //create instance
            clsRoom ARoom = new clsRoom();
            //create tests data to assign to property
            Int32 TestData = 2;
            //assign data to property
            ARoom.RoomID = TestData;
            //test to see that too values are the same
            Assert.AreEqual(ARoom.RoomID, TestData);
        }
        [TestMethod]
        public void HotelIDPropertyOK()                         //mehtagaha
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
            Int32 TestData = 21;
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
            string TestData = "Double";
            //assign data to property
            ARoom.RoomType = TestData;
            //test to see that too values are the same
            Assert.AreEqual(ARoom.RoomType, TestData);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsRoom ARoom = new clsRoom();
            //string var to store any error message
            String Error = "";
            //invoke method
            Error = ARoom.Valid(HotelID, RoomNumber, RoomType);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create instance
            clsRoom ARoom = new clsRoom();
            //bool var to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 RoomID = 3;
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
            Int32 RoomID = 3;
            //invoke the method
            Found = ARoom.Find(RoomID);
            //check the room id
            if (ARoom.RoomID != 3)
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
            Int32 RoomID = 3;
            //invoke the method
            Found = ARoom.Find(RoomID);
            //check the room id
            if (ARoom.RoomNumber != 31)
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
            Int32 RoomID = 3;
            //invoke the method
            Found = ARoom.Find(RoomID);
            //check the room id
            if (ARoom.RoomType != "Suite")
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
            Int32 RoomID = 3;
            //invoke the method
            Found = ARoom.Find(RoomID);
            //check the room id
            if (ARoom.HotelID != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

       
    }
}
