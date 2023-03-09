using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstUsers
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //test it to see it exists
            Assert.IsNotNull(AUser);
        }


        //[TestMethod]
        //public void UserIDPropertyOK()
        //{
        //    //create an instance of the class
        //    clsUser AUser = new clsUser();
        //    //some test data 
        //    Int32 TestData = 1;
        //    //assign data to property
        //    AUser.UserID = TestData;
        //    //test it to see it exists
        //    Assert.AreEqual(AUser.UserID, TestData);
        //}

        [TestMethod]
        public void UserFNamePropertyOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //some test data 
            string TestData = "Jake";
            //assign data to property
            AUser.UserFName = TestData;
            //test it to see it exists
            Assert.AreEqual(AUser.UserFName, TestData);
        }

        [TestMethod]
        public void UserLNamePropertyOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //some test data 
            string TestData = "Farah";
            //assign data to property
            AUser.UserLName = TestData;
            //test it to see it exists
            Assert.AreEqual(AUser.UserLName, TestData);
        }

        [TestMethod]
        public void UserContactNumberPropertyOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //some test data 
            string TestData = "07547809434";
            //assign data to property
            AUser.UserContactNumber = TestData;
            //test it to see it exists
            Assert.AreEqual(AUser.UserContactNumber, TestData);
        }

        [TestMethod]
        public void UserEmailPropertyOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //some test data 
            string TestData = "j1@hotmail.com";
            //assign data to property
            AUser.UserEmail = TestData;
            //test it to see it exists
            Assert.AreEqual(AUser.UserEmail, TestData);
        }

        [TestMethod]
        public void UserAddressPropertyOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //some test data 
            string TestData = "De-Montfort House, De Montfort University, The Gateway, Leicester LE1 9BH";
            //assign data to property
            AUser.UserAddress = TestData;
            //test it to see it exists
            Assert.AreEqual(AUser.UserAddress, TestData);
        }

        [TestMethod]
        public void UserDOBPropertyOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //some test data 
            string TestData = "10/03/1999";
            //assign data to property
            AUser.UserDOB = TestData;
            //test it to see it exists
            Assert.AreEqual(AUser.UserDOB, TestData);
        }

        [TestMethod]
        public void UserRolePropertyOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //some test data 
            string TestData = "Customer";
            //assign data to property
            AUser.UserRole = TestData;
            //test it to see it exists
            Assert.AreEqual(AUser.UserRole, TestData);
        }

    }
}
