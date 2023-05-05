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
        //variable to store PK with page levelscope
        Int32 ActivityID;
        protected void Page_Load(object sender, EventArgs e)
        {
            ActivityID = Convert.ToInt32(Session["StaffID"]);
            if (IsPostBack == false)
            {
                //update list box
                DisplayActivityNames();
            }
        }

        void DisplayActivityNames()
        {
            {
                //create an imstance of the activities
                clsActivitiesCollection Activities = new clsActivitiesCollection();
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

        Int32 DisplayActivities(string ActivitiesNameFilter)
        {
            //create an imstance of the activities
            clsActivitiesCollection MyActivities = new clsActivitiesCollection();
            //call the filter by activity name 
            MyActivities.FilterByActivitiesName(ActivitiesNameFilter);
            
            //point the list box at the activitylist collection
            lstActivities.DataSource = MyActivities.ActivitiesList;
            //tell it what field to display to user
            lstActivities.DataTextField = "ActivitiyName";
            //set pk value
            lstActivities.DataValueField = "ActivityID";
            //bind the data to the list and display it
            lstActivities.DataBind();
            //return no of records found
            return MyActivities.Count;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnApply_Click(object sender, EventArgs e)
        {

        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {

        }
    }
}