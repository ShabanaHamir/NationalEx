using System;

namespace Classes
{
    public class clsCard
    {
        //private memebr
        private Int32 mCardID;
        private string mCardName;
        private string mCardNo;
        private string mExpiryDate;

        public string CardNo {
            get
            {
                return mCardNo;
            }
            set
            {
                mCardNo = value;
            }
        }
        public string ExpiryDate {
            get
            {
                return mExpiryDate;
            }
            set
            {
                mExpiryDate = value;
            }
        }
        public string CardName
        {
            get
            {
                return mCardName;
            }
            set
            {
                mCardName = value;
            }
        }
        public int CardID {
            get
            {
                return mCardID;
            }
            set
            {
                mCardID = value;
            }
        }
        

        public bool Find(int CardID) 
        {
            //create an instance of the data connection
            clsDataConnection db = new clsDataConnection();
            //add parameter
            db.AddParameter("@CardID", CardID);
            //execute sproc
            db.Execute("sproc_tblCard_FilterByCardID");
            if (db.Count == 1)
            {
                //data memebers to the test data value
                mCardID = Convert.ToInt32(db.DataTable.Rows[0]["CardID"]);
                mCardName = Convert.ToString(db.DataTable.Rows[0]["CardName"]); 
                mCardNo = Convert.ToString(db.DataTable.Rows[0]["CardNo"]); 
                mExpiryDate= Convert.ToString(db.DataTable.Rows[0]["ExpiryDate"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                return false;
            }
        }

        public string Valid(string cardName, string cardNo, string expiryDate)
        {
            return "";
        }
    }
}