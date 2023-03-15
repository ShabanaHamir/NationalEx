using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class AnActivity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAOK_Click(object sender, EventArgs e)
        {
            //Create an instance of clsActivity
            clsActivities AnActivity = new clsActivities();
            //capture the activity name
            AnActivity.ActivityName = txtAName.Text;
            //store the address in the session object
            Session["AnActivity"] = AnActivity;
            //redirect to the viewer page
            Response.Redirect("ActivityViewer.aspx");
        }
    }
}