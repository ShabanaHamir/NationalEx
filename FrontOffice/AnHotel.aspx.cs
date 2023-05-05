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
        protected void Page_Load(object sender, EventArgs e)
        {

        }




        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create a new instance of clsHotel
            clsHotel AnHotel = new clsHotel();

            ////////////////////int hotelPhoneNumber;
            ////////////////////if (int.TryParse(txtHotelPhoneNumber.Text, out hotelPhoneNumber))
            ////////////////////{
            ////////////////////    AnHotel.HotelPhoneNumber = hotelPhoneNumber;
            ////////////////////}
            ////////////////////else
            ////////////////////{
            ////////////////////    // handle the case where the user input is not a valid integer
            ////////////////////}

            string HotelName = txtHotelName.Text;
            string HotelCity = txtHotelCity.Text;
            string HotelPhoneNumber = txtHotelPhoneNumber.Text;
            string HotelPostCode = txtHotelPostCode.Text;
            //var to store any error messages
            string Error = "";
            //validate data
            Error = AnHotel.Valid(HotelName, HotelCity, HotelPhoneNumber, HotelPostCode);
            if (Error == "")
            {
                AnHotel.HotelName = HotelName;
                AnHotel.HotelCity = HotelCity;
                AnHotel.HotelPhoneNumber = Convert.ToInt32(HotelPhoneNumber);
                AnHotel.HotelPostCode = HotelPostCode;

                //store the hotel in the session object
                Session["AnHotel"] = AnHotel;
                //redirect to the viewer page
                Response.Write("HotelViewer.aspx");
            }
            else
            {
                //error
                lblError.Text = Error;
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
    }
}