using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Classes;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ThankYou : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            // Logout from the session or authentication
            Session.Clear();
            Session.Abandon();
            // If you're using Forms Authentication
            System.Web.Security.FormsAuthentication.SignOut();


            // Redirect to your login page (modify this to the actual path of your login page)
            Response.Redirect("CustomerPersonalDetails.aspx");
        }

    }
}