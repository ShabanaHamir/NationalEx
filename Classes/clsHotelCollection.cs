using System.Collections.Generic;
using System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Classes
{
    public class clsHotelCollection
    {
        //private data memeber for the list 
        List<clsHotel> mHotelList = new List<clsHotel>();
        //private data member thisHotel
        clsHotel mThisHotel = new clsHotel();

        //constructor
        public clsHotelCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute sproc
            DB.Execute("sporc_tblHotel_SelectAll");
            //populate array list with data table
            PopulateArray(DB);


            ////var for index]
            //Int32 Index = 0;
            ////var to store record
            //Int32 RecordCount = 0;
            ////object for data connection
            //clsDataConnection DB = new clsDataConnection();
            //DB.Execute("sporc_tblHotel_SelectAll");
            ////get count of records
            //RecordCount = DB.Count;
            ////while there r records ro perocess
            //while (Index < RecordCount)
            //{
            //    //blank hotel
            //    clsHotel AnHotel = new clsHotel();
            //    //read in the fields from the curent record
            //    AnHotel.HotelID = Convert.ToInt32(DB.DataTable.Rows[Index]["HotelID"]);
            //    AnHotel.HotelName = Convert.ToString(DB.DataTable.Rows[Index]["HotelName"]);
            //    AnHotel.HotelCity = Convert.ToString(DB.DataTable.Rows[Index]["HotelCity"]);
            //    AnHotel.HotelPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["HotelPhoneNumber"]);
            //    AnHotel.HotelPostCode = Convert.ToString(DB.DataTable.Rows[Index]["HotelPostCode"]);
            //    //add record to private data memebr
            //    mHotelList.Add(AnHotel);
            //    //point at next record
            //    Index++;
            //}

        }

        public List<clsHotel> GetAllHotels()
        {
            List<clsHotel> HotelList = new List<clsHotel>();

            // Create a new instance of clsDataConnection
            clsDataConnection DB = new clsDataConnection();
            try
            {
                DB.Execute("sporc_tblHotel_SelectAll");

                HotelList.Clear();

                foreach (DataRow row in DB.DataTable.Rows)
                {
                    clsHotel hotel = new clsHotel();

                    hotel.HotelID = Convert.ToInt32(row["HotelID"]);
                    hotel.HotelName = Convert.ToString(row["HotelName"]);
                    hotel.HotelCity = Convert.ToString(row["HotelCity"]);
                    hotel.HotelPostCode = Convert.ToString(row["HotelPostcode"]);
                    hotel.HotelPhoneNumber = Convert.ToString(row["HotelPhoneNumber"]);

                    mHotelList.Add(hotel);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here or log the error
                // You may want to throw the exception to the calling code for handling
                throw ex;
            }

            return mHotelList;
        }




        //public property for the hotel list 
        public List<clsHotel> HotelList
        {
            get
            {
                //return private data 
                return mHotelList;
            }


            set
            {
                //set 
                mHotelList = value;
            }


        }


        //public count property
        public int Count
        {
            get
            {
                //return the count of the hotel list
                return mHotelList.Count;
            }

            set
            {
                //later
            }
        }

        //public property for ThisHotel
        public clsHotel ThisHotel
        {
            get
            {
                //return priv data
                return mThisHotel;
            }

            set
            {
                //set priv data
                mThisHotel = value;
            }
        }



        public int Add()
        {
            ////add new record to the db based on the values of mThisHotel & set pk value of new record
            //mThisHotel.HotelID = 123;
            //////return pk of the new record
            //return mThisHotel.HotelID;

            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the sproc
            DB.AddParameter("@HotelName", mThisHotel.HotelName);
            DB.AddParameter("@HotelCity", mThisHotel.HotelCity);
            DB.AddParameter("@HotelPostCode", mThisHotel.HotelPostCode);
            DB.AddParameter("@HotelPhoneNumber", mThisHotel.HotelPhoneNumber);
            //execute query returning pk value
            return DB.Execute("sproc_tblHotel_Insert");

        }

        public void Delete()
        {
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@HotelID", mThisHotel.HotelID);
            DB.Execute("sproc_tblHotel_Delete");
        }

        public void Update()
        {
            //update ec=xisting record and connect to db
            clsDataConnection DB = new clsDataConnection();
            //set parametersfor sproc
            DB.AddParameter("@HotelID", mThisHotel.HotelID);
            DB.AddParameter("@HotelName", mThisHotel.HotelName);
            DB.AddParameter("@HotelCity", mThisHotel.HotelCity);
            DB.AddParameter("@HotelPostCode", mThisHotel.HotelPostCode);
            DB.AddParameter("@HotelPhoneNumber", mThisHotel.HotelPhoneNumber);
            //execute
            DB.Execute("sproc_tblHotel_Update");
        }

        public void ReportByHotelName(string HotelName)
        {
            //filters records based on a full or partial hotel name
            //connect to db
            clsDataConnection DB = new clsDataConnection();
            //send hotel name parameter to the fb
            DB.AddParameter("@HotelName", HotelName);
            //execute sproc
            DB.Execute("sproc_tblHotel_FilterByHotelName");
            //populate array list with data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the param DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mHotelList = new List<clsHotel>();
            //while there r records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsHotel AnHotel = new clsHotel();
                AnHotel.HotelID = Convert.ToInt32(DB.DataTable.Rows[Index]["HotelID"]);
                AnHotel.HotelName = Convert.ToString(DB.DataTable.Rows[Index]["HotelName"]);
                AnHotel.HotelCity = Convert.ToString(DB.DataTable.Rows[Index]["HotelCity"]);
                AnHotel.HotelPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["HotelPhoneNumber"]);
                AnHotel.HotelPostCode = Convert.ToString(DB.DataTable.Rows[Index]["HotelPostCode"]);

                //add record to the private data member 
                mHotelList.Add(AnHotel);
                //point at the next record 
                Index++;
            }
        }
    }
}

