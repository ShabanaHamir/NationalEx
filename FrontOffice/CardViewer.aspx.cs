using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class CardViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create a new instance of clsActivities
            clsCard ACard = new clsCard();
            //get the data from the session object
            ACard = (clsCard)Session["ACard"];
            //display the activity name for this entry
            Response.Write(ACard.CardNo);
        }
    }
}