using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ABooking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //new instance of clsBooking
            clsBooking ABooking = new clsBooking();
            //capture the BookingID
            ABooking.BookingID = Convert.ToInt32(txtBookingID.Text);
            //store the booking in session object
            Session["ABooking"] = ABooking;
            //redirect to viewer page
            Response.Redirect("BookingViewer.aspx");
        }
    }
}