using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class AUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            clsUser AUser = new clsUser();
            //capture firstname
            AUser.FirstName = txtFirstName.Text;
            //store in session object
            Session["AUser"] = AUser;
            Response.Redirect("UserViewer.aspx");
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            clsUser AUser = new clsUser();
            //variable to store pk
            Int32 UserID;
            //variable to store result
            Boolean Found = false;
            //get pk
            UserID = Convert.ToInt32(txtUserID.Text);
            //find record
            Found = AUser.Find(UserID);
            //if found
            if (Found == true)
            {
                //display the values of the properties
                txtFirstName.Text = AUser.FirstName;
                txtLastName.Text = AUser.LastName;
                txtEmail.Text = AUser.Email;
                txtPassword.Text = AUser.Password;
                txtAccountType.Text = AUser.AccountType;
                
            }
        }
    }
}