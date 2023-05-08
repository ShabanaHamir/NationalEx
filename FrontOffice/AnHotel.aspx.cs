using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class AnHotel : System.Web.UI.Page
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




        protected void btnOK_Click(object sender, EventArgs e)
        {
            ////create a new instance of clsHotel
            //clsHotel AnHotel = new clsHotel();

            //////////////////////int hotelPhoneNumber;
            //////////////////////if (int.TryParse(txtHotelPhoneNumber.Text, out hotelPhoneNumber))
            //////////////////////{
            //////////////////////    AnHotel.HotelPhoneNumber = hotelPhoneNumber;
            //////////////////////}
            //////////////////////else
            //////////////////////{
            //////////////////////    // handle the case where the user input is not a valid integer
            //////////////////////}

            //string HotelName = txtHotelName.Text;
            //string HotelCity = txtHotelCity.Text;
            //string HotelPhoneNumber = txtHotelPhoneNumber.Text;
            //string HotelPostCode = txtHotelPostCode.Text;
            ////var to store any error messages
            //string Error = "";
            ////validate data
            //Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            //if (Error == "")
            //{
            //    AnHotel.HotelName = HotelName;
            //    AnHotel.HotelCity = HotelCity;
            //    AnHotel.HotelPhoneNumber = Convert.ToInt32(HotelPhoneNumber);
            //    AnHotel.HotelPostCode = HotelPostCode;

            //    //store the hotel in the session object
            //    Session["AnHotel"] = AnHotel;
            //    //redirect to the viewer page
            //    Response.Write("HotelViewer.aspx");
            //}
            //else
            //{
            //    //error
            //    lblError.Text = Error;
            //}

            if (HotelID == -1)
            {
                //add new record
                Add();

            }
            else
            {
                //update record
                Update();
            }


        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            //create a new instance of clsHotel
            clsHotel AnHotel = new clsHotel();
            //var to store the PK
            Int32 HotelID;
            //var to store the result of the find operation
            Boolean Found = false;
            //get the PK entered by the user
            HotelID = Convert.ToInt32(txtHotelID.Text);
            //find record
            Found = AnHotel.Find(HotelID);
            //if found
            if (Found == true)
            {
                //display values of the properties in the form
                txtHotelName.Text = AnHotel.HotelName;
                txtHotelCity.Text = AnHotel.HotelCity;
                txtHotelPhoneNumber.Text = AnHotel.HotelPhoneNumber.ToString();
                txtHotelPostCode.Text = AnHotel.HotelPostCode;
            }

        }

        //function for adding
        void Add()
        {
            //create an instance
            Classes.clsHotelCollection Hotels = new Classes.clsHotelCollection();
            String Error = Hotels.ThisHotel.Valid(txtHotelName.Text, txtHotelCity.Text, txtHotelPhoneNumber.Text, txtHotelPostCode.Text);
            //if data is OK then add it to the object
            if (Error == "")
            {
                //get data entered by user
                Hotels.ThisHotel.HotelName = txtHotelName.Text;
                Hotels.ThisHotel.HotelCity = txtHotelCity.Text;
                Hotels.ThisHotel.HotelPhoneNumber = txtHotelPhoneNumber.Text;
                Hotels.ThisHotel.HotelPostCode = txtHotelPostCode.Text;
                //ADD RECORD
                Hotels.Add();
                //all good so redirect to default
                Response.Redirect("StaffDashboard.aspx");
            }
            else
            {
                //ERROR
                lblError.Text = "Something went wrong with the entered data" + Error;
            }
        }

        //function for updating
        void Update()
        {
            //create instance
            clsHotelCollection Hotels = new clsHotelCollection();
            //validate on aspx
            String Error = Hotels.ThisHotel.Valid(txtHotelName.Text, txtHotelCity.Text, txtHotelPhoneNumber.Text, txtHotelPostCode.Text);
            //if data is OK add it to object
            if (Error == "")
            {
                //find record to update
                Hotels.ThisHotel.Find(HotelID);
                //get data entered by the user
                Hotels.ThisHotel.HotelName = txtHotelName.Text;
                Hotels.ThisHotel.HotelCity = txtHotelCity.Text;
                Hotels.ThisHotel.HotelPhoneNumber = txtHotelPhoneNumber.Text;
                Hotels.ThisHotel.HotelPostCode = txtHotelPostCode.Text;
                //update record
                Hotels.Update();
                //all good so redirect to default
                Response.Redirect("StaffDashboard.aspx");
            }
            else
            {
                //error
                lblError.Text = "A problem occured with the entered data" + Error;
            }
        }

        void DisplayHotels()
        {
            //intance
            clsHotelCollection Hotel = new clsHotelCollection();
            //find record to update
            Hotel.ThisHotel.Find(HotelID);
            //display data for this record
            txtHotelName.Text = Hotel.ThisHotel.HotelName;
            txtHotelCity.Text = Hotel.ThisHotel.HotelCity;
            txtHotelPhoneNumber.Text = Hotel.ThisHotel.HotelPhoneNumber;
            txtHotelPostCode.Text = Hotel.ThisHotel.HotelPostCode;

        }



    }
}