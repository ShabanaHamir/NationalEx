﻿using System;
using Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class AnActivity : Form
    {
        public AnActivity()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
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

        private void btnAOK_Click(object sender, EventArgs e)
        {
            ////Create an instance of clsActivity
            //clsActivities AnActivity = new clsActivities();
            ////capture the activity name
            //AnActivity.ActivityName = txtAName.Text;
            ////store the activity in the session object
            //Session["AnActivity"] = AnActivity;
            ////redirect to the viewer page
            //Response.Redirect("ActivityViewer.aspx");
            //if (ActivityID == -1)
            //{
            //    Add();
            //}
            //else
            //{
            //    Update();
            //}
        }
    }
}

