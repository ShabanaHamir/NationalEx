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
        protected void Page_Load(object sender, EventArgs e)
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update list box
                DisplayHotels();
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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}