using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class AdminDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("UserDefault.aspx");
        }

        protected void btnUsers_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnHotels_Click(object sender, EventArgs e)
        {

        }

        protected void btnActivities_Click(object sender, EventArgs e)
        {
            Response.Redirect("ActivityDefault.aspx");
        }

        protected void btnTrips_Click(object sender, EventArgs e)
        {

        }

        protected void btnReports_Click(object sender, EventArgs e)
        {

        }

        protected void btnCustomerFeedback_Click(object sender, EventArgs e)
        {
           
        }
    }
}