using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using Classes;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace FrontOffice
{
    public partial class RoomListing : System.Web.UI.Page
    {
        //protected Repeater roomRepeater;
        protected void Page_Load(object sender, EventArgs e)
        {
                if (!IsPostBack)
                {
                    BindRoomData();
                }
        }

            private void BindRoomData()
            {
                    clsRoomCollection roomCollection = new clsRoomCollection();
                    List<clsRoom> rooms = roomCollection.GetAllRooms();

                    roomRepeater.DataSource = rooms;
                    roomRepeater.DataBind();
            }

            protected void addToCartButton_Click(object sender, EventArgs e)
            {
                // Retrieve the RoomId from the CommandArgument of the clicked button and perform the necessary logic.
                // You can add the room to the cart or redirect to a different page, depending on your requirements.
            }
       }
    
}