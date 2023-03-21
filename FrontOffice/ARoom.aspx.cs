using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ARoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create a new instance of clsHotel
            clsRoom ARoom = new clsRoom();
            //capture
            ARoom.HotelID = Convert.ToInt32(txtHotelID.Text);
            //store the hotel in the session object
            Session["ARoom"] = ARoom;
            //redirect to the viewer page
            Response.Redirect("RoomViewer.aspx");
          ;
        }
    }
}