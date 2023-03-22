using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//this class is shared among the system
namespace Testing
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //test to see that it exists
            Assert.IsNotNull(APayment);
        }
        [TestMethod]
        public void PaymentIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //create some test data to assign to the property 
            Int32 TestData = 1;
            //assign the data to the property
            APayment.PaymentID = TestData;
            //test to see that it exists
            Assert.AreEqual(APayment.PaymentID, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //create some test data to assign to the property 
            Int32 TestData = 2;
            //assign the data to the property
            APayment.CustomerID = TestData;
            //test to see that it exists
            Assert.AreEqual(APayment.CustomerID, TestData);
        }

        [TestMethod]
        public void PaymentAmountPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //create some test data to assign to the property 
            Int32 TestData = 160;
            //assign the data to the property
            APayment.PaymentAmount = TestData;
            //test to see that it exists
            Assert.AreEqual(APayment.PaymentAmount, TestData);
        }

        [TestMethod]
        public void PaymentDatePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            APayment.PaymentDate = TestData;
            //test to see that it exists
            Assert.AreEqual(APayment.PaymentDate, TestData);
        }

        [TestMethod]
        public void PaymentTypePropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //create some test data to assign to the property 
            string TestData = "SS";
            //assign the data to the property
            APayment.PaymentType = TestData;
            //test to see that it exists
            Assert.AreEqual(APayment.PaymentType, TestData);
        }
        //[TestMethod]                  //not working
        //public void Valid()
        //{
        //    //create an instance of the class we want to create 
        //    clsPayment APayment = new clsPayment();
        //    //test to see if valid method exists 
        //    APayment.Valid("s");
        //}
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment(); 
            //bool var to store the results of the validation
            Boolean Found = false;
            //some test data to use with the method
            Int32 PaymentID = 2;
            //invoke the method
            Found = APayment.Find(PaymentID);
            //test to see if valid method exists 
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestPaymentIDFound()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //bool var to store the results of the validation
            Boolean Found = false;
            //Bool var to record if data isOK 
            Boolean OK = true;
            //some test data to use with the method
            Int32 PaymentID = 2;
            //invoke the method
            Found = APayment.Find(PaymentID);
            //check the hotel name 
            if (APayment.PaymentID != 2)
            {
                OK = false;
            }
            //test to see if valid method exists 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //bool var to store the results of the validation
            Boolean Found = false;
            //Bool var to record if data isOK 
            Boolean OK = true;
            //some test data to use with the method
            Int32 PaymentID = 2;
            //invoke the method
            Found = APayment.Find(PaymentID);
            //check the hotel name 
            if (APayment.CustomerID != 1)
            {
                OK = false;
            }
            //test to see if valid method exists 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentAmountFound()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //bool var to store the results of the validation
            Boolean Found = false;
            //Bool var to record if data isOK 
            Boolean OK = true;
            //some test data to use with the method
            Int32 PaymentID = 2;
            //invoke the method
            Found = APayment.Find(PaymentID);
            //check the hotel name 
            if (APayment.PaymentAmount != 160)
            {
                OK = false;
            }
            //test to see if valid method exists 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentDateFound()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //bool var to store the results of the validation
            Boolean Found = false;
            //Bool var to record if data isOK 
            Boolean OK = true;
            //some test data to use with the method
            Int32 PaymentID = 2;
            //invoke the method
            Found = APayment.Find(PaymentID);
            //check the hotel name 
            if (APayment.PaymentDate != Convert.ToDateTime("04/03/2021"))
            {
                OK = false;
            }
            //test to see if valid method exists 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentTypeFound()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //bool var to store the results of the validation
            Boolean Found = false;
            //Bool var to record if data isOK 
            Boolean OK = true;
            //some test data to use with the method
            Int32 PaymentID = 2;
            //invoke the method
            Found = APayment.Find(PaymentID);
            //check the hotel name 
            if (APayment.PaymentType != "Card")
            {
                OK = false;
            }
            //test to see if valid method exists 
            Assert.IsTrue(OK);
        }
    }
}
