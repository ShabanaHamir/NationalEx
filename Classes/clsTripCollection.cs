using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Classes
{
    public class clsTripCollection
    {
        //private data memeber for list method
        List<clsTrip> mTripList = new List<clsTrip>();
        clsTrip mThisTrip = new clsTrip();
        public List<clsTrip> TripList
        {
            get
            {
                //return the private data
                return mTripList;
            }
            set
            {
                mTripList = value;
            }
        }
        //    }
        // public property for count
        //public int Count
        //{
        //    get
        //    {
        //        //return the count of the list 
        //        return mTripList.Count;
        //    }

        //}

        public clsTrip ThisTrip
        {
            get
            {
                //return priv data
                return mThisTrip;
            }

            set
            {
                //set priv data
                mThisTrip = value;
            }
        }

        public int Count
        {
            get
            {
                return mTripList.Count;
            }
            set
            {
                //
            }
        }

        public clsTripCollection()

        {

            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute sproc
            DB.Execute("sproc_tblTrip_SelectAll");
            //populate array list with data table
            PopulateArray(DB);


            ////var for the index 
            //Int32 Index = 0;
            ////variable to save the record count 
            //Int32 RecordCount = 0;
            ////Object for data connection 
            //clsDataConnection DB = new clsDataConnection();
            ////execute the procedure 
            //DB.Execute("sproc_tblTrip_SelectAll");
            //// the count of the records
            //RecordCount = DB.Count;
            ////while there are records tp process 
            //while (Index < RecordCount)
            //{
            //    clsTrip AnTrip = new clsTrip();
            //    //read the fields from the current record 
            //    AnTrip.TripID = Convert.ToInt32(DB.DataTable.Rows[Index]["TripID"]);
            //    AnTrip.TripDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["TripDate"]);
            //    AnTrip.TripDestination = Convert.ToString(DB.DataTable.Rows[Index]["TripDestination"]);
            //    AnTrip.VehicleType = Convert.ToString(DB.DataTable.Rows[Index]["VehicleType"]);
            //    AnTrip.TripSource = Convert.ToString(DB.DataTable.Rows[Index]["TripSource"]);
            //    AnTrip.TicketCost = Convert.ToDecimal(DB.DataTable.Rows[Index]["TicketCost"]);
            //    AnTrip.TripStartTime = Convert.ToDateTime(DB.DataTable.Rows[Index]["TripStartTime"]);
            //    AnTrip.TripEndTime = Convert.ToDateTime(DB.DataTable.Rows[Index]["TripEndTime"]);

            //    mTripList.Add(AnTrip);
            //    Index++;
            //}








        }

        public List<clsTrip> GetAllTrips()
        {
            List<clsTrip> TripList = new List<clsTrip>();

            // Create a new instance of clsDataConnection
            clsDataConnection DB = new clsDataConnection();
            try
            {
                DB.Execute("sproc_tblTrip_SelectAll");

                TripList.Clear();

                foreach (DataRow row in DB.DataTable.Rows)
                {
                    clsTrip trip = new clsTrip();

                    trip.TripID = Convert.ToInt32(row["TripID"]);
                    trip.TripDate = Convert.ToDateTime(row["TripDate"]);
                    trip.TripDestination = Convert.ToString(row["TripDestination"]);
                    trip.VehicleType = Convert.ToString(row["VehicleType"]);
                    trip.TripSource = Convert.ToString(row["TripSource"]);
                    trip.TicketCost = Convert.ToDecimal(row["TicketCost"]);
                    trip.TripStartTime = Convert.ToDateTime(row["TripStartTime"]);
                    trip.TripEndTime = Convert.ToDateTime(row["TripEndTime"]);

                    mTripList.Add(trip);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here or log the error
                // You may want to throw the exception to the calling code for handling
                throw ex;
            }

            return mTripList;
        }




        public int Add()
        {
            //add a new record to the database 
            //connect to the databse 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@TripDate", mThisTrip.TripDate);
            DB.AddParameter("@TripDestination", mThisTrip.TripDestination);
            DB.AddParameter("@VehicleType", mThisTrip.VehicleType);
            DB.AddParameter("@TripSource", mThisTrip.TripSource);
            DB.AddParameter("@TicketCost", mThisTrip.TicketCost);
            DB.AddParameter("@TripStartTime", mThisTrip.TripStartTime);
            DB.AddParameter("@TripEndTime", mThisTrip.TripEndTime);
            //run the query 
            return DB.Execute("sproc_tblTrip_Insert");
        }

        public void Delete()
        {
            //deletes the records pointed by this trip 
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@TripID", mThisTrip.TripID);
            //execute the stored procedure 
            DB.Execute("sproc_tblTrip_Delete");
        }


        public void Update()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@TripID", mThisTrip.TripID);
            DB.AddParameter("@TripDate", mThisTrip.TripDate);
            DB.AddParameter("@TripDestination", mThisTrip.TripDestination);
            DB.AddParameter("@VehicleType", mThisTrip.VehicleType);
            DB.AddParameter("@TripSource", mThisTrip.TripSource);
            DB.AddParameter("@TicketCost", mThisTrip.TicketCost);
            DB.AddParameter("@TripStartTime", mThisTrip.TripStartTime);
            DB.AddParameter("@TripEndTime", mThisTrip.TripEndTime);
            DB.Execute("sproc_tblTrip_Update");

        }

        public void ReportByTripDestination(string TripDestination)
        {
            clsDataConnection DB = new clsDataConnection();
            //send hotel name parameter to the fb
            DB.AddParameter("@TripDestination", TripDestination);
            //execute sproc
            DB.Execute("sproc_tblTrip_FilterByTripDestination");
            //populate array list with data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the param DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mTripList = new List<clsTrip>();
            //while there r records to process
            while (Index < RecordCount)
            {
                try
                {
                    //crete a blank address
                    clsTrip trip = new clsTrip();
                    trip.TripID = Convert.ToInt32(DB.DataTable.Rows[Index]["TripID"]);
                    trip.TripDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["TripDate"]);
                    trip.TripDestination = Convert.ToString(DB.DataTable.Rows[Index]["TripDestination"]);
                    trip.TripSource = Convert.ToString(DB.DataTable.Rows[Index]["TripSource"]);
                    trip.TicketCost = Convert.ToDecimal(DB.DataTable.Rows[Index]["TicketCost"]);
                    trip.TripStartTime = Convert.ToDateTime(DB.DataTable.Rows[Index]["TripStartTime"]);
                    trip.TripEndTime = Convert.ToDateTime(DB.DataTable.Rows[Index]["TripEndTime"]);
                    //add trip to the list 
                    mTripList.Add(trip);
                }
                catch (InvalidCastException ex)
                {
                    Console.WriteLine($"Error at index {Index}: {ex.Message}");
                    foreach (DataColumn column in DB.DataTable.Columns)
                    {
                        Console.WriteLine($"Column {column.ColumnName}: {DB.DataTable.Rows[Index][column.ColumnName]}");
                    }
                }



                ////add record to the private data member 
                //mTripList.Add(trip);
                //point at the next record 
                Index++;
            }
        }
        public clsTrip GetTripByID(int tripID)
        {
            clsDataConnection dataConnection = new clsDataConnection();
            // Retrieve the connection string from your clsDataConnection object
            string connectionString = dataConnection.GetConnectionString();

            // Set up the SQL command text
            string sql = "SELECT * FROM tblTrip WHERE TripID = @TripID";

            // Set up the SQL command and connection
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Add the parameter to the command
                    cmd.Parameters.AddWithValue("@TripID", tripID);

                    // Open the connection
                    conn.Open();

                    // Execute the command and get the results
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a new activity and populate it with the data from the reader
                            clsTrip trip = new clsTrip();
                            trip.TripID = (int)reader["TripID"];
                            trip.TripDestination = (string)reader["TripDestination"];
                            trip.TicketCost = (decimal)reader["TicketCost"];
                            // ... populate the rest of the activity fields ...

                            // Return the room
                            return trip;
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






