using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class BookingViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create new instance of clsBooking
            clsBooking ABooking = new clsBooking();
            //get the data from the session object
            ABooking = (clsBooking)Session["ABooking"];
            //display the house number for this entry
            Response.Write(ABooking.BookingID);
        }
    }
}