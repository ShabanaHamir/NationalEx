using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class Confirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create a new instance of clsConfirmation
            clsConfirmation AConfirmation = new clsConfirmation();
            //capture
            AConfirmation.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            //store the hotel in the session object
            Session["AConfirmation"] = AConfirmation;
            //redirect to the viewer page
            Response.Redirect("ConfirmationViewer.aspx");
        }
    }
}