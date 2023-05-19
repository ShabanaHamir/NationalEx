using System;
using System.Collections.Generic;
using System.Linq;
using Classes;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class Trips : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsSecurity Sec = (clsSecurity)Session["Sec"];

            if (Sec == null || Sec.UserID == 0)
            {
                Response.Redirect("SignIn.aspx");
            }
        }

        protected void btnBook1_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripBooking.aspx");
        }

        protected void btnBook2_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripBooking.aspx");
        }

        protected void btnBook3_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripBooking.aspx");
        }

        protected void btnBook4_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripBooking.aspx");
        }

        protected void btnBook5_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripBooking.aspx");
        }

        protected void btnBook6_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripBooking.aspx");
        }

        protected void btnBook7_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripBooking.aspx");
        }

        protected void btnBook8_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripBooking.aspx");
        }

        protected void btnBook9_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripBooking.aspx");
        }

        protected void btnBook10_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripBooking.aspx");
        }

        protected void btnBook11_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripBooking.aspx");
        }

        protected void btnBook12_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripBooking.aspx");
        }

        protected void btnBook13_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripBooking.aspx");
        }

        protected void btnBook14_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripBooking.aspx");
        }

        protected void btnBook15_Click(object sender, EventArgs e)
        {
            Response.Redirect("TripBooking.aspx");
        }
    }
}