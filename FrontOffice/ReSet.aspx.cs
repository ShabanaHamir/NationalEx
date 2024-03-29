﻿using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ReSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReSet_Click(object sender, EventArgs e)
        {
            //create an instance of the security class
            clsSecurity Sec = new clsSecurity();
            //initiate the password re-set process
            string Outcome = Sec.ReSet(txtEMail.Text);
            //update the session variable
            Session["Sec"] = Sec;
            //display the outcome of the operation
            lblError.Text = Outcome;
        }

        protected void btnDone_Click(object sender, EventArgs e)
        {
            //go back to the main page
            Response.Redirect("Default2.aspx");
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            //redirect to the email viewer
            Response.Redirect("EMailViewer.aspx");
        }
    }
}