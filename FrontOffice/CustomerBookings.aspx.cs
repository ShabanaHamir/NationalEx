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
    public partial class CustomerBookings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clsSecurity Sec = (clsSecurity)Session["Sec"];

            if (Sec == null || Sec.UserID == 0)
            {
                Response.Redirect("SignIn.aspx");
            }

            if (!IsPostBack)
            {
                clsDataConnection Db = new clsDataConnection();
                DataTable dt = Db.GetUserBookings(Sec.UserID);
                bookingsGridView.DataSource = dt;
                bookingsGridView.DataBind();
            }
        }
    }
}