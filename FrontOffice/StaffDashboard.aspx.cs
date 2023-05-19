using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class StaffDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsSecurity Sec;
            if (Session["Sec"] != null)
            {
                Sec = (clsSecurity)Session["Sec"];
                int UserID = Sec.UserID;
            }
            else
            {
                Response.Redirect("SignIn.aspx");
            }
        }


        protected void btnActivities_Click(object sender, EventArgs e)
        {
            Response.Redirect("ActivityDefault.aspx");
        }

        protected void btnCustomers_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffCustomers.aspx");
        }

        protected void btnHotels_Click(object sender, EventArgs e)
        {
            Response.Redirect("HotelDefault.aspx");
        }

        protected void btnBookings_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookingDefault.aspx");

        }

        protected void btnTrips_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripsDefault.aspx");

        }
        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            // Logout from the session or authentication
            Session.Clear();
            Session.Abandon();
            // If you're using Forms Authentication
            System.Web.Security.FormsAuthentication.SignOut();
            Response.Redirect("SignIn.aspx");
        }

    }
}