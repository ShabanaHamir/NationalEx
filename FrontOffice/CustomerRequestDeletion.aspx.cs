using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class CustomerRequestDeletion : System.Web.UI.Page
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

        protected void btnRequestDelete_Click(object sender, EventArgs e)
        {
            // retrieve user's ID, you might have it in session or you need to get it some other way depending on your application
            clsSecurity Sec = (clsSecurity)Session["Sec"];
            int userId = Sec.UserID;

            // create an instance of clsDataConnection
            clsDataConnection Db = new clsDataConnection();

            // call RequestAccountDeletion method
            Db.RequestAccountDeletion(userId);

            // Provide feedback to the user or redirect
            lblFeedback.Text = "Your request for account deletion has been submitted. A member of our staff will process it soon.";
        }
    }
}