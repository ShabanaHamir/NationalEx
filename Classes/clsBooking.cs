using System;

namespace Classes
{
    public class clsBooking
    {
        //private memebr
        private Int32 mBookingID;
        private Int32 mUserID;
        private DateTime mBookingDate;
        private string mFirstName;
        private string mEMail;
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
        public DateTime BookingDate
        {
            get
            {
                return mBookingDate;
            }
            set
            {
                mBookingDate = value;
            }
        }
        public string PaymentType
        {
            get
            {
                return mPaymentType;
            }
            set
            {
                mPaymentType = value;
            }
        }

        public string BookingDetails
        {
            get
            {
                return mBookingDetails;
            }
            set
            {
                mBookingDetails = value;
            }
        }
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }
        public decimal TotalCost
        {
            get
            {
                return mTotalCost;
            }
            set
            {
                mTotalCost = value;
            }
        }

        public int UserID
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }
        }

        public string EMail
        {
            get
            {
                return mEMail;
            }
            set
            {
                mEMail = value;
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
                mPaymentType = Convert.ToString(db.DataTable.Rows[0]["PaymentType"]);
                mBookingDetails = Convert.ToString(db.DataTable.Rows[0]["BookingDetails"]);
                mFirstName = Convert.ToString(db.DataTable.Rows[0]["FirstName"]);
                mEMail = Convert.ToString(db.DataTable.Rows[0]["mEMail"]);
                mUserID = Convert.ToInt32(db.DataTable.Rows[0]["UserID"]);
                mTotalCost = Convert.ToDecimal(db.DataTable.Rows[0]["TotalCost"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                return false;
            }
        }

        public string Valid(string bookingDate, string paymentType, string bookingDetails, string eMail, string firstName, decimal totalCost)
        {
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(bookingDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }


            //if the AName is blank
            if (paymentType.Length == 0)
            {
                //record error
                Error = Error + "Payment Type may not be blank: ";
            }
            //if AName is over max
            if (paymentType.Length > 50)
            {
                Error = Error + "Payment Type is too long: ";
            }


            if (bookingDetails.Length == 0)
            {
                //record error
                Error = Error + "Details may not be blank: ";
            }
            //if AName is over max
            if (bookingDetails.Length > 500)
            {
                Error = Error + "Details are too long: ";
            }


            if (firstName.Length == 0)
            {
                //record error
                Error = Error + "First name may not be blank: ";
            }
            //if AName is over max
            if (firstName.Length > 50)
            {
                Error = Error + "First name is too long: ";
            }

            if (eMail.Length == 0)
            {
                //record error
                Error = Error + "Email may not be blank: ";
            }
            //if AName is over max
            if (eMail.Length > 50)
            {
                Error = Error + "Email is too long: ";
            }

            if (totalCost <= 0)
            {
                //error
                Error = Error + " Total cost cannot be less than or equal to zero... We aren't free!";
            }

            return Error;
        }

    }

}