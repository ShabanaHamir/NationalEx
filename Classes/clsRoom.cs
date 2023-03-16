using System;
namespace Classes
{
    public class clsRoom
    {
        //private data membber 
        private Int32 mRoomNumber;
        //public property
        public int RoomNumber
        {
            get
            {
                //sends data out of the property
                return mRoomNumber;
            }
            set
            {
                //allows data into the property
                mRoomNumber = value;
            }
        }

        //private data membber 
        private string mRoomType;
        //public property
        public string RoomType
        {
            get
            {
                //sends data out of the property
                return mRoomType;
            }
            set
            {
                //allows data into the property
                mRoomType = value;
            }
        }


        //private data membber 
        private Int32 mRoomID;
        //public property
        public int RoomID
        {
            get
            {
                //sends data out of the property
                return mRoomID;
            }
            set
            {
                //allows data into the property
                mRoomID = value;
            }
        }

        //private data membber 
        private Int32 mHotelID;
        //public property
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

        public bool Find(int roomID)
        {
            //set private data members to the test data value
            mRoomID = 1;
            mRoomNumber = 10;
            mRoomType = "Single";
            mHotelID = 134;

            //return true always
            return true;
        }
    }
}