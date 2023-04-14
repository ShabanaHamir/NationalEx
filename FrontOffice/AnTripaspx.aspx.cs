using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class AnTripaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create a new instance of cls trip 
            clsTrip AnTrip = new clsTrip();
            // capture the trip ID 
            txtTripID.Text = AnTrip.TripID.ToString();
            //store the ID in the session object 
            Session["AnTrip"] = AnTrip;
            //redirect to the passenger page
            Response.Redirect("AnPassenger.aspx");
        }


    }
}