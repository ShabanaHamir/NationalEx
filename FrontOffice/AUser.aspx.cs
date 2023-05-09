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
        Int32 UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserID = Convert.ToInt32(Session["UserID"]);
            if (IsPostBack == false)
            {
                //popukate lsit
                DisplayUserNames();
                //if this sint a new record
                if (UserID != -1)
                {
                    //display current data for record
                    DisplayUserNames();
                }
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
           if (UserID == -1)
            {
                Add();
            }
            else
            {
                Update();
            }
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
        //function to add new records
        void Add()
        {
            //create an instance of the activity collection
            clsUserCollection Users = new clsUserCollection();
            //validate data on web form
            //validate the data on the web form
            String Error = Users.ThisUser.Valid(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text, txtAccountType.Text);
            //if data is ok then add it to the object
            if (Error == "")
            {
                //get the data enetered by the user
                Users.ThisUser.FirstName = txtFirstName.Text;
                Users.ThisUser.LastName = txtLastName.Text;
                Users.ThisUser.Email = txtEmail.Text;
                Users.ThisUser.Password = txtPassword.Text;
                Users.ThisUser.AccountType = txtAccountType.Text;
                //add record
                Users.Add();
                //redirect to the main page
                Response.Redirect("UserDefault.aspx");
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
            clsUserCollection Users = new clsUserCollection();
            //validate the data on the web form
            //validate the data on the web form
            String Error = Users.ThisUser.Valid(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text, txtAccountType.Text);
            //if data is ok then add it to the object
            if (Error == "")
            {
                //find record to update
                Users.ThisUser.Find(UserID);
                //get the data entered by the user
                //get the data enetered by the user
                Users.ThisUser.FirstName = txtFirstName.Text;
                Users.ThisUser.LastName = txtLastName.Text;
                Users.ThisUser.Email = txtEmail.Text;
                Users.ThisUser.Password = txtPassword.Text;
                Users.ThisUser.AccountType = txtAccountType.Text;
                //update record
                Users.Update();
                //REDIRECT TO MAIN PAGE
                Response.Redirect("UserDefault.aspx");

            }
            else
            {
                //report error
                lblError.Text = "There were problems with the data entered " + Error;
            }
        }
        void DisplayUserNames()
        {
            {
                //create an instance of the activities collection
                clsUserCollection User = new clsUserCollection();
                //find record to update
                User.ThisUser.Find(UserID);
                //display data for this record
                txtFirstName.Text = User.ThisUser.FirstName;
                txtLastName.Text = User.ThisUser.LastName;
                txtEmail.Text = User.ThisUser.Email;
                txtPassword.Text = User.ThisUser.Password;
                txtAccountType.Text = User.ThisUser.AccountType;
            }
        }
    }
}