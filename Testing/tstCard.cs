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

        public void CardIDPropertyOK()
        {
            //create an instance of the class
            clsCard ACard = new clsCard();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign data
            ACard.CardID = TestData;
            //test to see the two values are the same
            Assert.AreEqual(ACard.CardID, TestData);
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
        public void CardNamePropertyOK()
        {
            //create an instance of the class
            clsCard ACard = new clsCard();
            //create some test data to assign to the property
            string TestData = "Richard Branson";
            //assign data
            ACard.CardName = TestData;
            //test to see the two values are the same
            Assert.AreEqual(ACard.CardName, TestData);
        }

        public void FindMethodOK()
        {
            //create instance of class
            clsCard ACard = new clsCard();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //test data to use with the method               
            Int32 CardID = 1;
            //invoke the method
            Found = ACard.Find(CardID);
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCardIDFound()
        {
            //isntance of the class
            clsCard ACard = new clsCard();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 CardID = 1;
            //invoke the method
            Found = ACard.Find(CardID);
            //check Booking name
            if (ACard.CardID != 1)
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCardNameFound()
        {
            //isntance of the class
            clsCard ACard = new clsCard();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 CardID = 1;
            //invoke the method
            Found = ACard.Find(CardID);
            //check card name
            if (ACard.CardName != "Sara")
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCardNoFound()
        {
            //isntance of the class
            clsCard ACard = new clsCard();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 CardID = 1;
            //invoke the method
            Found = ACard.Find(CardID);
            //check Booking name
            if (ACard.CardNo != "0863 1673 7238 1637")
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }
    }
}
