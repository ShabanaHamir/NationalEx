using System.Collections.Generic;
using System;

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
            //var for index]
            Int32 Index = 0;
            //var to store record
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sporc_tblHotel_SelectAll");
            //get count of records
            RecordCount = DB.Count;
            //while there r records ro perocess
            while (Index < RecordCount)
            {
                //blank hotel
                clsHotel AnHotel = new clsHotel();
                //read in the fields from the curent record
                AnHotel.HotelID = Convert.ToInt32(DB.DataTable.Rows[Index]["HotelID"]);
                AnHotel.HotelName = Convert.ToString(DB.DataTable.Rows[Index]["HotelName"]);
                AnHotel.HotelCity = Convert.ToString(DB.DataTable.Rows[Index]["HotelCity"]);
                AnHotel.HotelPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["HotelPhoneNumber"]);
                AnHotel.HotelPostCode = Convert.ToString(DB.DataTable.Rows[Index]["HotelPostCode"]);
                //add record to private data memebr
                mHotelList.Add(AnHotel);
                //point at next record
                Index++;
            }












            ////items of test data
            //clsHotel TestItem = new clsHotel();
            //TestItem.HotelID = 1;
            //TestItem.HotelName = "Inn";
            //TestItem.HotelPhoneNumber = 01234567891;
            //TestItem.HotelPostCode = "XXX XXX";
            //mHotelList.Add(TestItem);
            ////add item to lis
            //TestItem = new clsHotel();
            ////set its properties
            //TestItem.HotelID = 2;
            //TestItem.HotelName = "Skyline";
            //TestItem.HotelPhoneNumber = 01004567891;
            //TestItem.HotelPostCode = "XE1 7XX";
            ////add item to list
            //mHotelList.Add(TestItem);
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
            //add new record to the db based on the values of mThisHotel & set pk value of new record
            mThisHotel.HotelID = 123;
            ////return pk of the new record
            return mThisHotel.HotelID;

            //    clsDataConnection DB = new clsDataConnection();
            //    //set the parameters for the sproc
            //    DB.AddParameter("@HotelName", mThisHotel.HotelName);
            //    DB.AddParameter("@HotelCity", mThisHotel.HotelCity);
            //    DB.AddParameter("@HotelPostCode", mThisHotel.HotelPostCode);
            //    DB.AddParameter("@HotelPhoneNumber", mThisHotel.HotelPhoneNumber);
            //    //execute query returning pk value
            //    //return DB.Execute("sproc_tblHotel_Insert");

        }



        }
    }

