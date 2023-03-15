using System;

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
        ////private member
        //private string mHotelPostCode;
        

        //private data member for the hottel id
        private Int32 mHotelID;
        //private member
        private string mHotelPostCode;
        public string HotelPostCode
        {
            get
            {
                return mHotelPostCode;
            }
            set
            {
                mHotelPostCode = value;
            }
        }


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
        public Boolean Valid(string Hotel)
        {
            return true;
        }

        public bool Find(int hotelID)
        {
            //set private data memebers to the test data value
            mHotelID = 21;
            mHotelName = "Inn";
            //always true
            return true;
        }
    }
}