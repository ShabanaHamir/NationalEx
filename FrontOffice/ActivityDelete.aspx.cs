using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ActivityDelete : System.Web.UI.Page
    {
        //var to store pk
        Int32 ActivityID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get number of staff to be deleted from the session object
            ActivityID = Convert.ToInt32(Session["ActivityID"]);
        }

        void DeleteActivity()
        {
            //function to delete the selected record

            //create a new instance of jewellery system
            clsActivitiesCollection MyActivities = new clsActivitiesCollection();
            //find the record to delete
            MyActivities.ThisActivity.Find(ActivityID);
            //delete the record
            MyActivities.Delete();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            DeleteActivity();
            Response.Redirect("ActivityDefault.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ActivityDefault.aspx");
        }
    }
}