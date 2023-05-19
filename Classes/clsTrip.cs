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
        private string aTripSource;

        public string TripSource
        {
            get
            {
                return aTripSource;
            }
            set
            {
                aTripSource = value;
            }
        }


        private decimal aTicketCost;
        public decimal TicketCost
        {
            get
            {
                return aTicketCost;
            }
            set
            {
                aTicketCost = value;
            }
        }

        private DateTime aTripStartTime;
        public DateTime TripStartTime
        {
            get
            {
                return aTripStartTime;
            }
            set
            {
                aTripStartTime = value;

            }
        }


        private DateTime aTripEndTime;
        public DateTime TripEndTime
        {
            get
            {
                return aTripEndTime;
            }
            set
            {
                aTripEndTime = value;

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
            if (DB.Count == 1)
            {
                aTripID = Convert.ToInt32(DB.DataTable.Rows[0]["TripID"]);
                aTripDate = Convert.ToDateTime(DB.DataTable.Rows[0]["TripDate"]);
                aTripDestination = Convert.ToString(DB.DataTable.Rows[0]["TripDestination"]);
                aVehicleType = Convert.ToString(DB.DataTable.Rows[0]["VehicleType"]);
                aTripSource = Convert.ToString(DB.DataTable.Rows[0]["TripSource"]);
                aTicketCost = Convert.ToDecimal(DB.DataTable.Rows[0]["TicketCost"]);
                aTripStartTime = Convert.ToDateTime(DB.DataTable.Rows[0]["TripStartTime"]);
                aTripEndTime = Convert.ToDateTime(DB.DataTable.Rows[0]["TripEndTime"]);
                //return that everything was ok
                return true;


            }
            // otherwise no record was found
            else
            {
                return false;
            }
        }

        //public string Valid

        //    (string TripID,
        //    DateTime TripDate,
        //    string TripDestination,
        //    string VehicleType)
        //{

        //}

        public string Valid(string tripDate, string tripDestination, string vehicleType, string tripSource, decimal ticketCost, string tripStartTime, string tripEndTime)
        {
            DateTime DateTemp;
            //  create a string to save the error
            String Error = "";

            if (tripDestination.Length == 0)
            {
                Error = Error + "please type the trip destination :";
            }
            // make the trip destination field greater than 14 
            if (tripDestination.Length > 14)
            {
                Error = Error + "The trip destination cannot be more than 14 character :";
            }


            if (vehicleType.Length == 0)
            {
                Error = Error + "please type the vehicle type :";
            }
            // make the trip destination field greater than 14 
            if (vehicleType.Length > 14)
            {
                Error = Error + "The vehicle type cannot be more than 14 character :";
            }

            try
            {

                //copy the trip date value to the date temp variable
                DateTemp = Convert.ToDateTime(tripDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date you typed is in the past : ";
                }
                // to see if the date is greater than today's date 
                if (DateTemp > DateTime.Now.Date)
                {
                    // record the error 
                    Error = Error + "The date you typed is in the future :";
                }

            }
            catch
            {
                Error = Error + "please enter a valid date :";
            }

            if (tripSource.Length == 0)
            {
                Error = Error + "please type the trip source :";
            }
            // make the trip destination field greater than 14 
            if (tripSource.Length > 14)
            {
                Error = Error + "The trip source cannot be more than 14 character :";
            }



            if (ticketCost <= 0)
            {
                //error
                Error = Error + " ticket cost cannot be less than or equal to zero... We aren't free!";
            }



            try
            {

                //copy the trip date value to the date temp variable
                DateTemp = Convert.ToDateTime(tripStartTime);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date you typed is in the past : ";
                }
                // to see if the date is greater than today's date 
                if (DateTemp > DateTime.Now.Date)
                {
                    // record the error 
                    Error = Error + "The date you typed is in the future :";
                }

            }
            catch
            {
                Error = Error + "please enter a valid date :";
            }


            try
            {

                //copy the trip date value to the date temp variable
                DateTemp = Convert.ToDateTime(tripEndTime);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date you typed is in the past : ";
                }
                // to see if the date is greater than today's date 
                if (DateTemp > DateTime.Now.Date)
                {
                    // record the error 
                    Error = Error + "The date you typed is in the future :";
                }

            }
            catch
            {
                Error = Error + "please enter a valid date :";
            }





            //return any error messages
            return Error;
        }
    }
}
