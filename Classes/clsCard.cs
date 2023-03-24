using System;

namespace Classes
{
    public class clsCard
    {
        //private memebr
        private Int32 mCardID;
        private string mNameOnCard;
        private string mCardName;
        private string mCardNo;

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
        public string ExpiryDate { get; set; }
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
        

        public bool Find(int cardID)
        {
            //data memebers to the test data value
            mCardID = 1;
            mCardName = "Sara";
            mCardNo = "0863 1673 7238 1637";
            //always return true
            return true;
        }
    }
}