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
            //capture the activity fields
            string ActivityName = txtAName.Text;
            string ActivityCity = txtACity.Text;
            string ActivityDescription = txtADescription.Text;
            string ActivityPrice = txtAPrice.Text;
            string ActivityPostCode = txtAPostcode.Text;
            string ActivityAddress= txtAAddress.Text;
            //variable to store error messages
            string Error = "";
            //validating the data
            Error = AnActivity.Valid(ActivityName, ActivityCity, ActivityAddress, ActivityDescription, ActivityPostCode,  ActivityPrice);
            AnActivity.ActivityName = ActivityName;
            AnActivity.ActivityCity = ActivityCity;
            AnActivity.ActivityAddress = ActivityAddress;
            AnActivity.ActivityDescription = ActivityDescription;
            AnActivity.ActivityPostCode = ActivityPostCode;
            AnActivity.ActivityPrice = Convert.ToDecimal(ActivityPrice);
            
            
            //store the activity in the session object
            Session["AnActivity"] = AnActivity;
            //redirect to the viewer page
            Response.Redirect("ActivityViewer.aspx");
        }

        //protected void btnAOK_Click(object sender, EventArgs e)
        //{
        //    //Create an instance of clsActivity
        //    clsActivities AnActivity = new clsActivities();
        //    //capture the activity fields
        //    AnActivity.ActivityName = txtAName.Text;
        //    AnActivity.ActivityCity = txtACity.Text;
        //    AnActivity.ActivityDescription = txtADescription.Text;
        //    AnActivity.ActivityPrice = Convert.ToDecimal(txtAPrice.Text);
        //    AnActivity.ActivityPostCode = txtAPostcode.Text;
        //    AnActivity.ActivityAddress = txtAAddress.Text;
        //    //store the activity in the session object
        //    Session["AnActivity"] = AnActivity;
        //    //redirect to the viewer page
        //    Response.Redirect("ActivityViewer.aspx");
        //}
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
                txtADescription.Text = AnActivity.ActivityDescription;
                txtAPrice.Text = AnActivity.ActivityPrice.ToString();
                txtAPostcode.Text = AnActivity.ActivityPostCode;
                txtAAddress.Text = AnActivity.ActivityAddress;

            }
        }
    }
}