using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//this class is shared among the system
namespace Testing
{
    [TestClass]
    public class tstPayment
    { 

        //good test data
        //create some test data to pass to the method
        string UserID = "23";
        decimal PaymentAmount = 100.00m;
        string PaymentDate = DateTime.Now.Date.ToString();
        string PaymentType = "Card";



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
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //create some test data to assign to the property 
            Int32 TestData = 2;
            //assign the data to the property
            APayment.UserID = TestData;
            //test to see that it exists
            Assert.AreEqual(APayment.UserID, TestData);
        }

        [TestMethod]
        public void PaymentAmountPropertyOK()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //create some test data to assign to the property 
            Decimal TestData = 160;
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
        [TestMethod]                 
        public void Valid()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //test to see if valid method exists 
            APayment.Valid("s");
        }
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
        public void TestUserIDFound()
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
            if (APayment.UserID != 5)
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
            if (APayment.PaymentAmount != 500m)
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
            if (APayment.PaymentType != "Paypal")
            {
                OK = false;
            }
            //test to see if valid method exists 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //string var to store any error message
            String Error = "";
            //invoke method
            Error = APayment.Valid(PaymentType, PaymentDate, PaymentAmount, UserID);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }
                                                                                      //paymentType
        [TestMethod]
        public void PaymentTypeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //string var to store any error message
            String Error = "";
            string PaymentType = "";
            //invoke method
            Error = APayment.Valid(PaymentType, PaymentDate, PaymentAmount, UserID);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentTypeMin()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //string var to store any error message
            String Error = "";
            string PaymentType = "card";
            //invoke method
            Error = APayment.Valid(PaymentType, PaymentDate, PaymentAmount, UserID);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentTypeMax()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //string var to store any error message
            String Error = "";
            string PaymentType = "HSBC Bank Transfer";
            //invoke method
            Error = APayment.Valid(PaymentType, PaymentDate, PaymentAmount, UserID);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }

        //UserID

        [TestMethod]
        public void UserIDMinLessOne()
        {
            //create an instance of the class we want to create 
            clsPayment APayment = new clsPayment();
            //string var to store any error message
            String Error = "";
            string UserID = "";
            //invoke method
            Error = APayment.Valid(PaymentType, PaymentDate, PaymentAmount, UserID);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }
    }
}
