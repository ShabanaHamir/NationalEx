using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class UserDelete : System.Web.UI.Page
    {
        Int32 UserID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //get number of staff to be deleted from the session object
            UserID = Convert.ToInt32(Session["UserID"]);
        }

        void DeleteUser()
        {
            //function to delete the selected record

            //create a new instance of jewellery system
            clsUserCollection MyUsers = new clsUserCollection();
            //find the record to delete
            MyUsers.ThisUser.Find(UserID);
            //delete the record
            MyUsers.Delete();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUser();
            Response.Redirect("UserDefault.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserDefault.aspx");
        }
    }
}