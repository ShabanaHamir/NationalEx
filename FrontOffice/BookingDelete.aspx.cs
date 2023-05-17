using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class BookingDelete : System.Web.UI.Page
    {
        //var to store pk
        Int32 BookingID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get number of staff to be deleted from the session object
            BookingID = Convert.ToInt32(Session["BookingID"]);
        }

        void DeleteBooking()
        {
            //function to delete the selected record

            //create a new instance of jewellery system
            clsBookingCollection MyBookings = new clsBookingCollection();
            //find the record to delete
            MyBookings.ThisBooking.Find(BookingID);
            //delete the record
            MyBookings.Delete();
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBooking();
            Response.Redirect("BookingDefault.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookingDefault.aspx");
        }
    }
}