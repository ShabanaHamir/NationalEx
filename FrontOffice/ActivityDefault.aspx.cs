using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ActivityDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //update list box
                DisplayActivities();
            }
        }

        void DisplayActivities()
        {
            //create an imstance of the activities
            Classes.clsActivitiesCollection Activities = new Classes.clsActivitiesCollection();
            //set the data source to the list of activities in the collection
            lstActivities.DataSource = Activities.ActivitiesList;
            //set the name of the PK
            lstActivities.DataValueField = "ActivityID";
            //set data field to display 
            lstActivities.DataTextField = "Activity Name";
            //bind the data to the list
            lstActivities.DataBind();
        }
    }
}