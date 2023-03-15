using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ActivityViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create a new instance of clsActivities
            clsActivities AnActivity = new clsActivities();
            //get the data from the session object
            AnActivity = (clsActivities)Session["AnActivity"];
            //display the activity name for this entry
            Response.Write(AnActivity.ActivityName);
        }
    }
}