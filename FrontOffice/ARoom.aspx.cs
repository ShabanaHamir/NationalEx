﻿using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ARoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create a new instance of clsHotel
            clsRoom ARoom = new clsRoom();
            string HotelID = txtHotelID.Text;
            string RoomNumber = txtRoomNumber.Text;
            string RoomType = txtRoomType.Text;
            string RoomPrice = txtRoomPrice.Text;
            string Error = "";
            //validate data
            Error = ARoom.Valid(HotelID, RoomNumber, RoomType, RoomPrice);
            //ARoom.HotelID = Convert.ToInt32(txtHotelID.Text);
            //ARoom.RoomNumber = Convert.ToInt32(txtRoomNumber.Text);
            //ARoom.RoomType = txtRoomType.Text;
            //ARoom.RoomPrice = Convert.ToDecimal(txtRoomPrice.Text);
            if (Error == "")
            {
                ARoom.HotelID = Convert.ToInt32(HotelID);
                ARoom.RoomNumber = Convert.ToInt32(RoomNumber);
                ARoom.RoomType = RoomType;
                ARoom.RoomPrice = Convert.ToInt32(RoomPrice);

                //capture
                ARoom.HotelID = Convert.ToInt32(txtHotelID.Text);
                //store the hotel in the session object
                Session["ARoom"] = ARoom;
                //redirect to the viewer page
                Response.Redirect("RoomViewer.aspx");
            }
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            //create a new instance of clsHotel
            clsRoom ARoom = new clsRoom();
            //var to store the PK
            Int32 RoomID;
            //var to store the result of the find operation
            Boolean Found = false;
            //get the PK entered by the user
            RoomID = Convert.ToInt32(txtRoomID.Text);
            //find record
            Found = ARoom.Find(RoomID);
            //if found
            if (Found == true)
            {
                //display values of the properties in the form
                txtHotelID.Text = ARoom.HotelID.ToString();
                txtRoomNumber.Text = ARoom.RoomNumber.ToString();
                txtRoomType.Text = ARoom.RoomType;
                txtRoomPrice.Text = ARoom.RoomPrice.ToString();
            }
        }
    }
}