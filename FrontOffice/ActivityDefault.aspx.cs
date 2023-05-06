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
                lstActivities.DataTextField = "ActivityName";
                //bind the data to the list
                lstActivities.DataBind();
            }
        }

        Int32 DisplayActivities(string ActivitiesNameFilter)
        {
            //declare variables
            Int32 ActivityID;
            string ActivityName;
            string ActivityCity;
            string ActivityAddress;
            string ActivityPostCode;
            string ActivityDescription;
            decimal ActivityPrice;
            //create an imstance of the activities
            clsActivitiesCollection MyActivities = new clsActivitiesCollection();
            //var to store record count
            Int32 RecordCount;
            Int32 Index = 0;
            RecordCount = MyActivities.Count; //get the count of records in tblActivities
            lstActivities.Items.Clear();

            while (Index < RecordCount)//while there are records to procpes
            {
                //get these attributes
                ActivityID = MyActivities.ActivitiesList[Index].ActivityID;
                ActivityName = MyActivities.ActivitiesList[Index].ActivityName;
                ActivityCity = MyActivities.ActivitiesList[Index].ActivityCity;
                ActivityAddress = MyActivities.ActivitiesList[Index].ActivityAddress;
                ActivityPostCode = MyActivities.ActivitiesList[Index].ActivityPostCode;
                ActivityDescription = MyActivities.ActivitiesList[Index].ActivityDescription;
                ActivityPrice = Convert.ToDecimal(MyActivities.ActivitiesList[Index].ActivityPrice);
                //create the new entry for the list box
                ListItem NewEntry = new ListItem(ActivityName + "" + ActivityCity + "" + ActivityAddress + "" + ActivityPostCode + "" + ActivityDescription + "" + ActivityPrice + "", ActivityID.ToString());
                lstActivities.Items.Add(NewEntry); //add activities to the list
                Index++;
            }
            ////call the filter by activity name 
            //MyActivities.FilterByActivitiesName(ActivitiesNameFilter);

            ////point the list box at the activitylist collection
            //lstActivities.DataSource = MyActivities.ActivitiesList;
            ////tell it what field to display to user
            //lstActivities.DataTextField = "ActivitiyName";
            ////set pk value
            //lstActivities.DataValueField = "ActivityID";
            ////bind the data to the list and display it
            //lstActivities.DataBind();

            //return no of records found
            return RecordCount;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate it is a new record
            Session["ActivityID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AnActivity.aspx");

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store pk
            Int32 ActivityID;
            //if a record has been selected from the list
            if (lstActivities.SelectedIndex != -1)
            {
                //get pk value of record to edit
                ActivityID = Convert.ToInt32(lstActivities.SelectedValue);
                //store the data in the session objecct
                Session["ActivityID"] = ActivityID;
                //redirect to the edit page
                Response.Redirect("AnActivity.aspx");
            }
            else //if no record has been selected
            {
                //disaply error
                lblError.Text = "Please select a record you want to edit from the list ";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store pk for deleted record
            Int32 ActivityID;
            //if record has been selected
            if (lstActivities.SelectedIndex != -1)
            {
                //get pk value of the record to delete
                ActivityID = Convert.ToInt32(lstActivities.SelectedValue);
                //store data in the session object
                Session["ActivityID"] = ActivityID;
                //redirect to delete page
                Response.Redirect("ActivityDelete.aspx");
            }
            else
            {
                //display error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            Int32 RecordCount;
            RecordCount = DisplayActivities(txtAName.Text);
            lblError.Text = RecordCount + " staff members found";
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            Int32 RecordCount;
            RecordCount = DisplayActivities("");
            lblError.Text = "There are " + RecordCount + " records in this database";
            txtAName.Text = "";
        }
    }
}