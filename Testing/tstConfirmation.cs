using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//this class is shared among the system
namespace Testing
{
    [TestClass]
    public class tstConfirmation
    {

        //good test data
        //data to test that pass method
        string CustomerID = "2";
        string Email = "XXX@hotmail.com";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsConfirmation AConfirmation = new clsConfirmation();
            //test to see that it exists
            Assert.IsNotNull(AConfirmation);
        }
        [TestMethod]
        public void ConfirmationIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsConfirmation AConfirmation = new clsConfirmation();
            //create some test data to assign to the property 
            Int32 TestData = 2;
            //assign the data to the property
            AConfirmation.ConfirmationID = TestData;
            //test to see that it exists
            Assert.AreEqual(AConfirmation.ConfirmationID, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsConfirmation AConfirmation = new clsConfirmation();
            //create some test data to assign to the property 
            Int32 TestData = 2;
            //assign the data to the property
            AConfirmation.CustomerID = TestData;
            //test to see that it exists
            Assert.AreEqual(AConfirmation.CustomerID, TestData);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create 
            clsConfirmation AConfirmation = new clsConfirmation();
            //create some test data to assign to the property 
            string TestData = "XXXX@xxx.com";
            //assign the data to the property
            AConfirmation.Email= TestData;
            //test to see that it exists
            Assert.AreEqual(AConfirmation.Email, TestData);
        }
        [TestMethod]
        public void Valid()
        {
            //create an instance of the class we want to create 
            clsConfirmation AConfirmation = new clsConfirmation();
            //test to see if valid method exists 
            AConfirmation.Valid("XXXX@xxx.com");
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsConfirmation AConfirmation = new clsConfirmation();
            //bool var to store the results of the validation
            Boolean Found = false;
            //some test data to use with the method
            Int32 ConfirmationID = 2;
            //invoke the method
            Found = AConfirmation.Find(ConfirmationID);
            //test to see if valid method exists 
            Assert.IsTrue(Found);
        }

        //[TestMethod]
        //public void TestCustomerIDFound()
        //{
        //    //create an instance of the class we want to create 
        //    clsConfirmation AConfirmation = new clsConfirmation();
        //    //bool var to store the results of the validation
        //    Boolean Found = false;
        //    Boolean OK = true;
        //    //some test data to use with the method
        //    Int32 ConfirmationID = 2;
        //    //invoke the method
        //    Found = AConfirmation.Find(ConfirmationID);
        //    //check the hotel name 
        //    if (AConfirmation.ConfirmationID != 2)
        //    {
        //        OK = false;
        //    }
        //    //test to see if valid method exists 
        //    Assert.IsTrue(Found);
        //}

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsConfirmation AConfirmation = new clsConfirmation();
            //string var to store any error message
            String Error = "";
            //invoke method
            Error = AConfirmation.Valid(CustomerID, Email);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }

    }
}
