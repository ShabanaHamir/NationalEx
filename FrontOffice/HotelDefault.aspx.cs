using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class HotelDefault : System.Web.UI.Page
    {

        //var to store the pk with the page level scope
        Int32 HotelID;
        protected void Page_Load(object sender, EventArgs e)
        {
            HotelID = Convert.ToInt32(Session["HotelID"]);
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update list box
                DisplayHotels();
                //if this is not a new record
                if (HotelID != -1)
                {
                    //display current data for thr record
                    DisplayHotels();
                }
            }
        }

        void DisplayHotels()
        {
            clsHotelCollection Hotels = new clsHotelCollection();
            //set data source to the list of hptels in the collection
            lstHotels.DataSource = Hotels.HotelList;
            //set the name of the pk
            lstHotels.DataValueField = "HotelID";
            //set the data field to display
            lstHotels.DataTextField = "HotelName";
            //bind the data to the list
            lstHotels.DataBind();
        }

        Int32 DisplayHotel(string hotelName)
        {
            //var
            Int32 HotelID;
            string HotelName;
            string HotelCity;
            string HotelPhoneNumber;
            string HotelPostCode;

            //instance
            clsHotelCollection Hotel = new clsHotelCollection();
            Hotel.ReportByHotelName(hotelName);
            //var to store record count
            Int32 RecordCount;
            Int32 Index = 0;
            RecordCount = Hotel.Count; //records from tblHotel
            lstHotels.Items.Clear();
            while (Index < RecordCount) //while records are to process
            {
                HotelID = Hotel.HotelList[Index].HotelID;
                HotelName = Hotel.HotelList[Index].HotelName;
                HotelCity = Hotel.HotelList[Index].HotelCity;
                HotelPhoneNumber = Hotel.HotelList[Index].HotelPhoneNumber;
                HotelPostCode = Hotel.HotelList[Index].HotelPostCode;
                //create the new entry for the list box
                ListItem NewEntry = new ListItem(HotelName + " " + HotelCity + " " + HotelPhoneNumber + " " + HotelPostCode, HotelID.ToString());
                lstHotels.Items.Add(NewEntry); //add new hotel to the list
                Index++; //index next record
            }
            return RecordCount;
        }



        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 intothe session object to indicate this is a new record
            Session["HotelID"] = -1;
            //redirect to data entry page
            Response.Redirect("AnHotel.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store the pk value of the record deleted
            Int32 HotelID;
            //if a record has been selected from the list
            if (lstHotels.SelectedIndex != -1)
            {
                //get pk value of the record to delete
                HotelID = Convert.ToInt32(lstHotels.SelectedValue);
                //store data in the session object
                Session["HotelID"] = HotelID;
                //REDIRECT
                Response.Redirect("HotelsDelete.aspx");
            }
            else //no record has been selected
            {
                lblError.Text = "Please Select a record to delete from the list";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store the pk of the record to be edited
            Int32 HotelID;
            if (lstHotels.SelectedIndex != -1)
            {
                //get pk value of record to edit
                HotelID = Convert.ToInt32(lstHotels.SelectedValue);
                //store data in the session object
                Session["HotelID"] = HotelID;
                //redirect
                Response.Redirect("AnHotel.aspx");
            }
            else //if no record has been selected
            {
                //error
                lblError.Text = "Please select a record to Edit from the list";
            }


        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            Int32 RecordCount;
            RecordCount = DisplayHotel("");
            lblError.Text = RecordCount + "Records of Hotels ";
            txtHotelName.Text = "";
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            Int32 RecordCount;
            RecordCount = DisplayHotel(txtHotelName.Text);
            lblError.Text = RecordCount + "Hotel Name are displayed";
        }


    }
}