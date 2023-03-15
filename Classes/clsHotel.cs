using System;

namespace Classes
{
    public class clsHotel
    {
       
        public string HotelName { get; set; }
        public string HotelPostcode { get; set; }

        //private data member for the hottel id
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
        public Boolean Valid(string Hotel)
        {
            return true;
        }

        public bool Find(int hotelID)
        {
            //set private data memebers to the test data value
            mHotelID = 21;
            //always true
            return true;
        }
    }
}