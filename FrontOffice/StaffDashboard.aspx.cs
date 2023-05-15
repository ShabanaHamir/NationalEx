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

        }


        protected void btnActivities_Click(object sender, EventArgs e)
        {
            Response.Redirect("ActivityDefault.aspx");
        }

        protected void btnCustomers_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffCustomerList.aspx");
        }
    }
}