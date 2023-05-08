using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Classes;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class RoomsDelete : System.Web.UI.Page
    {
        //var to store pk
        Int32 RoomID;
        protected void Page_Load(object sender, EventArgs e)
        {
            // GET Number of room to be deleted from session object
            RoomID = Convert.ToInt32(Session["RoomID"]);

        }

        void DeleteRoom()
        {
            clsRoomCollection Rooms = new clsRoomCollection();
            Rooms.ThisRoom.Find(RoomID);
            Rooms.Delete();
        }

        protected void btnYes_Click1(object sender, EventArgs e)
        {
            DeleteRoom();
            Response.Redirect("StaffDashboard.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("RoomDefault.aspx");
        }
    }
}