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
    }
}
