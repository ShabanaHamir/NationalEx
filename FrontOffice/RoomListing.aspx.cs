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
                //BindRoomData();
                LoadRooms();

                //retrieve the cart object from session state
                MyCart = (clsCart)Session["MyCart"];
                //if the cart object is null, create a new instance
                if (MyCart == null)
                {
                    MyCart = new clsCart();
                }
                // Check if an item has been added to the cart
                if (Session["ItemAdded"] != null && (bool)Session["ItemAdded"])
                {
                    // Display the "Activity Added to Cart" message
                    ScriptManager.RegisterStartupScript(this, GetType(), "RoomAddedScript", "alert('Room has been Added to Cart');", true);

                    // Clear the flag
                    Session["ItemAdded"] = null;
                }

            }
        }

        //private void BindRoomData()
        //{
        //    clsRoomCollection roomCollection = new clsRoomCollection();
        //    List<clsRoom> rooms = roomCollection.GetAllRooms();

        //    roomRepeater.DataSource = rooms;
        //    roomRepeater.DataBind();
        //}

        private void LoadRooms()
        {
            // Create an instance of the ActivitiesCollection class
            clsRoomCollection roomCollection = new clsRoomCollection();

            // Get all activities from the database
            RoomList = roomCollection.GetAllRooms();
            // Bind the data to the Repeater control
            rptRoom.DataSource = RoomList;
            rptRoom.DataBind();
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //save the cart object back to session state
            Session["MyCart"] = MyCart;
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

                //string roomType = room.RoomType;
                //decimal roomPrice = room.RoomPrice;

                if (room != null)
                {
                    // Create a new clsCartItem object with the room details
                    clsCartItem cartItem = new clsCartItem
                    {
                        ProductID = roomID,
                        RoomType = room.RoomType,
                        RoomPrice = room.RoomPrice,
                        QTY = quantity,
                        ItemType = "Room"
                    };

                    // Add the cart item to the cart
                    cart.AddItem(cartItem);

                    // Calculate the total price of the cart
                   // cart.CalculateTotalPrice();

                    // Redirect to the ShowRoomQuantity page with the quantity parameter
                //    Response.Redirect("ShowRoomQuantity.aspx?quantity=" + quantity.ToString());
                    Response.Redirect(Request.RawUrl);

                    // Display the "Activity Added to Cart" message
                    ScriptManager.RegisterStartupScript(this, GetType(), "RoomAddedScript", "alert('Room has been Added to Cart');", true);
                }
            }
            else
            {
                // Display an error message, e.g., using a Label control
                // lblError.Text = "Invalid quantity entered. Please enter a valid number.";
                Response.Write("Invalid quantity entered");
            }
        }

        protected void rptRooms_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
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

                    // Get the room ID from the CommandArgument property
                    int roomID = Convert.ToInt32(e.CommandArgument);
                    clsRoomCollection roomCollection = new clsRoomCollection();
                    clsRoom room = roomCollection.GetRoomByID(roomID);
                    string roomType = room.RoomType;
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
                        RoomType = roomType,
                        RoomPrice = roomPrice,
                        QTY = quantity
                    };
                    cart.Products.Add(cartItem);

                    // Redirect to the ShowQuantity page
                   // Response.Redirect("ShowRoomQuantity.aspx");
                    Response.Redirect(Request.RawUrl);

                    // Display the "Activity Added to Cart" message
                    ScriptManager.RegisterStartupScript(this, GetType(), "RoomAddedScript", "alert('Room has been Added to Cart');", true);
                }

            }

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            // Create an instance of the RoomCollection class
            clsRoomCollection roomCollection = new clsRoomCollection();

            // Get all rooms from the database
            RoomList = roomCollection.GetAllRooms();

            // Filter the RoomList based on the search term
            RoomList = RoomList.Where(r => r.RoomType.ToLower().Contains(searchTerm.ToLower())).ToList();

            // Bind the data to the Repeater control
            rptRoom.DataSource = RoomList;
            rptRoom.DataBind();
        }
    }
}