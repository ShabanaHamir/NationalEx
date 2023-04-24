using System;

namespace Classes
{
    public class clsTrip
    {
        //create the trip ID private variable 
        private Int32 aTripID;
        //create tripID Public property 
        public Int32 TripID
        {
            get
            {
                //transfer data oyt of the property 
                return aTripID;
            }
            set
            {
                aTripID = value;
            }
        }
        //tripDate set to be private variable 
        private DateTime aTripDate;
        //trip date set to be public property 
        public DateTime TripDate
        {
            get
            {
                return aTripDate;
            }
            set
            {
                aTripDate = value;

            }
        }

        //tripDate set to be private variable 
        private string aTripDestination;
        //trip destination set it public 
        public string TripDestination
        {
            get
            {
                return aTripDestination;
            }
            set
            {
                aTripDestination = value;

            }
        }

        //tripDate set to be private variable 
        private string aVehicleType;
        //trip destination set it public 
        public string VehicleType
        {
            get
            {
                return aVehicleType;
            }
            set
            {
                aVehicleType = value;

            }
        }

        public bool Find(int TripID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the trip id to retrieve it 
            DB.AddParameter("@TripID", TripID);
            //execute the procedure that was created previously 
            DB.Execute("sproc_tblTrip_FilterByTripID");
            if(DB.Count == 1)
            {
                aTripID = Convert.ToInt32(DB.DataTable.Rows[0]["TripID"]);
                aTripDate = Convert.ToDateTime(DB.DataTable.Rows[0]["TripDate"]);
                aTripDestination = Convert.ToString(DB.DataTable.Rows[0]["TripDestination"]);
                aVehicleType = Convert.ToString(DB.DataTable.Rows[0]["VehicleType"]);
                //return that everything was ok
                return true;


            }
            // otherwise no record was found
            else
            {
                return false;
            }
        }
        
    }
}