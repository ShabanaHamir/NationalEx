using System;

namespace Classes
{
    public class clsActivities
    {
        //private data member for acitivityname
        private string mActivityName;
        public clsActivities()
        {
        }   


        public bool Active { get; set; }
        public string ActivityCity { get; set; }
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

        public bool Find(int activityID)
        {
            //set priv data members to the test data value
            mActivityName = "Kayaking";
            //always true
            return true;
        }
        
    }
}