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
        private Int32 mUserID;
        //public property
        public int UserID 
        {
            get
            {
                //sends data out of the property
                return mUserID;
            }
            set
            {
                //allows data into the property
                mUserID = value;
            }
        }

        //private member
        private Decimal mPaymentAmount;
        //public property
        public decimal PaymentAmount
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

        public bool Find(int PaymentID)
        {

            // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add parametetr for the HotelId to search for 
            DB.AddParameter("@PaymentID", PaymentID);
            //execute stored proc
            DB.Execute("[sproc_tblPayment_FilterByPaymentId]");
            //if one record is found (either one or zero)
            if (DB.Count == 1)
            {

                //copy data from database to the private data members

                mPaymentID = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentID"]);
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]); 
                mPaymentAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["PaymentAmount"]);
                mPaymentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["PaymentDate"]);
                mPaymentType = Convert.ToString(DB.DataTable.Rows[0]["PaymentType"]);

                //ALWAYS RETURN TRUE
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string paymentType, string paymentDate, decimal paymentAmount, string userID)
        {
            //string to store error
            String Error = "";
            //if payment type is empty
            if(paymentType.Length == 0)
            {
                //error
                Error = Error + "Payment Type cannot be left empty ! ";
            }

            if (paymentType.Length > 35)
            {
                //error
                Error = Error + "Re-enter Payment Type ! ";
            }


            //return error
            return Error;
        }
    }
}