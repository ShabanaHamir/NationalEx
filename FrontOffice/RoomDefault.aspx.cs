using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Classes;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class RoomDefault : System.Web.UI.Page
    {
        Int32 RoomID;
        protected void Page_Load(object sender, EventArgs e)
        {
            RoomID = Convert.ToInt32(Session["RoomID"]);
            //if this is the first time the page is displayes
            if (IsPostBack == false)
            {
                //update list box
                DisplayRooms();
                //if this is not a new record
                if (RoomID != -1)
                {
                    //display current data
                    DisplayRooms();
                }
            }

        }

        //
        void DisplayRooms()
        {
            clsRoomCollection Rooms = new clsRoomCollection();
            //set data source to the list of rooms in the collection
            lstRooms.DataSource = Rooms.RoomList;
            //set the name of pk
            lstRooms.DataValueField = "RoomID";
            //set data field to display
            lstRooms.DataTextField = "HotelID";
            //bind data to the list
            lstRooms.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Session["RoomID"] = -1;
            //redirect
            Response.Redirect("ARoom.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //car to store pk
            Int32 RoomID;
            //if a record has been selected 
            if (lstRooms.SelectedIndex != -1)
            {

                //get pk value of the record to delete
                RoomID = Convert.ToInt32(lstRooms.SelectedValue);
                //store data in session
                Session["RoomID"] = RoomID;
                //REDIRECT
                Response.Redirect("RoomsDelete.aspx");
            }
            else
            {
                lblError.Text = "Please Select a record to delete from the list";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var stores the pk of record to be edites
            Int32 RoomID;
            //If a record has been selected from the list
            if (lstRooms.SelectedIndex != -1)
            {
                //get pk of the record to edit
                RoomID = Convert.ToInt32(lstRooms.SelectedValue);
                //store data in session object
                Session["RoomID"] = RoomID;
                //REDIRCT
                Response.Redirect("ARoom.aspx");

            }
            else //no record has been selected
            {
                //error
                lblError.Text = "Please Select a record to delete from the list";
            }
        }

        Int32 DisplayRoom(string hotelID)
        {
            //var 
            Int32 RoomID;
            Int32 HotelID;
            string RoomFacilities;
            Int32 RoomNumber;
            string RoomDescription;
            Int32 NumberOfBeds;
            string RoomType;
            decimal RoomPrice;

            clsRoomCollection Room = new clsRoomCollection();
            Room.ReportByHotelID(hotelID);
            //var to store record count
            Int32 RecordCount;
            Int32 Index = 0;
            RecordCount = Room.Count;
            lstRooms.Items.Clear();
            while (Index < RecordCount)
            {
                RoomID = Room.RoomList[Index].RoomID;
                HotelID = Room.RoomList[Index].RoomID;
                RoomFacilities = Room.RoomList[Index].RoomFacilities;
                RoomNumber = Room.RoomList[Index].RoomNumber;
                RoomDescription = Room.RoomList[Index].RoomDescription;
                NumberOfBeds = Room.RoomList[Index].NumberOfBeds;
                RoomType = Room.RoomList[Index].RoomType;
                RoomPrice = Room.RoomList[Index].RoomPrice;
                ListItem NewEntry = new ListItem(HotelID + " " + RoomFacilities + " " + RoomNumber + " " + RoomDescription + " " + NumberOfBeds + " " + RoomType + " " + RoomPrice, RoomID.ToString());
                lstRooms.Items.Add(NewEntry);
                Index++;

            }
            return RecordCount;

        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            Int32 RecordCount;
            RecordCount = DisplayRoom("");
            lblError.Text = RecordCount + "Records of Rooms in our Database";
            txtHotelID.Text = "";

        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            Int32 RecordCount;
            RecordCount = DisplayRoom(txtHotelID.Text);
            lblError.Text = RecordCount + "Rooms are displayed";
        }
    }
}