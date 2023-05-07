using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class UserViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsUser AUser = new clsUser();
            AUser = (clsUser)Session["AUser"];
            Response.Write(AUser.FirstName);
        }
    }
}