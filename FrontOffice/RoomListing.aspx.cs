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
        Int32 ProductID; //roomid
        //protected Repeater roomRepeater;

        private clsCart MyCart;
        public List<clsRoom> RoomList { get; set; }
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
            // Find the parent RepeaterItem for the clicked button
            Button btn = (Button)sender;
            RepeaterItem item = (RepeaterItem)btn.NamingContainer;

            // Find the txtQTY TextBox control within the RepeaterItem
            TextBox txtQTY = (TextBox)item.FindControl("txtQTY");

            // Try to get the selected quantity from the txtQTY TextBox
            if (int.TryParse(txtQTY.Text, out int quantity))
            {
                // Retrieve the cart from session or create a new one if it doesn't exist
                clsCart cart = Session["Cart"] as clsCart;
                if (cart == null)
                {
                    cart = new clsCart();
                    Session["Cart"] = cart;
                }

                // Get the RoomID
                int roomID = Convert.ToInt32(btn.CommandArgument);

                // Get the room details based on the RoomID
                clsRoomCollection roomCollection = new clsRoomCollection();
                clsRoom room = roomCollection.GetRoomByID(roomID);
                if (room != null)
                {
                    // Create a new clsCartItem object with the room details
                    clsCartItem cartItem = new clsCartItem
                    {
                        ProductID = roomID, //shows the qty
                        RoomType = room.RoomType,
                        RoomPrice = room.RoomPrice,
                        QTY = quantity
                    };

                    // Add the cart item to the cart
                    cart.AddItem(cartItem);
                }

                // Redirect to the ShowRoomQuantity page
                Response.Redirect("ShowRoomQuantity.aspx");
            }
            else
            {
                // Display an error message, e.g., using a Label control
                // lblError.Text = "Invalid quantity entered. Please enter a valid number.";
                Response.Write("Invalid quantity entered");
            }
        }

    }

}