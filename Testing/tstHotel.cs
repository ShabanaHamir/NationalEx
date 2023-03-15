﻿using Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing
{
    [TestClass]
    public class tstHotel
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //test to see that it exists
            Assert.IsNotNull(AnHotel);
        }


        [TestMethod]
        public void HotelNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //create some test data to assign to the property 
            string TestData = "shahd";
            //assign the data to the property
            AnHotel.HotelName = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHotel.HotelName, TestData);
        }

        [TestMethod]
        public void HotelPostcodePropertyOK()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //create some test data to assign to the property 
            string TestData = "LE1 4TY";
            //assign the data to the property
            AnHotel.HotelPostcode = TestData;
            //test to see that it exists
            Assert.AreEqual(AnHotel.HotelPostcode, TestData);
        }

        [TestMethod]
        public void Valid()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //test to see if valid method exists 
            AnHotel.Valid("Extreme");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsHotel AnHotel = new clsHotel();
            //bool var to store the results of the validation
            Boolean Found = false;
            //some test data to use with the method
            Int32 HotelID = 21;
            //invoke the method
           Found = AnHotel.Find(HotelID);                       //hotel id wala hotel name
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
            Int32 HotelID = 21;                                       
            //invoke the method
            Found = AnHotel.Find(HotelID);
            //check the hotel name 
            if (AnHotel.HotelID != 21)
            {
                OK = false;
            }
            //test to see if valid method exists 
            Assert.IsTrue(OK);
        }
    }
}