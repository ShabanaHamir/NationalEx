using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Classes
{
    public class clsBookingCollection
    {
        //private data member for list
        List<clsBooking> mBookingList = new List<clsBooking>();
        //private data member for thisActivity
        clsBooking mThisBooking = new clsBooking();
        public clsBookingCollection()
        {

            //object for data connection
            clsDataConnection db = new clsDataConnection();
            // Use the instance to get the connection string
            string connectionString = db.GetConnectionString();
            //execute sproc
            db.Execute("sproc_tblBooking_SelectAll");
            //populate array
            PopulateArray(db);
        }

        public List<clsBooking> BookingList
        {
            get
            {
                //return private data
                return mBookingList;
            }
            set
            {
                //set provate data
                mBookingList = value;
            }
        }

        public List<clsBooking> GetAllBookings()
        {
            // Create a new list to store the activities
            List<clsBooking> bookingList = new List<clsBooking>();

            // Create an instance of the data connection
            clsDataConnection db = new clsDataConnection();

            try
            {
                // Execute the stored procedure to get all activities
                db.Execute("sproc_tblBooking_SelectAll");

                // Loop through each row in the returned data table
                foreach (DataRow row in db.DataTable.Rows)
                {
                    // Create a new instance of the clsActivities class
                    clsBooking booking = new clsBooking();

                    // Copy the data from the row to the activity object
                    booking.BookingID = Convert.ToInt32(row["BookingID"]);
                    booking.BookingDate = Convert.ToDateTime(row["BookingDate"]);
                    booking.PaymentType = Convert.ToString(row["PaymentType"]);
                    booking.BookingDetails = Convert.ToString(row["BookingDetails"]);
                    booking.FirstName = Convert.ToString(row["FirstName"]);
                    booking.UserID = Convert.ToInt32(row["UserID"]);
                    booking.TotalCost = Convert.ToInt32(row["TotalCost"]);
                    // Add the activity object to the activities list
                    bookingList.Add(booking);
                }
            }
            catch (Exception ex)
            {
                // Log the error message (optional)
                // Return an empty list if there is an exception
                return new List<clsBooking>();
            }

            // Return the list of activities
            return bookingList;
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mBookingList.Count;
            }
            set
            {
                //
            }
        }
        public clsBooking ThisBooking
        {
            get
            {
                //get priv data
                return mThisBooking;
            }
            set
            {
                //set priv data
                mThisBooking = value;
            }
        }

        public int Add()
        {
            clsDataConnection db = new clsDataConnection();
            //set thee parameters for sproc
            db.AddParameter("@BookingDate", mThisBooking.BookingDate);
            db.AddParameter("@PaymentType", mThisBooking.PaymentType);
            db.AddParameter("@BookingDetails", mThisBooking.BookingDetails);
            db.AddParameter("@FirstName", mThisBooking.FirstName);
            db.AddParameter("@UserID", mThisBooking.UserID);
            db.AddParameter("@TotalCost", mThisBooking.TotalCost); 
            //execute sproc returning the pk value
            return db.Execute("sproc_tblBooking_Insert");
        }

        public void Delete()
        {
            //delete activities pointed to by ThisActivity]
            //connect to db
            clsDataConnection db = new clsDataConnection();
            //set parameter
            db.AddParameter("BookingID", mThisBooking.BookingID);
            //execute sproc
            db.Execute("sproc_tblBooking_Delete");
        }

        public void Update()
        {
            //update exisiting records
            clsDataConnection db = new clsDataConnection();
            //set parameters
            db.AddParameter("@BookingID", mThisBooking.BookingID);
            db.AddParameter("@BookingDate", mThisBooking.BookingDate);
            db.AddParameter("@PaymentType", mThisBooking.PaymentType);
            db.AddParameter("@BookingDetails", mThisBooking.BookingDetails);
            db.AddParameter("@FirstName", mThisBooking.FirstName);
            db.AddParameter("@UserID", mThisBooking.UserID);
            db.AddParameter("@TotalCost", mThisBooking.TotalCost);
            //execute sproc
            db.Execute("sproc_tblBooking_Update");
        }

        void PopulateArray(clsDataConnection db)
        {
            //var for index 
            Int32 Index = 0;
            //var to store record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = db.Count;
            //clear the private array list
            mBookingList = new List<clsBooking>();
            //WHILE THERE ARE RECORDS TO PROCESS
            while (Index < RecordCount)
            {
                //create a blank staff
                clsBooking ABooking = new clsBooking();
                //read in the fields from the cyurrent record
                ABooking.BookingID = Convert.ToInt32(db.DataTable.Rows[Index]["BookingID"]);
                ABooking.BookingDate = Convert.ToDateTime(db.DataTable.Rows[Index]["BookingDate"]);
                ABooking.PaymentType = Convert.ToString(db.DataTable.Rows[Index]["PaymentType"]);
                ABooking.BookingDetails = Convert.ToString(db.DataTable.Rows[Index]["BookingDetails"]);
                ABooking.FirstName = Convert.ToString(db.DataTable.Rows[Index]["FirstName"]);
                ABooking.UserID = Convert.ToInt32(db.DataTable.Rows[Index]["UserID"]);
                ABooking.TotalCost = Convert.ToInt32(db.DataTable.Rows[Index]["TotalCost"]);                  
                //add the record to the private member
                mBookingList.Add(ABooking);
                //point to next record
                Index++;
            }

        }
    }
}
