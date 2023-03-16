using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//this class is shared among the system
namespace Testing
{
    [TestClass]
    public class tstCard
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsCard ACard = new clsCard();
            //test to see that it exists
            Assert.IsNotNull(ACard);
        }

        [TestMethod]
        public void CardNoPropertyOK()
        {
            //create an instance of the class
            clsCard ACard = new clsCard();
            //create some test data to assign to the property
            string TestData = "0863 1673 7238 1637";
            //assign data
            ACard.CardNo = TestData;
            //test to see the two values are the same
            Assert.AreEqual(ACard.CardNo, TestData);
        }

        [TestMethod]
        public void ExpiryDatePropertyOK()
        {
            //create an instance of the class
            clsCard ACard = new clsCard();
            //create some test data to assign to the property
            string TestData = "08/27";
            //assign data
            ACard.ExpiryDate = TestData;
            //test to see the two values are the same
            Assert.AreEqual(ACard.ExpiryDate, TestData);
        }

        [TestMethod]
        public void NameOnCardPropertyOK()
        {
            //create an instance of the class
            clsCard ACard = new clsCard();
            //create some test data to assign to the property
            string TestData = "Richard Branson";
            //assign data
            ACard.NameOnCard = TestData;
            //test to see the two values are the same
            Assert.AreEqual(ACard.NameOnCard, TestData);
        }
    }
}
