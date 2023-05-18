using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class StaffCustomers : System.Web.UI.Page
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

        protected void btnCustomers_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffCustomerList.aspx");
        }

        protected void btnCustomerRequests_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffViewDeletionRequests.aspx");
        }
    }
}