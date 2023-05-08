using Classes;
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
        //var to store pk
        Int32 RoomID;
        protected void Page_Load(object sender, EventArgs e)
        {
            RoomID = Convert.ToInt32(Session["RoomID"]);
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update
                DisplayRooms();
                //if this is not a new record
                if (RoomID != -1)
                {
                    DisplayRooms();
                }
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            ////create a new instance of clsHotel
            //clsRoom ARoom = new clsRoom();
            //string HotelID = txtHotelID.Text;
            //string FloorNumber = txtFloorNumber.Text;
            //string RoomFacilities = FacilitiesCheckBoxList.Text;
            //string RoomNumber = txtRoomNumber.Text;
            //string RoomDescription = txtRoomDescription.Text;
            //string NumberOfBeds = txtNumberOfBeds.Text;
            //string RoomType = txtRoomType.Text;
            //decimal RoomPrice = Convert.ToDecimal(txtRoomPrice.Text);
            //string Error = "";
            ////validate data
            //Error = ARoom.Valid(HotelID, FloorNumber, RoomNumber, NumberOfBeds, RoomType, RoomPrice, RoomDescription, RoomFacilities);
            ////ARoom.HotelID = Convert.ToInt32(txtHotelID.Text);
            ////ARoom.RoomNumber = Convert.ToInt32(txtRoomNumber.Text);
            ////ARoom.RoomType = txtRoomType.Text;
            ////ARoom.RoomPrice = Convert.ToDecimal(txtRoomPrice.Text);
            //if (Error == "")
            //{
            //    ARoom.HotelID = Convert.ToInt32(HotelID);
            //    ARoom.FloorNumber = Convert.ToInt32(FloorNumber);
            //    ARoom.RoomFacilities = RoomFacilities;
            //    ARoom.RoomNumber = Convert.ToInt32(RoomNumber);
            //    ARoom.RoomDescription = RoomDescription;
            //    ARoom.NumberOfBeds = Convert.ToInt32(NumberOfBeds);
            //    ARoom.RoomType = RoomType;
            //    ARoom.RoomPrice = Convert.ToInt32(RoomPrice);

            //    //capture
            //    ARoom.HotelID = Convert.ToInt32(txtHotelID.Text);
            //    //store the hotel in the session object
            //    Session["ARoom"] = ARoom;
            //    //redirect to the viewer page
            //    Response.Redirect("RoomViewer.aspx");
            //}
            //else
            //{
            //    //error message
            //    lblError.Text = Error;
            //}

            if (RoomID == -1)
            {
                Add();
            }
            else
            {
                Update();
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
                txtHotelName.Text = ARoom.HotelName;
                txtFloorNumber.Text = ARoom.FloorNumber.ToString();
                FacilitiesCheckBoxList.SelectedValue = ARoom.RoomFacilities;
                txtRoomNumber.Text = ARoom.RoomNumber.ToString();
                txtRoomDescription.Text = ARoom.RoomDescription;
                txtNumberOfBeds.Text = ARoom.NumberOfBeds.ToString();
                txtRoomType.Text = ARoom.RoomType;
                txtRoomPrice.Text = ARoom.RoomPrice.ToString();
            }
        }

        void Add()
        {
            Classes.clsRoomCollection Rooms = new Classes.clsRoomCollection();
            String Error = Rooms.ThisRoom.Valid(txtHotelID.Text, txtHotelName.Text, txtFloorNumber.Text, txtNumberOfBeds.Text, txtRoomNumber.Text, txtRoomType.Text, Convert.ToDecimal(txtRoomPrice.Text), txtRoomDescription.Text, FacilitiesCheckBoxList.SelectedValue);
            if (Error == "")
            {
                Rooms.ThisRoom.HotelID = Convert.ToInt32(txtHotelID.Text);
                Rooms.ThisRoom.HotelName = txtHotelName.Text;
                Rooms.ThisRoom.FloorNumber = Convert.ToInt32(txtFloorNumber.Text);
                Rooms.ThisRoom.RoomFacilities = FacilitiesCheckBoxList.SelectedValue;
                Rooms.ThisRoom.RoomNumber = Convert.ToInt32(txtRoomNumber.Text);
                Rooms.ThisRoom.RoomDescription = txtRoomDescription.Text;
                Rooms.ThisRoom.NumberOfBeds = Convert.ToInt32(txtNumberOfBeds.Text);
                Rooms.ThisRoom.RoomType = txtRoomType.Text;
                Rooms.ThisRoom.RoomPrice = Convert.ToDecimal(txtRoomPrice.Text);
                //add
                Rooms.Add();
                //redirect
                Response.Redirect("RoomViewer.aspx");

            }
            else
            {
                lblError.Text = "Something went wring with the entered data" + Error;
            }
        }

        void Update()
        {
            clsRoomCollection Rooms = new clsRoomCollection();
            String Error = Rooms.ThisRoom.Valid(txtHotelID.Text, txtHotelName.Text, txtFloorNumber.Text, txtNumberOfBeds.Text, txtRoomNumber.Text, txtRoomType.Text, Convert.ToDecimal(txtRoomPrice.Text), txtRoomDescription.Text, FacilitiesCheckBoxList.SelectedValue);
            if (Error == "")
            {
                Rooms.ThisRoom.Find(RoomID);
                //get data entered by user
                Rooms.ThisRoom.HotelID = Convert.ToInt32(txtHotelID.Text);
                Rooms.ThisRoom.HotelName = txtHotelName.Text;
                Rooms.ThisRoom.FloorNumber = Convert.ToInt32(txtFloorNumber.Text);
                Rooms.ThisRoom.RoomFacilities = FacilitiesCheckBoxList.SelectedValue;
                Rooms.ThisRoom.RoomNumber = Convert.ToInt32(txtRoomNumber.Text);
                Rooms.ThisRoom.RoomDescription = txtRoomDescription.Text;
                Rooms.ThisRoom.NumberOfBeds = Convert.ToInt32(txtNumberOfBeds.Text);
                Rooms.ThisRoom.RoomType = txtRoomType.Text;
                Rooms.ThisRoom.RoomPrice = Convert.ToDecimal(txtRoomPrice.Text);
                //update
                Rooms.Update();
                //redirect
                Response.Redirect("RoomViewer.aspx");
            }
            else
            {
                lblError.Text = "A problem occured with the entered data" + Error;
            }

        }

        void DisplayRooms()
        {
            clsRoomCollection Room = new clsRoomCollection();
            //find
            Room.ThisRoom.Find(RoomID);
            //display data
            txtHotelID.Text = Room.ThisRoom.HotelID.ToString();
            txtHotelName.Text = Room.ThisRoom.HotelName;
            txtFloorNumber.Text = Room.ThisRoom.FloorNumber.ToString();
            FacilitiesCheckBoxList.SelectedValue = Room.ThisRoom.RoomFacilities;
            txtRoomNumber.Text = Room.ThisRoom.RoomNumber.ToString();
            txtRoomDescription.Text = Room.ThisRoom.RoomDescription;
            txtNumberOfBeds.Text = Room.ThisRoom.NumberOfBeds.ToString();
            txtRoomType.Text = Room.ThisRoom.RoomType;
            txtRoomPrice.Text = Room.ThisRoom.RoomPrice.ToString();

        }


    }
}