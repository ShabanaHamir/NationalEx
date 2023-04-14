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

        public bool Find(int RoomID)
        {


            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add parametetr for the HotelId to search for 
            DB.AddParameter("@RoomID", RoomID);
            //execute stored proc
            DB.Execute("[sproc_tblRoom_FilterByRoomId]");
            //if one record is found (either one or zero)
            if (DB.Count == 1)
            {
                //copy data from the db to the private data memebers

                mRoomID = Convert.ToInt32(DB.DataTable.Rows[0]["RoomID"]);
                mRoomNumber = Convert.ToInt32(DB.DataTable.Rows[0]["RoomNumber"]);
                mRoomType = Convert.ToString(DB.DataTable.Rows[0]["RoomType"]);
                mHotelID = Convert.ToInt32(DB.DataTable.Rows[0]["HotelID"]);
                //return everything worked fine
                return true;
            }

            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
         
        }

        public string Valid(string hotelID, string roomNumber, string roomType)
        {
            return "";
        }
    }
}