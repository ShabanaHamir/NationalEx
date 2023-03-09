using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //test it to see it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 3;
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void CustomerFNameOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //assign test data
            string TestData = "Shabana";
            //assign data to property
            ACustomer.CustomerFName = TestData;
            //test to see the two values are the same
            Assert.AreEqual(ACustomer.CustomerFName, TestData);
        }

        [TestMethod]
        public void CustomerLNameOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //assign test data
            string TestData = "Shabana";
            //assign data to property
            ACustomer.CustomerLName = TestData;
            //test to see the two values are the same
            Assert.AreEqual(ACustomer.CustomerLName, TestData);
        }

        [TestMethod]
        public void CustomerDOBOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //assign test data
            DateTime TestData = DateTime.Now.Date;
            //assign data to property
            ACustomer.CustomerDOB = TestData;
            //test to see the two values are the same
            Assert.AreEqual(ACustomer.CustomerDOB, TestData);
        }

        [TestMethod]
        public void CustomerAddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "23 Rock Road";
            //assign the data to the property
            ACustomer.CustomerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }

        [TestMethod]
        public void CustomerPostCodeOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE6 4ER";
            //assign the data to the property
            ACustomer.CustomerPostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerPostCode, TestData);
        }

        [TestMethod]
        public void CustomerEmailOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Liam@hotmail.com";
            //assign the data to the property
            ACustomer.CustomerEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create instance of class
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //test data to use with the method               
            Int32 CustomerID = 2618936;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see if result is true
            Assert.IsTrue(Found);
        }
    }
}
