﻿using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing
{

    [TestClass]
    public class tstHotel
    { //test
        //good test data
        //create some test data to pass to the method

        //string HotelID = "";
        string HotelName = "Inn";
        string HotelCity = "Leicester";
        string HotelPhoneNumber = "01234567891";
        string HotelPostCode = "XXX XXX";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //test to see that it exists
            Assert.IsNotNull(AnHotel);
        }

        [TestMethod]
        public void HotelIDPropertyOK()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //create some test data to assign to the property 
            Int32 TestData = 3;
            //assign the data to the property
            AnHotel.HotelID = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHotel.HotelID, TestData);
        }

        [TestMethod]
        public void HotelNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //create some test data to assign to the property 
            string TestData = "TestHotelName";
            //assign the data to the property
            AnHotel.HotelName = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHotel.HotelName, TestData);
        }
        [TestMethod]
        public void HotelCityPropertyOK()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //create some test data to assign to the property 
            string TestData = "TestHotelCity";
            //assign the data to the property
            AnHotel.HotelCity = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHotel.HotelCity, TestData);
        }
        [TestMethod]
        public void HotelPostCodePropertyOK()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //create some test data to assign to the property 
            string TestData = "XXX XXX";
            //assign the data to the property
            AnHotel.HotelPostCode = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHotel.HotelPostCode, TestData);
        }

        [TestMethod]
        public void HotelPhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //create some test data to assign to the property 
            string TestData = "1234567891";
            //assign the data to the property
            AnHotel.HotelPhoneNumber = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHotel.HotelPhoneNumber, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //bool var to store the results of the validation
            Boolean Found = false;
            //some test data to use with the method
            Int32 HotelID = 3;
            //invoke the method
            Found = AnHotel.Find(HotelID);
            //test to see if valid method exists 
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestHotelIDFound()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //bool var to store the results of the validation
            Boolean Found = false;
            //Bool var to record if data isOK 
            Boolean OK = true;
            //some test data to use with the method
            Int32 HotelID = 3;
            //invoke the method
            Found = AnHotel.Find(HotelID);
            //check the hotel name 
            if (AnHotel.HotelID != 3)
            {
                OK = false;
            }
            //test to see if valid method exists 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHotelNameFound()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //bool var to store the results of the validation
            Boolean Found = false;
            //Bool var to record if data isOK 
            Boolean OK = true;
            //some test data to use with the method
            Int32 HotelID = 3;
            //invoke the method
            Found = AnHotel.Find(HotelID);
            //check the hotel name 
            if (AnHotel.HotelName != "Bristol Treat")
            {
                OK = false;
            }
            //test to see if valid method exists 
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestHotelCityFound()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //bool var to store the results of the validation
            Boolean Found = false;
            //Bool var to record if data isOK 
            Boolean OK = true;
            //some test data to use with the method
            Int32 HotelID = 3;
            //invoke the method
            Found = AnHotel.Find(HotelID);
            //check the hotel name 
            if (AnHotel.HotelCity != "Bristol")
            {
                OK = false;
            }
            //test to see if valid method exists 
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestHotelPostCodeFound()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //bool var to store the results of the validation
            Boolean Found = false;
            //Bool var to record if data isOK 
            Boolean OK = true;
            //some test data to use with the method
            Int32 HotelID = 3;
            //invoke the method
            Found = AnHotel.Find(HotelID);
            //check the hotel name 
            if (AnHotel.HotelPostCode != "BS1 1AD")
            {
                OK = false;
            }
            //test to see if valid method exists 
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestHotelPhoneNumberFound()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //bool var to store the results of the validation
            Boolean Found = false;
            //Bool var to record if data isOK 
            Boolean OK = true;
            //some test data to use with the method
            Int32 HotelID = 3;
            //invoke the method
            Found = AnHotel.Find(HotelID);
            //check the hotel name 
            if (AnHotel.HotelPhoneNumber != "1234567891")
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
            clsHotel AnHotel = new clsHotel();
            //string var to store any error message
            String Error = "";
            //invoke method
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }
        //HotelName
        [TestMethod]
        public void HotelNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string HotelName = ""; //error
                                   //invoke method
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void HotelNameMin()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string HotelName = "aaa"; //error
                                      //invoke method
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HotelNameMax()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string HotelName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //no error
                                                                                     //invoke method
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HotelNameMid()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string HotelName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //no error
            //invoke method
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HotelNameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string HotelName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //fail
                                                                                      //invoke method
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }

        //HotelCity

        [TestMethod]
        public void HotelCityMinLessOne()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string HotelCity = ""; //error
                                   //invoke method
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }









        //HotelPostcode
        [TestMethod]
        public void HotelPostCodeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string HotelPostCode = "";
            //invoke method
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void HotelPostCodeMin()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string HotelPostCode = "L";
            //invoke method
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HotelPostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string HotelPostCode = "LLLLLLLLLL";
            //invoke method
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void HotelPostCodeMax()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string HotelPostCode = "LLLLLLLLL";
            //invoke method
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }
        //HotelPhoneNumber
        [TestMethod]
        public void HotelPhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string HotelPhoneNumber = "";
            //invoke method
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void HotelPhoneNumberMin()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string HotelPhoneNumber = "123456";
            //invoke method
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HotelPhoneNumberMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string HotelPhoneNumber = "123456789111";
            //invoke method
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //test to see if valid method exists 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void HotelPhoneNumberMax()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //string var to store any error message
            String Error = "";
            //some tests data to pass to the method
            string HotelPhoneNumber = "12345678911";
            //invoke method
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //test to see if valid method exists 
            Assert.AreEqual(Error, "");
        }
    }
}