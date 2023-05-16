using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


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

            // Create a new instance of clsDataConnection
            clsDataConnection DB = new clsDataConnection();
            try
            {
                DB.Execute("sproc_tblRoom_SelectAll");

                mRoomList.Clear();

                foreach (DataRow row in DB.DataTable.Rows)
                {
                    clsRoom room = new clsRoom();

                    room.RoomID = Convert.ToInt32(row["RoomId"]);
                    room.HotelID = Convert.ToInt32(row["HotelId"]);
                    room.HotelName = Convert.ToString(row["HotelName"]);
                    room.RoomNumber = Convert.ToInt32(row["RoomNumber"]);
                    room.FloorNumber = Convert.ToInt32(row["FloorNumber"]);
                    room.RoomType = Convert.ToString(row["RoomType"]);
                    room.NumberOfBeds = Convert.ToInt32(row["NumberOfBeds"]);
                    room.RoomPrice = Convert.ToDecimal(row["RoomPrice"]);
                    room.RoomDescription = Convert.ToString(row["RoomDescription"]);
                    room.RoomFacilities = Convert.ToString(row["RoomFacilities"]);
                    room.Occupied = Convert.IsDBNull(row["Occupied"]) ? false : Convert.ToBoolean(row["Occupied"]);

                    mRoomList.Add(room);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here or log the error
                // You may want to throw the exception to the calling code for handling
                throw ex;
            }

            return mRoomList;
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


        public clsRoom GetRoomByID(int roomID)
        {
            clsDataConnection dataConnection = new clsDataConnection();
            // Retrieve the connection string from your clsDataConnection object
            string connectionString = dataConnection.GetConnectionString();

            // Set up the SQL command text
            string sql = "SELECT * FROM tblRoom WHERE RoomID = @RoomID";

            // Set up the SQL command and connection
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Add the parameter to the command
                    cmd.Parameters.AddWithValue("@RoomID", roomID);

                    // Open the connection
                    conn.Open();

                    // Execute the command and get the results
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a new activity and populate it with the data from the reader
                            clsRoom room = new clsRoom();
                            room.RoomID = (int)reader["RoomID"];
                            room.RoomType = (string)reader["RoomType"];
                            room.RoomPrice = (decimal)reader["RoomPrice"];
                            // ... populate the rest of the activity fields ...

                            // Return the room
                            return room;
                        }
                        else
                        {
                            // If no room was found with the provided ID, return null
                            return null;
                        }
                    }
                }
            }
        }
    }

}