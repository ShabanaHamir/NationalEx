using System;
using System.Collections.Generic;
using System.Data;

namespace Classes
{
    public class clsRoomCollection
    {
        List<clsRoom> mRoomList = new List<clsRoom>();
        clsRoom mThisRoom = new clsRoom();
        //constructor
        public clsRoomCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblRoom_SelectAll");
            PopulateArray(DB);
            //clsRoom TestItem = new clsRoom();
            //TestItem.RoomID = 1;
            //TestItem.HotelID = 1;
            //TestItem.RoomNumber = 47;
            //TestItem.FloorNumber = 4;
            //TestItem.RoomType = "Single";
            //TestItem.NumberOfBeds = 1;
            //TestItem.RoomPrice = 120;
            //TestItem.RoomDescription = "Modern Single Room with a Garden View";
            //TestItem.RoomFacilities = "TV, Wifi, Fridge, Coffe Machine";
            //TestItem.Occupied = false;
            //mThisRoom.Add(TestItem);
            ////add item to the list
            //TestItem = new clsRoom();
            //TestItem.RoomID = 2;
            //TestItem.HotelID = 1;
            //TestItem.RoomNumber = 21;
            //TestItem.FloorNumber = 2;
            //TestItem.RoomType = "Double";
            //TestItem.NumberOfBeds = 2;
            //TestItem.RoomPrice = 141;
            //TestItem.RoomDescription = "Modern";
            //TestItem.RoomFacilities = "TV, Free Wifi, Pets";
            //TestItem.Occupied = true;
            ////add item to test list
            //mThisRoom.Add(TestItem);

            //Int32 Index = 0;
            //Int32 RecordCount = 0;
            //clsDataConnection DB = new clsDataConnection();
            //DB.Execute("sproc_tblRoom_SelectAll");
            //RecordCount = DB.Count;
            //while (Index < RecordCount)
            //{
            //    clsRoom ARoom = new clsRoom();
            //    //read in the fields from the current record
            //    ARoom.RoomID= Convert.ToInt32(DB.DataTable.Rows[Index]["RoomID"]);
            //    ARoom.HotelID = Convert.ToInt32(DB.DataTable.Rows[Index]["HotelID"]);
            //    ARoom.RoomNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomNumber"]);
            //    ARoom.FloorNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["FloorNumber"]);
            //    ARoom.RoomType = Convert.ToString(DB.DataTable.Rows[Index]["RoomType"]);
            //    ARoom.NumberOfBeds = Convert.ToInt32(DB.DataTable.Rows[Index]["NumberOfBeds"]);
            //    ARoom.RoomPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["RoomPrice"]);
            //    ARoom.RoomDescription = Convert.ToString(DB.DataTable.Rows[Index]["RoomDescription"]);
            //    ARoom.RoomFacilities = Convert.ToString(DB.DataTable.Rows[Index]["RoomFacilities"]);
            //    ARoom.Occupied = Convert.ToBoolean(DB.DataTable.Rows[Index]["Occupied"]);
            //    //add record to private data member
            //    mRoomList.Add(ARoom);
            //    //point at the next record
            //    Index++;
            //}

        }

        public List<clsRoom> RoomList
        {
            get
            {
                return mRoomList;
            }
            set
            {
                mRoomList = value;
            }
        }

        public int Count
        {
            get
            {
                return mRoomList.Count;
            }
            set
            {
                //later
            }
        }
        public clsRoom ThisRoom
        {
            get
            {
                return mThisRoom;
            }
            set
            {
                mThisRoom = value;
            }
        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            //set parameters
            DB.AddParameter("@HotelID", mThisRoom.HotelID);
            DB.AddParameter("@HotelName", mThisRoom.HotelName);
            DB.AddParameter("@RoomNumber", mThisRoom.RoomNumber);
            DB.AddParameter("@FloorNumber", mThisRoom.FloorNumber);
            DB.AddParameter("@RoomType", mThisRoom.RoomType);
            DB.AddParameter("@NumberOfBeds", mThisRoom.NumberOfBeds);
            DB.AddParameter("@RoomPrice", mThisRoom.RoomPrice);
            DB.AddParameter("@RoomDescription", mThisRoom.RoomDescription);
            DB.AddParameter("@RoomFacilities", mThisRoom.RoomFacilities);
            DB.AddParameter("@Occupied", mThisRoom.Occupied);
            //execute
            return DB.Execute("sproc_tblRoom_Insert");
        }


        public void Delete()
        {
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@RoomID", mThisRoom.RoomID);
            DB.Execute("sproc_tblRoom_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            //set params for sproc
            DB.AddParameter("@RoomID", mThisRoom.RoomID);
            DB.AddParameter("@HotelID", mThisRoom.HotelID);
            DB.AddParameter("@HotelName", mThisRoom.HotelName);
            DB.AddParameter("@RoomNumber", mThisRoom.RoomNumber);
            DB.AddParameter("@FloorNumber", mThisRoom.FloorNumber);
            DB.AddParameter("@RoomType", mThisRoom.RoomType);
            DB.AddParameter("@NumberOfBeds", mThisRoom.NumberOfBeds);
            DB.AddParameter("@RoomPrice", mThisRoom.RoomPrice);
            DB.AddParameter("@RoomDescription", mThisRoom.RoomDescription);
            DB.AddParameter("@RoomFacilities", mThisRoom.RoomFacilities);
            DB.AddParameter("@Occupied", mThisRoom.Occupied);
            //execute
            DB.Execute("sproc_tblRoom_Update");

        }

        public List<clsRoom> GetAllRooms()
        {
            List<clsRoom> RoomList = new List<clsRoom>();

            //instance of db
            clsDataConnection DB = new clsDataConnection();

            try
            {
                //gett all rooms
                DB.Execute("sproc_tblRooms_SelectAll");

                //loop through each row in the returned data table
                foreach (DataRow row in DB.DataTable.Rows)
                {
                    clsRoom Room = new clsRoom();

                    //copy data from row 
                    Room.RoomID = Convert.ToInt32(row["RoomID"]);
                    Room.HotelID = Convert.ToInt32(row["HotelID"]);
                    Room.RoomNumber = Convert.ToInt32(row["RoomNumber"]);
                    Room.FloorNumber = Convert.ToInt32(row["FloorNumber"]);
                    Room.RoomType = Convert.ToString(row["RoomType"]);
                    Room.NumberOfBeds = Convert.ToInt32(row["NumberOfBeds"]);
                    Room.RoomPrice = Convert.ToDecimal(row["RoomPrice"]);
                    Room.RoomDescription = Convert.ToString(row["RoomDescription"]);
                    Room.RoomFacilities = Convert.ToString(row["RoomFacilities"]);
                    Room.Occupied = Convert.ToBoolean(row["Occupied"]);

                    //add to room list
                    RoomList.Add(Room);
                }

            }
            catch (Exception ex)
            {
                //return empty list if there is an exception
                return new List<clsRoom>();
            }

            return RoomList;

        }

        void PopulateArray(clsDataConnection DB)
        {
            // populates the array list based on the data table in the param DB
            // var for the index
            Int32 Index = 0;
            // var to store the record count
            Int32 RecordCount;
            // get the count of records
            RecordCount = DB.Count;
            // clear the private array list
            mRoomList = new List<clsRoom>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank address
                clsRoom ARoom = new clsRoom();
                ARoom.RoomID = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomID"]);
                ARoom.HotelID = Convert.ToInt32(DB.DataTable.Rows[Index]["HotelID"]);
                ARoom.HotelName = Convert.ToString(DB.DataTable.Rows[Index]["HotelName"]);
                ARoom.RoomNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomNumber"]);
                ARoom.FloorNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["FloorNumber"]);
                ARoom.RoomType = Convert.ToString(DB.DataTable.Rows[Index]["RoomType"]);
                ARoom.NumberOfBeds = Convert.ToInt32(DB.DataTable.Rows[Index]["NumberOfBeds"]);
                ARoom.RoomPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["RoomPrice"]);
                ARoom.RoomDescription = Convert.ToString(DB.DataTable.Rows[Index]["RoomDescription"]);
                ARoom.RoomFacilities = Convert.ToString(DB.DataTable.Rows[Index]["RoomFacilities"]);
                if (DBNull.Value.Equals(DB.DataTable.Rows[Index]["Occupied"]))
                {
                    ARoom.Occupied = false;
                }
                else
                {
                    ARoom.Occupied = Convert.ToBoolean(DB.DataTable.Rows[Index]["Occupied"]);
                }
                // add record to the private data member
                mRoomList.Add(ARoom);
                // point at the next record
                Index++;
            }
        }

        public void ReportByHotelName(string HotelName)
        {
            //CONNECT TO DB
            clsDataConnection DB = new clsDataConnection();
            //send hotelID parameter
            DB.AddParameter("@HotelName", HotelName);
            //execute
            DB.Execute("sproc_tblRoom_FilterByHotelName");
            //populate array 
            PopulateArray(DB);
        }

    }

}