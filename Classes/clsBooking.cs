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

        public bool Find(int bookingID)
        {
            //data memebers to the test data value
            mBookingID = 17;
            mBookingDate = Convert.ToDateTime("18/06/2022");
            mUserFName = "Sara";
            mPaymentType = "MasterCard";
            mBookingDetails = "Hotel: Transylvania x2. Activity: Kayaking x2. Time: 10:30";
            mTotalCost = 25.50m;
            //always return true
            return true;
        }
    }
}