using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class StaffCustomerList : System.Web.UI.Page
    {
        Int32 UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserID = Convert.ToInt32(Session["UserID"]);
            if (IsPostBack == false)
            {
                //update list box
                DisplayUserNames();
                //IF this is a new record 
                if (UserID != -1)
                {
                    DisplayUserNames();
                }
            }
        }
        private void DisplayUserNames()
        {
            //create an instance of the user collection
            clsUserCollection Users = new clsUserCollection();
            // Report by first name and account type
            Users.ReportByFirstNameAndAccountType("", "Customer");
            //set the data source to the list of customers in the collection
            lstUser.DataSource = Users.UserList;
            //set the name of the PK
            lstUser.DataValueField = "UserID";
            //set data field to display 
            lstUser.DataTextField = "FirstName";
            //bind the data to the list
            lstUser.DataBind();
        }
        Int32 DisplayUser(string FirstNameFilter)
        {
            //create an instance of the user collection
            clsUserCollection MyUsers = new clsUserCollection();
            MyUsers.ReportByFirstNameAndAccountType(FirstNameFilter, "Customer");
            //var to store record count
            Int32 RecordCount;
            Int32 Index = 0;
            RecordCount = MyUsers.Count; //get the count of records
            lstUser.Items.Clear();

            while (Index < RecordCount)//while there are records to process
            {
                //get these attributes
                UserID = MyUsers.UserList[Index].UserID;
                string FirstName = MyUsers.UserList[Index].FirstName;
                string LastName = MyUsers.UserList[Index].LastName;
                string Email = MyUsers.UserList[Index].Email;
                string Password = MyUsers.UserList[Index].Password;
                string AccountType = MyUsers.UserList[Index].AccountType;
                //create the new entry for the list box
                ListItem NewEntry = new ListItem(UserID.ToString() + " " + FirstName + " " + LastName + " " + Email + " " + Password + " " + AccountType + " ");
                lstUser.Items.Add(NewEntry); //add activities to the list
                Index++;
            }
            return RecordCount;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate it is a new record
            Session["UserID"] = -1;
            //redirect to the data entry page
            Response.Redirect("AUser.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store pk
            Int32 UserID;
            //if a record has been selected from the list
            if (lstUser.SelectedIndex != -1)
            {
                //get pk value of record to edit
                UserID = Convert.ToInt32(lstUser.SelectedValue);
                //store the data in the session objecct
                Session["UserID"] = UserID;
                //redirect to the edit page
                Response.Redirect("AUser.aspx");
            }
            else //if no record has been selected
            {
                //disaply error
                lblError.Text = "Please select a record you want to edit from the list ";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ////var to store pk for deleted record
            //Int32 UserID;
            ////if record has been selected
            //if (lstUser.SelectedIndex != -1)
            //{
            //    //get pk value of the record to delete
            //    UserID = Convert.ToInt32(lstUser.SelectedValue);
            //    //store data in the session object
            //    Session["UserID"] = UserID;
            //    //redirect to delete page
            //    Response.Redirect("UserDelete.aspx");
            //}
            //else
            //{
            //    //display error
            //    lblError.Text = "Please select a record to delete from the list";
            //}
            //var to store pk for deleted record
            Int32 UserID;
            //if record has been selected
            if (lstUser.SelectedIndex != -1)
            {
                //try to parse the selected value to an integer
                bool success = Int32.TryParse(lstUser.SelectedValue, out UserID);
                //if parsing was successful
                if (success)
                {
                    //store data in the session object
                    Session["UserID"] = UserID;
                    //redirect to delete page
                    Response.Redirect("UserDelete.aspx");
                }
                else
                {
                    //display error
                    lblError.Text = "Invalid user ID";
                }
            }
            else
            {
                //display error
                lblError.Text = "Please select a record to delete from the list";
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            Int32 RecordCount;
            RecordCount = DisplayUser(txtUserName.Text);
            lblError.Text = RecordCount + " users found";
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            // Create an instance of the ActivitiesCollection class
            clsUserCollection userCollection = new clsUserCollection();
            // Filter the list to only include customers
            userCollection.ReportByFirstNameAndAccountType("", "Customer");

            // Bind the customer list to the ListBox control
            lstUser.DataSource = userCollection.UserList;
            lstUser.DataTextField = "FirstName"; // You can change this to display other properties if needed
            lstUser.DataValueField = "UserID"; // This will help you to identify the selected user later
            lstUser.DataBind();
        }
    }
}