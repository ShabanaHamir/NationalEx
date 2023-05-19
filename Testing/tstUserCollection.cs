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

            TestItem.FirstName = "Shahd";
            TestItem.LastName = "Trial";
            TestItem.Email = "trial@gmail.com";
            TestItem.Password = "Clementine7";
            TestItem.AccountType = "customer";
            TestItem.TempPW = "";
            TestItem.Active = true;
            TestItem.IsAdmin = false;
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

            TestUser.FirstName = "Sara";
            TestUser.LastName = "Trial";
            TestUser.Email = "trial@gmail.com";
            TestUser.Password = "Password55";
            TestUser.AccountType = "customer";
            TestUser.TempPW = "";
            TestUser.Active = true;
            TestUser.IsAdmin = false;
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
            TestItem.UserID = 1;

            TestItem.FirstName = "Sara";
            TestItem.LastName = "Trial";
            TestItem.Email = "trial@gmail.com";
            TestItem.Password = "Password55";
            TestItem.AccountType = "customer";
            TestItem.TempPW = "";
            TestItem.Active = true;
            TestItem.IsAdmin = false;
            //add item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllUsers.UserList = TestList;
            //test tp see that the two values are the same
            Assert.AreEqual(AllUsers.UserList, TestList);
        }

        //[TestMethod]
        //public void TwoRecordsPresent()
        //{
        //    clsUserCollection AllUsers = new clsUserCollection();
        //    Assert.AreEqual(AllUsers.Count, 2);
        //}

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of the class
            clsUserCollection AllUsers = new clsUserCollection();
            //create item of test data
            clsUser TestItem = new clsUser();
            //var to store pk
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.UserID = 1;

            TestItem.FirstName = "Sara";
            TestItem.LastName = "Trial";
            TestItem.Email = "trial@gmail.com";
            TestItem.Password = "Password55";
            TestItem.AccountType = "customer";
            TestItem.TempPW = "";
            TestItem.Active = true;
            TestItem.IsAdmin = false;
            //set ThisActivity to test data
            AllUsers.ThisUser = TestItem;
            //add record
            PrimaryKey = AllUsers.Add();
            //set pk of test data
            TestItem.UserID = PrimaryKey;
            //find record
            AllUsers.ThisUser.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllUsers.ThisUser, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create instance of the class
            clsUserCollection AllUsers = new clsUserCollection();
            //create item of test data
            clsUser TestItem = new clsUser();
            //var to store pk
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.UserID = 1;

            TestItem.FirstName = "Sara";
            TestItem.LastName = "Trial";
            TestItem.Email = "trial@gmail.com";
            TestItem.Password = "Password55";
            TestItem.AccountType = "customer";
            TestItem.TempPW = "";
            TestItem.Active = true;
            TestItem.IsAdmin = false;
            //set ThisActivity to test data
            AllUsers.ThisUser = TestItem;
            //add record
            PrimaryKey = AllUsers.Add();
            //find record
            AllUsers.ThisUser.Find(PrimaryKey);
            //de;ete
            AllUsers.Delete();
            //find the record
            Boolean Found = AllUsers.ThisUser.Find(PrimaryKey);
            //test to see that the record wasnt found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance of the class
            clsUserCollection AllUsers = new clsUserCollection();
            //create item of test data
            clsUser TestItem = new clsUser();
            //var to store pk
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.UserID = 1;
            TestItem.FirstName = "Sara";
            TestItem.LastName = "Trial";
            TestItem.Email = "trial@gmail.com";
            TestItem.Password = "Password55";
            TestItem.AccountType = "customer";
            //     TestItem.TempPW = "";
            TestItem.Active = true;
            TestItem.IsAdmin = false;
            //set ThisActivity to test data
            AllUsers.ThisUser = TestItem;
            //add record
            PrimaryKey = AllUsers.Add();
            //set the pk of the testdata
            TestItem.UserID = PrimaryKey;
            //modify test data
            TestItem.FirstName = "Sarah";
            TestItem.LastName = "Trials";
            TestItem.Email = "trials@ne.uk";
            TestItem.Password = "Password555";
            TestItem.AccountType = "admin";
            //     TestItem.TempPW = "";
            TestItem.Active = true;
            TestItem.IsAdmin = true;
            //set record based on new test data
            AllUsers.ThisUser = TestItem;
            //update record
            AllUsers.Update();
            //find record
            AllUsers.ThisUser.Find(PrimaryKey);
            //test to see that this activity matches the test data
            Assert.AreEqual(AllUsers.ThisUser, TestItem);
        }

        [TestMethod]
        public void ReportByUserNameMethodOK()
        {
            clsUserCollection AllUsers = new clsUserCollection();
            //create an instance of the class we want to create
            clsUserCollection FilteredUser = new clsUserCollection();
            //apply blank string (should return all records)
            FilteredUser.ReportByUserName("");
            //test to see that 2 values are the same
            Assert.AreEqual(AllUsers.Count, FilteredUser.Count);

        }

        [TestMethod]
        public void ReportByUserNameNoneFound()
        {
            //create an instance of the class we want to create
            clsUserCollection FilteredUser = new clsUserCollection();
            //apply blank string that doesnt exist
            FilteredUser.ReportByUserName("xxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredUser.Count);
        }

        [TestMethod]
        public void ReportByUserNameTestDataFound()
        {
            //create an instance of the class we want to createh
            clsUserCollection FilteredUser = new clsUserCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a city that doesnt exist
            FilteredUser.ReportByUserName("Platypus");
            //check that the correct number of records found
            if (FilteredUser.Count == 2)
            {
                if (FilteredUser.UserList[0].UserID != 3)
                {
                    OK = false;
                }
                if (FilteredUser.UserList[1].UserID != 18)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see there are no records
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ReportByFirstNameAndAccountTypeTestDataFound()
        {
            //create an instance of the class we want to create
            clsUserCollection FilteredUsers = new clsUserCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that exists in your database and account type
            FilteredUsers.ReportByFirstNameAndAccountType("Tarte", "Customer"); // Here, add the second parameter, which is the account type
                                                                               //check that the correct number of records are found
            if (FilteredUsers.Count == 2)
            {
                if (FilteredUsers.UserList[0].UserID != 10)
                {
                    OK = false;
                }
                if (FilteredUsers.UserList[1].UserID != 86)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see if the users are correctly filtered
            Assert.IsTrue(OK);
        }
    }
}
