using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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
        private string mHotelName;
        //public property
        public string HotelName
        {
            get
            {
                //sends data out of the property
                return mHotelName;
            }
            set
            {
                //allows data into the property
                mHotelName = value;
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

        //private data member
        private Int32 mNumberOfBeds;
        public int NumberOfBeds
        {
            get
            {
                return mNumberOfBeds;
            }
            set
            {
                mNumberOfBeds = value;
            }
        }
        //private data 
        private string mRoomDescription;
        public string RoomDescription
        {
            get
            {
                return mRoomDescription;
            }
            set
            {
                mRoomDescription = value;
            }
        }

        //private data
        private string mRoomFacilities;
        public string RoomFacilities
        {
            get
            {
                return mRoomFacilities;
            }
            set
            {
                mRoomFacilities = value;
            }
        }

        //private data
        private Boolean mOccupied;
        public bool Occupied
        {
            get
            {
                return mOccupied;
            }
            set
            {
                mOccupied = value;
            }
        }

        private Int32 mFloorNumber;
        public int FloorNumber
        {
            get
            {
                return mFloorNumber;
            }
            set
            {
                mFloorNumber = value;
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
                mFloorNumber = Convert.ToInt32(DB.DataTable.Rows[0]["FloorNumber"]);
                mRoomNumber = Convert.ToInt32(DB.DataTable.Rows[0]["RoomNumber"]);
                mRoomType = Convert.ToString(DB.DataTable.Rows[0]["RoomType"]);
                mNumberOfBeds = Convert.ToInt32(DB.DataTable.Rows[0]["NumberOfBeds"]);
                mHotelID = Convert.ToInt32(DB.DataTable.Rows[0]["HotelID"]);
                mHotelName = Convert.ToString(DB.DataTable.Rows[0]["HotelName"]);
                mRoomPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["RoomPrice"]);
                mRoomDescription = Convert.ToString(DB.DataTable.Rows[0]["RoomDescription"]);
                mRoomFacilities = Convert.ToString(DB.DataTable.Rows[0]["RoomFacilities"]);
                mOccupied = Convert.ToBoolean(DB.DataTable.Rows[0]["Occupied"]);
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

        public string Valid(string hotelID, string hotelName, string floorNumber, string numberOfBeds, string roomNumber, string roomType, decimal roomPrice, string roomDescription, string roomFacilities)
        {
            //variable to store error
            String Error = "";

            //if hotel id is blank 
            if (hotelID.Length == 0)
            {
                //error
                Error = Error + " Hotel ID cannot be left blank ! ";
            }

            //if floor no is blank 
            if (floorNumber.Length == 0)
            {
                //error
                Error = Error + " Floor Number cannot be left blank ! ";
            }
            //floor number more than 10 characters
            if (floorNumber.Length > 4)
            {
                //error
                Error = Error + "Re-enter Floor Number please ! ";
            }

            //if floor no is blank 
            if (numberOfBeds.Length == 0)
            {
                //error
                Error = Error + " Number of beds cannot be left blank ! ";
            }
            // number of beds more than 10 characters
            if (numberOfBeds.Length > 15)
            {
                //error
                Error = Error + "Re-enter Number of Beds please ! ";
            }



            //if room no is blank 
            if (roomNumber.Length == 0)
            {
                //error
                Error = Error + " Room Number cannot be left blank ! ";
            }
            //room number more than 10 characters
            if (roomNumber.Length > 10)
            {
                //error
                Error = Error + "Room Number cannot be more than 10 characters ! ";
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

            //if room type is blank 
            if (hotelName.Length == 0)
            {
                //error
                Error = Error + " Hotel Name cannot be left blank ! ";
            }
            //room type more than 10 characters
            if (hotelName.Length > 30)
            {
                //error
                Error = Error + "Hotel Name cannot be more than 50 characters ! ";
            }
            //if price is less than or equal to zero
            if (roomPrice <= 0)
            {
                //error
                Error = Error + " Room Price cannot be less than or equal to zero! ";
            }


            //if room description is blank 
            if (roomDescription.Length == 0)
            {
                //error
                Error = Error + " Room Description cannot be left blank ! ";
            }
            //room description more than 250 characters
            if (roomDescription.Length > 250)
            {
                //error
                Error = Error + "Room Description cannot be this long ! ";
            }

            //if room Facilities is blank 
            if (roomFacilities.Length == 0)
            {
                //error
                Error = Error + " Room Facilities cannot be left blank ! ";
            }
            //room Facilities more than 250 characters
            if (roomFacilities.Length > 250)
            {
                //error
                Error = Error + "Room Facilities cannot be this long ! ";
            }


            return Error;
        }
    }
}