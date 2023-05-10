using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstUser
    {
        //good test data
        int UserID = 1;
        string FirstName = "Sara";
        string LastName = "Trial";
        string Email = "trial@gmail.com";
        string Password = "Password55";
        string AccountType = "customer";
        string TempPW = "";

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
        public void FirstNamePropertyOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //some test data 
            string TestData = "Jake";
            //assign data to property
            AUser.FirstName = TestData;
            //test it to see it exists
            Assert.AreEqual(AUser.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //some test data 
            string TestData = "Farah";
            //assign data to property
            AUser.LastName = TestData;
            //test it to see it exists
            Assert.AreEqual(AUser.LastName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //some test data 
            string TestData = "07547809434";
            //assign data to property
            AUser.Email = TestData;
            //test it to see it exists
            Assert.AreEqual(AUser.Email, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //some test data 
            string TestData = "j1@hotmail.com";
            //assign data to property
            AUser.Password = TestData;
            //test it to see it exists
            Assert.AreEqual(AUser.Password, TestData);
        }

        [TestMethod]
        public void AccountTyoePropertyOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //some test data 
            string TestData = "De-Montfort House, De Montfort University, The Gateway, Leicester LE1 9BH";
            //assign data to property
            AUser.AccountType = TestData;
            //test it to see it exists
            Assert.AreEqual(AUser.AccountType, TestData);
        }

        [TestMethod]
        public void TempPWBPropertyOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //some test data 
            string TestData = "10/03/1999";
            //assign data to property
            AUser.TempPW = TestData;
            //test it to see it exists
            Assert.AreEqual(AUser.TempPW, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //some test data 
            Boolean TestData = true;
            //assign data to property
            AUser.Active = TestData;
            //test it to see it exists
            Assert.AreEqual(AUser.Active, TestData);
        }

        [TestMethod]
        public void IsAdminPropertyOK()
        {
            //create an instance of the class
            clsUser AUser = new clsUser();
            //some test data 
            Boolean TestData = true;
            //assign data to property
            AUser.IsAdmin = TestData;
            //test it to see it exists
            Assert.AreEqual(AUser.IsAdmin, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create instance of class
            clsUser AUser = new clsUser();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //test data to use with the method               
            Int32 UserID = 1;
            //invoke the method
            Found = AUser.Find(UserID);
            //test to see if result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void UserIDFound()
        {
            //isntance of the class
            clsUser AUser = new clsUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 UserID = 1;
            //invoke the method
            Found = AUser.Find(UserID);
            //check activity name
            if (AUser.UserID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            //isntance of the class
            clsUser AUser = new clsUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 UserID = 1;
            //invoke the method
            Found = AUser.Find(UserID);
            //check activity name
            if (AUser.FirstName != "Sara")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            //isntance of the class
            clsUser AUser = new clsUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 UserID = 1;
            //invoke the method
            Found = AUser.Find(UserID);
            //check activity name
            if (AUser.LastName != "Trial")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //isntance of the class
            clsUser AUser = new clsUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 UserID = 1;
            //invoke the method
            Found = AUser.Find(UserID);
            //check activity name
            if (AUser.Email != "trial@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            //isntance of the class
            clsUser AUser = new clsUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 UserID = 1;
            //invoke the method
            Found = AUser.Find(UserID);
            //check activity name
            if (AUser.Password != "Password55")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAccountTypeFound()
        {
            //isntance of the class
            clsUser AUser = new clsUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 UserID = 1;
            //invoke the method
            Found = AUser.Find(UserID);
            //check activity name
            if (AUser.AccountType != "customer")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //isntance of the class
            clsUser AUser = new clsUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 UserID = 1;
            //invoke the method
            Found = AUser.Find(UserID);
            //check activity name
            if (AUser.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsAdminFound()
        {
            //isntance of the class
            clsUser AUser = new clsUser();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean to record if data is OK
            Boolean OK = true;
            //test data
            Int32 UserID = 1;
            //invoke the method
            Found = AUser.Find(UserID);
            //check activity name
            if (AUser.IsAdmin != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //string variable to store any error message
            String Error = "";
            //invoke method
            Error = AUser.Valid(FirstName, LastName, Email, Password, AccountType);
            //test to see the result is correct
            Assert.AreEqual(Error, "");
        }

    }
}
