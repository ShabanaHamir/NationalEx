﻿using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class SignIn : System.Web.UI.Page
    {
        //create a copy of the security object with page level scope
        clsSecurity Sec;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get the current security state from the session
            //Sec = (clsSecurity)Session["Sec"];
            Sec = Session["Sec"] as clsSecurity ?? new clsSecurity();
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //update the security state in the session
            Session["Sec"] = Sec;
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            //clsSecurity Sec = new clsSecurity();
            Sec = new clsSecurity();
            String Error = Sec.SignIn(txtEMail.Text, txtPassword.Text);

            if (Error == "")
            {
                Session["UserID"] = Sec.UserID;  // Store UserID into session.
                if (Sec.AccountType == "Admin" || Sec.IsAdmin)
                {
                    // Redirect to the admin page
                    Response.Redirect("AdminDashboard.aspx");
                }
                else if (Sec.AccountType == "Staff")
                {
                    // Redirect to the staff page
                    Response.Redirect("StaffDashboard.aspx");
                }
                else if (Sec.AccountType == "Customer")
                {
                    // Redirect to the customer page
                    Response.Redirect("Default2.aspx");
                }
                else
                {
                    // Redirect to an error page or display a message for unknown account types
                    lblError.Text = "Unknown account type.";
                }
            }
            else
            {
                // Otherwise display any errors
                lblError.Text = Error;
            }

            ////clsDataConnection dataConnection = new clsDataConnection();
            ////try to sign in and record any errors there are
            //clsSecurity Sec = new clsSecurity();
            //String Error = Sec.SignIn(txtEMail.Text, txtPassword.Text);

            //if (Error == "")
            //{
            //    // Check if the user is an admin
            //    if (Sec.Admin)
            //    {
            //        // Redirect to the admin page
            //        Response.Redirect("StaffDashboard.aspx");
            //    }
            //    else
            //    {
            //        // Redirect to the main page for non-admin users
            //        Response.Redirect("Default2.aspx");
            //    }
            //}
            //else
            //{
            //    // Otherwise display any errors
            //    lblError.Text = Error;
            //}
        }


        protected void btnReSend_Click(object sender, EventArgs e)
        {
            //navigate to the re-send page
            Response.Redirect("ReSet.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //navigate back to default
            Response.Redirect("Default2.aspx");
        }

        protected void txtEMail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}