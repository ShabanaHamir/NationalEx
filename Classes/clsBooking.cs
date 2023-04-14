using System;

namespace Classes
{
    public class clsBooking
    {
        //private memebr
        private Int32 mBookingID;
        private DateTime mBookingDate;
        private string mUserFName;
        private string mBookingDetails;
        private string mPaymentType;
        private decimal mTotalCost;
        //public property
        public int BookingID 
        {
            get
            {
                return mBookingID;
            }
            set
            {
                mBookingID = value;
            }
        }
        public DateTime BookingDate {
            get
            {
                return mBookingDate;
            }
            set
            {
                mBookingDate = value;
            }
        }
        public string PaymentType {
            get
            {
                return mPaymentType;
            }
            set
            {
                mPaymentType = value;
            }
        }
    
        public string BookingDetails {
            get
            {
                return mBookingDetails;
            }
            set
            {
              mBookingDetails   = value;
            }
        }
        public string UserFName {
            get
            {
                return mUserFName;
            }
            set
            {
                mUserFName = value;
            }
        }
        public decimal TotalCost {
            get
            {
                return mTotalCost;
            }
            set
            {
                mTotalCost = value;
            }
        }

        public bool Find(int BookingID)
        {
            //create an instance of the data connection
            clsDataConnection db = new clsDataConnection();
            //add parameter
            db.AddParameter("@BookingID", BookingID);
            //execute sproc
            db.Execute("sproc_tblBooking_FilterByBookingID");
            if (db.Count == 1)
            {
                //data memebers to the test data value
                mBookingID = Convert.ToInt32(db.DataTable.Rows[0]["BookingID"]);
                mBookingDate = Convert.ToDateTime(db.DataTable.Rows[0]["BookingDate"]); 
                mUserFName = Convert.ToString(db.DataTable.Rows[0]["UserFName"]);
                mPaymentType = Convert.ToString(db.DataTable.Rows[0]["PaymentType"]);
                mBookingDetails = Convert.ToString(db.DataTable.Rows[0]["BookingDetails"]); ;
                mTotalCost = Convert.ToDecimal(db.DataTable.Rows[0]["TotalCost"]); ;
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                return false;
            }
        }

        public string Valid(string bookingDate, string userFName, string paymentType1, string bookingDetails, string paymentType)
        {
            return "";
        }
    }
}