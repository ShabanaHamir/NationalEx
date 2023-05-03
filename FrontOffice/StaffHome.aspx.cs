using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classes;

namespace FrontOffice
{
    public partial class StaffHome : System.Web.UI.Page
    {
        //create a copy of the security object with page level scope
        clsSecurity Sec;

        protected void Page_Load(object sender, EventArgs e)
        {
            //get the current security state from the session
            Sec = (clsSecurity)Session["Sec"];
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //update the security state in the session
            Session["Sec"] = Sec;
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            //try to sign in and record any errors
            clsSecurity Sec = new clsSecurity();
            String Error = Sec.SignIn(txtUsername.Text, txtPin.Text);

            //if there were no errors
            if (Error == "")
            {
                //redirect to the staff dashboard page
                Response.Redirect("StaffDashboard.aspx");
            }
            else
            {
                //otherwise display any errors
                lblError.Text = Error;
            }
        }
    }
}
