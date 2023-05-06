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
        private int mNoOfPeople;
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
        public string ActivityDescription
        {
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
        public string Valid(string activityName, string activityCity, string activityAddress, string activityDescription, string activityPostCode, decimal activityPrice, int noOfPeople)
        {
            String Error = "";
            //if the AName is blank
            if (activityName.Length == 0)
            {
                //record error
                Error = Error + "Activity name may not be blank: ";
            }
            //if AName is over max
            if (activityName.Length > 50)
            {
                Error = Error + "Activity name is too long: ";
            }

            //if the AName is blank
            if (activityCity.Length == 0)
            {
                //record error
                Error = Error + "Activity city may not be blank: ";
            }
            //if AName is over max
            if (activityCity.Length > 50)
            {
                Error = Error + "Activity city is too long: ";
            }

            //if the AName is blank
            if (activityPostCode.Length == 0)
            {
                //record error
                Error = Error + "Activity city may not be blank: ";
            }
            //if AName is over max
            if (activityPostCode.Length > 15)
            {
                Error = Error + "Activity city is too long: ";
            }

            //if the AName is blank
            if (activityAddress.Length == 0)
            {
                //record error
                Error = Error + "Activity address may not be blank: ";
            }
            //if AName is over max
            if (activityAddress.Length > 100)
            {
                Error = Error + "Activity address is too long: ";
            }

            //if the AName is blank
            if (activityDescription.Length == 0)
            {
                //record error
                Error = Error + "Activity description may not be blank: ";
            }
            //if AName is over max
            if (activityDescription.Length > 500)
            {
                Error = Error + "Activity description is too long: ";
            }

            ////if AName is over max
            //if (activityPrice == 0)
            //{
            //    throw new ArgumentException("Price cannot be zero! We aren't free: ", nameof(activityPrice));
            //    //Error = Error + "Activity price cant be empty! We aren't free: ";
            //}

            //if price is less than or equal to zero
            if (activityPrice <= 0)
            {
                //error
                Error = Error + " Activity price cannot be less than or equal to zero... We aren't free!";
            }

            // If noOfPeople is null
            if (noOfPeople == -1)
            {
                // Record error
                Error = Error + "Number of people cannot be null: ";
            }
            else
            {
                // If noOfPeople is greater than the maximum allowed
                if (noOfPeople > 100)
                {
                    // Record error
                    Error = Error + "Number of people cannot be more than 100: ";
                }
            }

            return Error;
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
        public string ActivityPostCode
        {
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
        public decimal ActivityPrice
        {
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

        public string ActivityAddress
        {
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

       
        public int NoOfPeople
        {
            get
            {
                return mNoOfPeople;
            }
            set
            {
                mNoOfPeople = value;
            }
        }

        public int Count { get; set; }

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
                mActivityID = Convert.ToInt32(db.DataTable.Rows[0]["ActivityID"]);
                mActivityName = Convert.ToString(db.DataTable.Rows[0]["ActivityName"]);
                mActivityCity = Convert.ToString(db.DataTable.Rows[0]["ActivityCity"]);
                mActivityAddress = Convert.ToString(db.DataTable.Rows[0]["ActivityAddress"]);
                mActivityPostCode = Convert.ToString(db.DataTable.Rows[0]["ActivityPostCode"]);
                mActivityDescription = Convert.ToString(db.DataTable.Rows[0]["ActivityDescription"]);
                mNoOfPeople = Convert.ToInt32(db.DataTable.Rows[0]["NoOfPeople"]);
                mActivityPrice = Convert.ToDecimal(db.DataTable.Rows[0]["ActivityPrice"]);
    
                //return true
                return true;
            }
            //if no record was found
            else
            {
                return false;
            }
        }




    }
}