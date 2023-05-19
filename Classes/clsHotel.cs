using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Classes
{
    public class clsHotel
    {
        //private member
        private string mHotelName;
        //public property 
        public string HotelName
        {
            get
            {
                return mHotelName;
            }
            set
            {
                mHotelName = value;
            }
        }


        //private member
        private string mHotelCity;
        //public property 
        public string HotelCity
        {
            get
            {
                return mHotelCity;
            }
            set
            {
                mHotelCity = value;
            }
        }



        //private data member for the hotel id
        private Int32 mHotelID;
        //hotelid public property
        public int HotelID
        {
            get
            {
                //sends data out of the property
                return mHotelID;
            }
            set
            {
                //allows data into the property
                mHotelID = value;
            }
        }
        //private data member
        private string mHotelPostCode;

        public string HotelPostCode
        {
            get
            {
                //return the private data
                return mHotelPostCode;
            }
            set
            {
                //set the private data
                mHotelPostCode = value;
            }
        }
        //private data member 
        private string mHotelPhoneNumber;
        public string HotelPhoneNumber
        {
            get
            {
                //return the private data
                return mHotelPhoneNumber;
            }
            set
            {
                //set the private data
                mHotelPhoneNumber = value;
            }
        }

   

        public bool Find(int HotelID)
        {

            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add parametetr for the HotelId to search for 
            DB.AddParameter("@HotelID", HotelID);
            //execute stored proc
            DB.Execute("[sproc_tblHotel_FilterByHotelId]");
            //if one record is found (either one or zero)
            if (DB.Count == 1)
            {
                //copy data from the db to the private data memebers

                mHotelID = Convert.ToInt32(DB.DataTable.Rows[0]["HotelID"]);
                mHotelName = Convert.ToString(DB.DataTable.Rows[0]["HotelName"]);
                mHotelCity = Convert.ToString(DB.DataTable.Rows[0]["HotelCity"]);
                mHotelPostCode = Convert.ToString(DB.DataTable.Rows[0]["HotelPostCode"]);
                mHotelPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["HotelPhoneNumber"]);
                //return everything worked fine
                return true;
            }

            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

         




        }

        public string Valid(string hotelName, string hotelCity, string hotelPhoneNumber, string hotelPostCode)
        {
            //create a string var to store error
            String Error = "";
            //if Hotel name is empty
            if (hotelName.Length == 0)
            {
                //record error
                Error = Error + "Hotel Name cannot be left empty ! ";
            }
            //if hotel name is greater than 50 characters
            if (hotelName.Length > 50)
            {
                //record error
                Error = Error + "Something went wrong. Please re-enter the Hotel Name ! ";
            }


            //if Hotel city is empty
            if (hotelCity.Length == 0)
            {
                //record error
                Error = Error + "Hotel City cannot be left empty ! ";
            }
            //if hotel city is greater than 50 characters
            if (hotelCity.Length > 50)
            {
                //record error
                Error = Error + "Something went wrong. Please re-enter the Hotel City ! ";
            }



            // if postcode is empty
            if (hotelPostCode.Length == 0)
            {
                //error
                Error = Error + "Post Code cannot be left empty ! ";
            }
            //if postcode is greater than 50 characters
            if (hotelPostCode.Length > 9)
            {
                //record error
                Error = Error + "Post code cannot be this long ! ";
            }



            // if phonenumber is empty
            if (hotelPhoneNumber.Length == 0)
            {
                //error
                Error = Error + "Phone Number cannot be left empty ! ";
            }
            //if phonenumber is greater than 11 characters
            if (hotelPhoneNumber.Length > 11)
            {
                //record error
                Error = Error + "Phone Number cannot be this long ! ";
            }


            //return error message
            return Error;
        }
    }
}