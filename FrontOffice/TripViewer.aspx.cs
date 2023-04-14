using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class TripViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create a new instance of trip 
            clsTrip AnTrip = new clsTrip();
            //get the data from the session object 
            AnTrip = (clsTrip)Session["AnTrip"];
            //display the ID number 
            Response.Write(AnTrip.TripID);
        }
    }
}