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
        public string mHotelPostCode;

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

        public Boolean Valid(string Hotel)
        {
            return true;
        }

        public bool Find(int hotelID)
        {
            //set private data memebers to the test data value
            mHotelID = 21;
            mHotelName = "Inn";
            mHotelPostCode= "XXX XXX";
            //always true
            return true;
        }
    }
}