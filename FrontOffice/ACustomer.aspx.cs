using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ACustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create a new instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //capture customer f name
            ACustomer.CustomerFName = txtCustomerFName.Text;
            //store the customer in the session object
            Session["ACustomer"] = ACustomer;
            //redirect to the viewer page
            Response.Redirect("CustomerViewer.aspx");

        }
    }
}