using System;
using System.Collections.Generic;
using System.Linq;
using Classes;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class RoomBooking : System.Web.UI.Page
    {
        Int32 ProductID; //roomID
        private clsCart MyCart;
        //property to store the list of rooms 
        public List<clsRoom> RoomList { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRooms();

                //retrieve the cart object from session state
                MyCart = (clsCart)Session["MyCart"];
                //if the cart object is null, create a new instance
                if (MyCart == null)
                {
                    MyCart = new clsCart();
                }
            }
        }


        private void LoadRooms()
        {
            // Create an instance of the RoomCollection class
            clsRoomCollection roomCollection = new clsRoomCollection();

            // Get all rooms from the database
            RoomList = roomCollection.GetAllRooms();
            // Bind the data to the Repeater control
            rptRooms.DataSource = RoomList;
            rptRooms.DataBind();
        }


        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //save the cart object back to session state
            Session["MyCart"] = MyCart;
        }

        protected void rptRooms_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "AddToCart")
            {
                TextBox txtQTY = (TextBox)e.Item.FindControl("txtQTY");

                if (txtQTY == null)
                {
                    Response.Write("Unable to find the quantity textbox.");
                    return;
                }

                if (string.IsNullOrEmpty(txtQTY.Text))
                {
                    Response.Write("Please enter a quantity.");
                    return;
                }

                if (!int.TryParse(txtQTY.Text, out int quantity))
                {
                    Response.Write("Invalid quantity entered. Please enter a valid number.");
                    return;
                }

                if (quantity <= 0)
                {
                    Response.Write("Quantity must be greater than 0.");
                    return;
                }


                //// Get the room details (name and price)
                //clsRoom room = RoomList.FirstOrDefault(r => r.RoomID == roomID);
                //if (room == null)
                //{
                //    Response.Write("Invalid Room ID. Room not found.");
                //    return;
                //}

                // Get the room ID from the CommandArgument property
                int roomID = Convert.ToInt32(e.CommandArgument);
                clsRoomCollection roomCollection = new clsRoomCollection();

                // Get the activity details
                clsRoom room = roomCollection.GetRoomByID(roomID);
                string roomName = room.RoomType;
                decimal roomPrice = room.RoomPrice;

                // Retrieve the cart from session or create a new one if it doesn't exist
                clsCart cart = Session["Cart"] as clsCart;
                if (cart == null)
                {
                    cart = new clsCart();
                    Session["Cart"] = cart;
                }

                // Add the selected room and quantity to the cart
                clsCartItem cartItem = new clsCartItem
                {
                    ProductID = roomID,
                    RoomName = roomName,
                    RoomPrice = roomPrice,
                    QTY = quantity,
                    //  ItemType = "Room"
                };
                cart.Products.Add(cartItem);

                // Redirect to the same page or another page to show cart items
                Response.Redirect("ShowQuantity.aspx");
            }
        }

    }
}

