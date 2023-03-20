using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Classes
{
    public class clsHotel
    {
        //private member
        private string mHotelName;
        //public property 
        public string HotelName 
        {
             get
            {
                return mHotelName;
            }
                set
            {
                mHotelName = value;
            } 
        }
       

        //private data member for the hotel id
        private Int32 mHotelID;
        //hotelid public property
        public int HotelID
        {
            get
            {
                //sends data out of the property
                return mHotelID;
            }
            set
            {
                //allows data into the property
                mHotelID = value;
            }
        }
        //private data member
        private string mHotelPostCode;

        public string HotelPostCode
        {
            get
            {
                //return the private data
                return mHotelPostCode;
            }
            set
            {
                //set the private data
                mHotelPostCode = value;
            }
        }
        //private data member 
        private Int32 mHotelPhoneNumber;
        public int HotelPhoneNumber 
        {
            get
            {
                //return the private data
                return mHotelPhoneNumber;
            }
            set
            {
                //set the private data
                mHotelPhoneNumber = value;
            }
        }

        public Boolean Valid(string Hotel)
        {
            //var to record any errors found in Hotel name assuming all is OK
            Boolean OK = true;
            //test to see if the hotel has zero characters
            if (Hotel.Length == 0)
            {
                //set OK to false
                OK = false;
            }
            //retur results of all tests
            return true;
        }

        public bool Find(int HotelID)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add parametetr for the HotelId to search for 
            DB.AddParameter("@HotelID", HotelID);
            //execute stored proc
            DB.Execute("[sproc_tblHotel_FilterByHotelId]");
            //if one record is found (either one or zero)
            if (DB.Count == 1)
            {
                //copy data from the db to the private data memebers

                mHotelID = Convert.ToInt32(DB.DataTable.Rows[0]["HotelID"]);
                mHotelName = Convert.ToString(DB.DataTable.Rows[0]["HotelName"]);
                mHotelPostCode = Convert.ToString(DB.DataTable.Rows[0]["HotelPostCode"]);
                mHotelPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["HotelPhoneNumber"]);
                //return everything worked fine
                return true;
            }

            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
                }

            //    //set private data memebers to the test data value
            //    mHotelID = 3;
            //mHotelName = "TestHotelName";
            //mHotelPostCode = "XXX XXX";
            //mHotelPhoneNumber = 1234567891;
            ////always true
            //return true;




        }
    }
}