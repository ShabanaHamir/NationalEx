using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class CustomerViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create new instance of clsCustomer
            clsCustomer ACustomer = new clsCustomer();
            //get data from session object
            ACustomer = (clsCustomer)Session["ACustomer"];
            //display the customer name for this entry
            Response.Write(ACustomer.CustomerFName);
        }
    }
}