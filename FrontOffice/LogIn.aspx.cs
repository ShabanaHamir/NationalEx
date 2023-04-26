using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Classes;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("HotelDetails");
        }
    }
}