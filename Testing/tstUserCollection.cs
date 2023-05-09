using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Classes;
using System.Collections.Generic;

namespace Testing
{
    [TestClass]
    public class tstUserCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsUserCollection AllUsers = new clsUserCollection();
            Assert.IsNotNull(AllUsers);
        }

        [TestMethod]
        public void UserListOK()
        {
            clsUserCollection AllUsers = new clsUserCollection();
            List<clsUser> TestList = new List<clsUser>();
            //add item to the list
            clsUser TestItem = new clsUser();
            //set its properties
            TestItem.Active = true;
            TestItem.FirstName = "Sara";
            TestItem.LastName = "Trial";
            TestItem.Email = "trial@gmail.com";
            TestItem.Password = "Password55";
            TestItem.AccountType = "customer";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign data
            AllUsers.UserList = TestList;
            Assert.AreEqual(AllUsers.UserList, TestList);
        }

        [TestMethod]
        public void ThisUserPropertyOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new clsUserCollection();
            //create test data to assign to the property
            clsUser TestUser = new clsUser();
            //set properties of test object
            TestUser.UserID = 1;
            TestUser.Active = true;
            TestUser.FirstName = "Sara";
            TestUser.LastName = "Trial";
            TestUser.Email = "trial@gmail.com";
            TestUser.Password = "Password55";
            TestUser.AccountType = "customer";
            //assign the data to the property
            AllUsers.ThisUser = TestUser;
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.ThisUser, TestUser);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsUserCollection AllUsers = new clsUserCollection();
            //create test data
            List<clsUser> TestList = new List<clsUser>();
            //add an item to the list
            clsUser TestItem = new clsUser();
            //set its properties
            TestItem.Active = true;
            TestItem.FirstName = "Sara";
            TestItem.LastName = "Trial";
            TestItem.Email = "trial@gmail.com";
            TestItem.Password = "Password55";
            TestItem.AccountType = "customer";
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllUsers.UserList = TestList;
            //test tp see that the two values are the same
            Assert.AreEqual(AllUsers.UserList, TestList);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsUserCollection AllUsers = new clsUserCollection();
            Assert.AreEqual(AllUsers.Count, 2);
        }
        
       

    }
}
