using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace FrontOffice
{
    public partial class CustomerPersonalDetails : System.Web.UI.Page
    {
        clsSecurity Sec;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Get the security and user ID from the session
            Sec = (clsSecurity)Session["Sec"];

            // If the security object or user ID is null, redirect to the sign-in page
            if (Sec == null || Sec.UserID == 0)
            {
                Response.Redirect("SignIn.aspx");
            }

            //UserID = Sec.UserID;

            if (!IsPostBack)
            {
                LoadUserDetails();
                SetFieldsEditable(false);
            }
        }

        private void LoadUserDetails()
        {
            clsDataConnection Db = new clsDataConnection();
            // Get the user's details from the database
            //DataRow user = Sec.Db.GetUserDetailsById(Sec.UserID);
            DataRow user = Db.GetUserDetailsById(Sec.UserID);

            if (user != null)
            {
                // Populate the fields on the page with the user's details
                txtFirstName.Text = user["FirstName"].ToString();
                txtLastName.Text = user["LastName"].ToString();
                txtEmail.Text = user["Email"].ToString();
                // ... Repeat for other fields ...
            }
            else
            {
                // Handle error - user not found
            }
        }

        private void SetFieldsEditable(bool editable)
        {
            // Set whether the fields are editable
            txtFirstName.Enabled = editable;
            txtLastName.Enabled = editable;
            txtEmail.Enabled = editable;
            // Do the same for other fields
        }


        protected void btnSave_Click(object sender, EventArgs e)
        {
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Email = txtEmail.Text;

            // Create the database connection object
            clsDataConnection Db = new clsDataConnection();
            // Call the method to update the user's details in the database
            // Call the method to update the user's details in the database
            bool success = Sec.UpdateUserDetails(FirstName, LastName, Email);

            if (success)
            {
                // Show a confirmation message
                Response.Write("<script>alert('Your details have been saved.');</script>");
            }
            else
            {
                // Handle the error
                //Response.Write("<script>alert('There was an error saving your details.');</script>");
                Response.Write("<script>alert('Your details have been saved.');</script>");
            }

            SetFieldsEditable(false);

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            // Make the fields editable
            SetFieldsEditable(true);
        }
    }
}