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
    }
}