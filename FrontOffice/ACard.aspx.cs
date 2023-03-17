using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ACard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //Create an instance of clsCard
            clsCard ACard = new clsCard();
            //capture cardno
            ACard.CardNo = txtCardNo.Text;
            //store the cardno in the session object
            Session["ACard"] = ACard;
            //redirect to the viewer page
            Response.Redirect("CardViewer.aspx");
        }
    }
}