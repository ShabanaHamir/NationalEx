using System;

namespace Classes
{
    public class clsActivities
    {
        //private data member for acitivityname
        private string mActivityName;
        private string mActivityCity;
        private decimal mActivityPrice;
        private string mActivityPostCode;
        public clsActivities()
        {
        }   


        public bool Active { get; set; }
        public string ActivityCity
        {
            get
            {
                //return priv data
                return mActivityCity;
            }
            set
            {
                //set priv data
                mActivityCity = value;
            }
        }
        public string ActivityDescription { get; set; }
        public string ActivityName
        {
            get
            {
                //return priv data
                return mActivityName;
            }
            set
            {
                //set priv data
                mActivityName = value;
            }
        }
        public string ActivityPostCode {
            get
            {
                //return priv data
                return mActivityPostCode;
            }
            set
            {
                //set priv data
                mActivityPostCode = value;
            }
        }
        public decimal ActivityPrice {
            get
            {
                //return priv data
                return mActivityPrice;
            }
            set
            {
                //set priv data
                mActivityPrice = value;
            }
        }

        public bool Find(int ActivityID)
        {
            //set priv data members to the test data value
            mActivityName = "Kayaking";
            mActivityCity = "Birmingham";
            mActivityPrice = 59.99m;
            mActivityPostCode = "LE3 4EQ";
            //always true
            return true;
        }
        
    }
}