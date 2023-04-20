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
        //private data membber 
        private Decimal mRoomPrice;
        public decimal RoomPrice
        {
            get
            {
                //sends data out of the property
                return mRoomPrice;
            }
            set
            {
                //allows data into the property
                mRoomPrice = value;
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
                mRoomPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["RoomPrice"]);
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

        public string Valid(string hotelID, string roomNumber, string roomType, decimal roomPrice)
        {
            //variable to store error
            String Error = "";
            //if room no is blank 
            if (roomNumber.Length == 0)
            {
                //error
                Error = Error + " Room Number cannot be left blank ! ";
            }
            //room number more than 10 characters
            if(roomNumber.Length > 10)
            {
                //error
                Error = Error + "Room Number cannot be more than 10 characters ! ";
            }


            ////if price is blank 
            //if (roomPrice.ToString().Length == 0)
            //{
            //    //error
            //    Error = Error + " Room Price cannot be left blank ! ";
            //}
            ////room price more than 10 characters
            //if (roomPrice.ToString().Length > 10)
            //{
            //    //error
            //    Error = Error + "Room Price cannot be more than 10 characters ! ";
            //}

            //if price is less than or equal to zero
            if (roomPrice <= 0)
            {
                //error
                Error = Error + " Room Price cannot be less than or equal to zero! ";
            }

            //if hotel id is blank 
            if (hotelID.Length == 0)
            {
                //error
                Error = Error + " Hotel ID cannot be left blank ! ";
            }
            //if room type is blank 
            if (roomType.Length == 0)
            {
                //error
                Error = Error + " Room Type cannot be left blank ! ";
            }
            //room type more than 10 characters
            if (roomType.Length > 30)
            {
                //error
                Error = Error + "Room Price cannot be more than 50 characters ! ";
            }


                return Error;
        }
    }
}