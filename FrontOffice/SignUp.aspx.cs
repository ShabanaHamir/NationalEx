using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("AccountActivation.aspx");
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(email))
            {
                lblError.Text = "Email cannot be left empty";
                return;
            }

            if (password.Length < 8)
            {
                lblError.Text = "Password must be at least 8 characters";
                return;
            }

            if (password != confirmPassword)
            {
                lblError.Text = "Password does not match";
                return;
            }

            // Add code to register the new user account here

            // send an email to the user
            // replace the placeholders with your actual email sending code
            string subject = "Welcome to our website";
            string body = "Thank you for signing up on our website. Your account has been successfully created.";
            SendEmail(email, subject, body);

            lblError.Text = "An email has been sent to your account";
        }

        private void SendEmail(string email, string subject, string body)
        {
            throw new NotImplementedException();
        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //ENCYRPTION 
            txtPassword.TextMode = TextBoxMode.Password;

        }
    }
}