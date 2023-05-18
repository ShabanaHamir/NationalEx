using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnTrips_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnTripaspx.aspx");
        }

        protected void btnHotels_Click(object sender, EventArgs e)
        {
            Response.Redirect("HotelDetails.aspx");
        }

        protected void btnActivities_Click(object sender, EventArgs e)
        {
            Response.Redirect("ActivityBooking.aspx");
        }
    }
}