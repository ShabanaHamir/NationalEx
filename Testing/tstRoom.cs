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
        decimal RoomPrice = 210.57m;

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
        public void RoomPricePropertyOK()
        {
            //create instance
            clsRoom ARoom = new clsRoom();
            //create tests data to assign to property
            decimal TestData = 100.75m;
            //assign data to property
            ARoom.RoomPrice = TestData;
            //test to see that too values are the same
            Assert.AreEqual(ARoom.RoomPrice, TestData);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsRoom ARoom = new clsRoom();
            //string var to store any error message
            String Error = "";
            //invoke method
            Error = ARoom.Valid(HotelID, RoomNumber, RoomType, RoomPrice);
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

        [TestMethod]
        public void TestRoomPriceFound()                                      
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
            if (ARoom.RoomPrice != 210.57m)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

                                                                        //RoomNumber
        [TestMethod]
        public void RoomNumberMinLessOne()
        {
            //create an instance of the class we want to create 
            clsRoom ARoom = new clsRoom();
            //string var to store any error message
            String Error = "";
            //some data to pass ro the method
            string RoomNumber = "";
            //invoke method
            Error = ARoom.Valid(HotelID, RoomNumber, RoomType, RoomPrice);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomNumberMin()
        {
            //create an instance of the class we want to create 
            clsRoom ARoom = new clsRoom();
            //string var to store any error message
            String Error = "";
            //some data to pass ro the method
            string RoomNumber = "1"; //pass
            //invoke method
            Error = ARoom.Valid(HotelID, RoomNumber, RoomType, RoomPrice);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomNumberMax()
        {
            //create an instance of the class we want to create 
            clsRoom ARoom = new clsRoom();
            //string var to store any error message
            String Error = "";
            //some data to pass ro the method
            string RoomNumber = "1234567891"; //pass
            //invoke method
            Error = ARoom.Valid(HotelID, RoomNumber, RoomType, RoomPrice);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoomNumberMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsRoom ARoom = new clsRoom();
            //string var to store any error message
            String Error = "";
            //some data to pass ro the method
            string RoomNumber = "12345678911"; //fail
            //invoke method
            Error = ARoom.Valid(HotelID, RoomNumber, RoomType, RoomPrice);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }
                                                                                        //RoomPrice
        [TestMethod]
        public void RoomPriceMinLessOne()
        {
            //create an instance of the class we want to create 
            clsRoom ARoom = new clsRoom();
            //string var to store any error message
            String Error = "";
            //some data to pass ro the method
            decimal RoomPrice = 0; //fail
            //invoke method
            Error = ARoom.Valid(HotelID, RoomNumber, RoomType, RoomPrice);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }
                                                                                //RoomType
        [TestMethod]
        public void RoomTypeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsRoom ARoom = new clsRoom();
            //string var to store any error message
            String Error = "";
            //some data to pass ro the method
            string RoomType = ""; //fail
            //invoke method
            Error = ARoom.Valid(HotelID, RoomNumber, RoomType, RoomPrice);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void RoomTypeMin()
        {
            //create an instance of the class we want to create 
            clsRoom ARoom = new clsRoom();
            //string var to store any error message
            String Error = "";
            //some data to pass ro the method
            string RoomType = "S"; //Pass
            //invoke method
            Error = ARoom.Valid(HotelID, RoomNumber, RoomType, RoomPrice);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void RoomTypeMax()
        {
            //create an instance of the class we want to create 
            clsRoom ARoom = new clsRoom();
            //string var to store any error message
            String Error = "";
            //some data to pass ro the method
            string RoomType = "Ocean View Penthouse Apartment"; //Pass
            //invoke method
            Error = ARoom.Valid(HotelID, RoomNumber, RoomType, RoomPrice);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomTypeMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsRoom ARoom = new clsRoom();
            //string var to store any error message
            String Error = "";
            //some data to pass ro the method
            string RoomType = "Ocean View Penthouse Apartment1"; //Pass
            //invoke method
            Error = ARoom.Valid(HotelID, RoomNumber, RoomType, RoomPrice);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomTypeMid()
        {
            //create an instance of the class we want to create 
            clsRoom ARoom = new clsRoom();
            //string var to store any error message
            String Error = "";
            //some data to pass ro the method
            string RoomType = "Executive Suite"; //Pass
            //invoke method
            Error = ARoom.Valid(HotelID, RoomNumber, RoomType, RoomPrice);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }
                                                                                    //HotelID
        [TestMethod]
        public void HotelIDMinLessOne()
        {
            //create an instance of the class we want to create 
            clsRoom ARoom = new clsRoom();
            //string var to store any error message
            String Error = "";
            //some data to pass ro the method
            string HotelID = ""; //fail
            //invoke method
            Error = ARoom.Valid(HotelID, RoomNumber, RoomType, RoomPrice);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }
    }
}
