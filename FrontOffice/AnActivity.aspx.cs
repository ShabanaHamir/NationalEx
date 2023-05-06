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
        Int32 ActivityID;
        protected void Page_Load(object sender, EventArgs e)
        {
            ActivityID = Convert.ToInt32(Session["ActivityID"]);
            if (IsPostBack == false)
            {
                //popukate lsit
                DisplayActivityNames();
                //if this sint a new record
                if (ActivityID != -1)
                {
                    //display current data for record
                    DisplayActivityNames();
                }
            }
        }

        protected void btnAOK_Click(object sender, EventArgs e)
        {
            if (ActivityID == -1)
            {
                Add();
            }
            else
            {
                Update();
            }
            ////Create an instance of clsActivity
            //clsActivities AnActivity = new clsActivities();
            ////capture the activity fields
            //string ActivityName = txtAName.Text;
            //string ActivityCity = txtACity.Text;
            //string ActivityAddress = txtAAddress.Text;
            //string ActivityPostCode = txtAPostcode.Text;
            //string ActivityDescription = txtADescription.Text;
            //int NoOfPeople = Convert.ToInt32(txtNoOfPeople.Text);
            //decimal ActivityPrice = Convert.ToDecimal(txtAPrice.Text);
            ////variable to store error messages
            //string Error = "";
            ////validating the data

            //if (Error == "")
            //{
            //    Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode, ActivityPrice, NoOfPeople);
            //    AnActivity.ActivityName = ActivityName;
            //    AnActivity.ActivityCity = ActivityCity;
            //    AnActivity.ActivityAddress = ActivityAddress;
            //    AnActivity.ActivityPostCode = ActivityPostCode;
            //    AnActivity.ActivityDescription = ActivityDescription;
            //    AnActivity.NoOfPeople = NoOfPeople;
            //    AnActivity.ActivityPrice = ActivityPrice;
            //    //store the activity in the session object
            //    Session["AnActivity"] = AnActivity;
            //    //redirect to the viewer page
            //    Response.Redirect("ActivityViewer.aspx");
            //}

            //else
            //{
            //    //display the error message
            //    lblError.Text = Error;
            //}
        }
        protected void btnACancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ActivityDefault.aspx");
        }
        
        protected void btnFind_Click(object sender, EventArgs e)
        {
            //create a new instance of clsactivity
            clsActivities AnActivity = new clsActivities();
            //var to store the PK
            Int32 ActivityID;
            //var to store the result of the find operation
            Boolean Found = false;
            //get the PK entered by the user
            ActivityID = Convert.ToInt32(txtActivityID.Text);
            //find record
            Found = AnActivity.Find(ActivityID);
            //if found
            if (Found == true)
            {
                //display values of the properties in the form
                txtAName.Text = AnActivity.ActivityName;
                txtACity.Text = AnActivity.ActivityCity;
                txtAAddress.Text = AnActivity.ActivityAddress;
                txtADescription.Text = AnActivity.ActivityDescription;
                txtAPostcode.Text = AnActivity.ActivityPostCode;
                txtNoOfPeople.Text = AnActivity.NoOfPeople.ToString();
                txtAPrice.Text = AnActivity.ActivityPrice.ToString();
            }
            
        }

        

        //function to add new records
        void Add()
        {
            //create an instance of the activity collection
            clsActivitiesCollection MyActivities = new clsActivitiesCollection();
            //validate data on web form
            //validate the data on the web form
            String Error = MyActivities.ThisActivity.Valid(txtAName.Text, txtACity.Text, txtAAddress.Text, txtADescription.Text, txtAPostcode.Text, Convert.ToInt32(txtNoOfPeople.Text), Convert.ToDecimal(txtAPrice.Text));
            //if data is ok then add it to the object
            if (Error == "")
            {
                //get the data enetered by the user
                MyActivities.ThisActivity.ActivityName = txtAName.Text;
                MyActivities.ThisActivity.ActivityCity = txtACity.Text;
                MyActivities.ThisActivity.ActivityAddress = txtAAddress.Text;
                MyActivities.ThisActivity.ActivityDescription = txtADescription.Text;
                MyActivities.ThisActivity.ActivityPostCode = txtAPostcode.Text;
                MyActivities.ThisActivity.NoOfPeople = Convert.ToInt32(txtNoOfPeople.Text);
                MyActivities.ThisActivity.ActivityPrice = Convert.ToDecimal(txtAPrice.Text);

                //add record
                MyActivities.Add();
                //redirect to the main page
                Response.Redirect("ActivityDefault.aspx");
            }
            else
            {
                //report eror
                lblError.Text = "There was a problem with the data entered " + Error;
            }
        }

        void Update()
        {
            //create an instance of the jewellery system
            clsActivitiesCollection MyActivities = new clsActivitiesCollection();
            //validate the data on the web form
            //validate the data on the web form
            String Error = MyActivities.ThisActivity.Valid(txtAName.Text, txtACity.Text, txtAAddress.Text, txtADescription.Text, txtAPostcode.Text, Convert.ToInt32(txtNoOfPeople.Text), Convert.ToDecimal(txtAPrice.Text));

            //if data is ok then add it to the object
            if (Error == "")
            {
                //find record to update
                MyActivities.ThisActivity.Find(ActivityID);
                //get the data entered by the user
                //get the data enetered by the user
                MyActivities.ThisActivity.ActivityName = txtAName.Text;
                MyActivities.ThisActivity.ActivityCity = txtACity.Text;
                MyActivities.ThisActivity.ActivityAddress = txtAAddress.Text;
                MyActivities.ThisActivity.ActivityDescription = txtADescription.Text;
                MyActivities.ThisActivity.ActivityPostCode = txtAPostcode.Text;
                MyActivities.ThisActivity.NoOfPeople = Convert.ToInt32(txtNoOfPeople.Text);
                MyActivities.ThisActivity.ActivityPrice = Convert.ToDecimal(txtAPrice.Text);
                //update record
                MyActivities.Update();
                //REDIRECT TO MAIN PAGE
                Response.Redirect("ActivityDefault.aspx");

            }
            else
            {
                //report error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }

        void DisplayActivityNames()
        {
            {
                //create an instance of the activities collection
                clsActivitiesCollection Activity = new clsActivitiesCollection();
                //find record to update
                Activity.ThisActivity.Find(ActivityID);
                //display data for this record
                txtAName.Text = Activity.ThisActivity.ActivityName;
                txtACity.Text = Activity.ThisActivity.ActivityCity;
                txtAAddress.Text = Activity.ThisActivity.ActivityAddress;
                txtADescription.Text = Activity.ThisActivity.ActivityDescription;
                txtAPostcode.Text = Activity.ThisActivity.ActivityPostCode;
                txtNoOfPeople.Text = Activity.ThisActivity.NoOfPeople.ToString();
                txtAPrice.Text = Activity.ThisActivity.ActivityPrice.ToString();
            }
        }
    }
}