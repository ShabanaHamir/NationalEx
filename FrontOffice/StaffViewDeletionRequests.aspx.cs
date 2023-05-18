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
    public partial class StaffViewDeletionRequests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Redirect non-staff members
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

            if (!IsPostBack)
            {
                BindData();
            }
        }

        protected void ListBoxDeletionRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item
            string selectedRequest = lstDeletionRequests.SelectedItem.Text;
            // Process the selected request

            // Refresh the listbox
            BindData();
        }

        private void BindData()
        {
            // Call your method to fetch the pending requests
            // Replace 'YourDataClass' and 'GetPendingAccountDeletionRequests' with the name of your class and method
            DataTable dt = clsDeleteRequests.GetPendingAccountDeletionRequests();

            // Bind the data to the listbox
            lstDeletionRequests.DataSource = dt;
            lstDeletionRequests.DataTextField = "RequestID"; // Change to the appropriate column name
            lstDeletionRequests.DataBind();
        }

    }
}