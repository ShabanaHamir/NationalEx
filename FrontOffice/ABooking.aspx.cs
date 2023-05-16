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

        protected void btnFind_Click(object sender, EventArgs e)
        {
            //create a new instance of clsactivity
            clsBooking ABooking = new clsBooking();
            //var to store the PK
            Int32 BookingID;
            //var to store the result of the find operation
            Boolean Found = false;
            //get the PK entered by the user
            BookingID = Convert.ToInt32(txtBookingID.Text);
            //find record
            Found = ABooking.Find(BookingID);
            //if found
            if (Found == true)
            {
                //display values of the properties in the form
                txtBookingDate.Text = ABooking.BookingDate.ToString();
                txtUserFName.Text = ABooking.FirstName;
                txtBookingDetails.Text = ABooking.BookingDetails;
                txtTotalCost.Text = ABooking.TotalCost.ToString();
                txtPaymentType.Text = ABooking.PaymentType;
                
            }
        }
    }
}