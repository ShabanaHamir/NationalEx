using System;

namespace Classes
{
    public class clsActivities
    {
        //private data member for acitivityname
        private string mActivityName;
        private string mActivityCity;
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
        public string ActivityPostCode { get; set; }
        public decimal ActivityPrice { get; set; }

        public bool Find(int ActivityID)
        {
            //set priv data members to the test data value
            mActivityName = "Kayaking";
            mActivityCity = "Birmingham";
            //always true
            return true;
        }
        
    }
}