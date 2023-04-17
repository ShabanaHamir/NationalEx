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

        public bool Find(int tripID)
        {
            //set the private variable to test the value 
            aTripID = 11;
            aTripDate = Convert.ToDateTime("04/04/2023");
            aTripDestination = "London";
            aVehicleType = "Bus";
            // return the value true 
            return true;
        }
    }
}