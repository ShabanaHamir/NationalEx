using System;

namespace Classes
{
    public class clsPayment
    {
        //private member
        private Int32 mPaymentID;
        //public property
        public int PaymentID
        {
            get
            {
                //sends data out of the property
                return mPaymentID;
            }
            set
            {
                //allows data into the property
                mPaymentID = value;
            }
        }
        //private member
        private Int32 mCustomerID;
        //public property
        public int CustomerID 
        {
            get
            {
                //sends data out of the property
                return mCustomerID;
            }
            set
            {
                //allows data into the property
                mCustomerID = value;
            }
        }

        //private member
        private Int32 mPaymentAmount;
        //public property
        public int PaymentAmount
        {
            get
            {
                //sends data out of the property
                return mPaymentAmount;
            }
            set
            {
                //allows data into the property
                mPaymentAmount = value;
            }
        }


        //private memeber
        private DateTime mPaymentDate;
        //public property
        public DateTime PaymentDate
        {
            get
            {
                //sends data out of the property
                return mPaymentDate;
            }
            set
            {
                //allows data into the property
                mPaymentDate = value;
            }
        }

        //private memeber
        private string mPaymentType;
        //public property
        public string PaymentType
        {
            get
            {
                //sends data out of the property
                return mPaymentType;
            }
            set
            {
                //allows data into the property
                mPaymentType = value;
            }
        }

        public Boolean Valid(string PaymentType)
        {
            Boolean OK = true;
            if(PaymentType.Length == 0)
            {
                OK = false;
            }
            return OK;
        }

        public bool Find(int paymentID)
        {
            mPaymentID = 2;
            mCustomerID = 1;
            mPaymentAmount = 160;
            mPaymentDate = Convert.ToDateTime ("04/ 03/2021");
            mPaymentType = "Card";

            //ALWAYS RETURN TRUE
            return true;
        }

        public string Valid(object paymentType, object paymentDate, object paymentAmoun, object customerID)
        {
            return "";
        }
    }
}