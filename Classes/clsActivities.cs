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
        private Int32 mActivityID;
        private string mActivityAddress;
        private string mActivityDescription;
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
        public string ActivityDescription {
            get
            {
                //return priv data
                return mActivityDescription;
            }
            set
            {
                //set priv data
                mActivityDescription = value;
            }
        }
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

        public int ActivityID
        {
            get
            {
                //return priv data
                return mActivityID;
            }
            set
            {
                //set priv data
                mActivityID = value;
            }
        }

        public string ActivityAddress {
            get
            {
                //return priv data
                return mActivityAddress;
            }
            set
            {
                //set priv data
                mActivityAddress = value;
            }
        }

        public bool Find(int ActivityID)
        {
            //create an instance of the data connection
            clsDataConnection db = new clsDataConnection();
            //add parameter
            db.AddParameter("@ActivityID", ActivityID);
            //execute sproc
            db.Execute("sproc_tblActivities_FilterByActivityID");
             if (db.Count == 1)
            {
                //copy the data from the db tp the private data members
                mActivityName = Convert.ToString(db.DataTable.Rows [0] ["ActivityName"]);
                mActivityAddress = Convert.ToString(db.DataTable.Rows[0]["ActivityAddress"]);
                mActivityCity = Convert.ToString(db.DataTable.Rows[0]["ActivityCity"]);
                mActivityPrice = Convert.ToDecimal(db.DataTable.Rows[0] ["ActivityPrice"]);
                mActivityPostCode = Convert.ToString(db.DataTable.Rows[0]["ActivityPostCode"]);
                mActivityID = Convert.ToInt32(db.DataTable.Rows[0]["ActivityID"]);
                mActivityDescription = Convert.ToString(db.DataTable.Rows[0]["ActivityDescription"]);
                //return true
                return true;
            }
             //if no record was found
             else
            {
                return false;
            }
        }

        public string Valid(Action activityNameOK, Action activityCityOK, Action activityAddressOK, Action activityDescriptionOK, Action activityPostCodeOK, Action activityPriceOK)
        {
            return "";
        }
    }
}