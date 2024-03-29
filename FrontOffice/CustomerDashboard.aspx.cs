﻿using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class CustomerDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsSecurity Sec;
            if (Session["Sec"] != null)
            {
                Sec = (clsSecurity)Session["Sec"];
                int UserID = Sec.UserID;
            }
            else
            {
                Response.Redirect("SignIn.aspx");
            }

        }


        protected void btnMyDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerPersonalDetails.aspx");
        }

        protected void btnBookings_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerBookings.aspx");
        }

        protected void btnAccountSettings_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerAccountSettings.aspx");
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReSet.aspx");
        }

        protected void btnSignOut_Click(object sender, EventArgs e)
        {
            // Logout from the session or authentication
            Session.Clear();
            Session.Abandon();
            // If you're using Forms Authentication
            System.Web.Security.FormsAuthentication.SignOut();
            Response.Redirect("Default2.aspx");
        }
    }
}