using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classes;

namespace FrontOffice
{
    public partial class TripListing : System.Web.UI.Page
    {
        //Int32 TripID;
        //private clsCart MyCart;
        //public List<clsTrip> TripList { get; set; }
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        LoadTrips();

        //        MyCart = (clsCart)Session["MyCart"];
        //        if (MyCart == null)
        //        {
        //            MyCart = new clsCart();
        //        }

        //        if (Session["ItemAdded"] != null && (bool)Session["ItemAdded"])
        //        {
        //            ScriptManager.RegisterStartupScript(this, GetType(), "TripAddedScript", "alert('Trip has been Added to Cart');", true);
        //            Session["ItemAdded"] = null;
        //        }
        //    }
        //}

        //private void LoadTrips()
        //{
        //    clsTripCollection tripCollection = new clsTripCollection();
        //    TripList = tripCollection.GetAllTrips();
        //    rptTrip.DataSource = TripList;
        //    rptTrip.DataBind();
        //}

        //protected void Page_UnLoad(object sender, EventArgs e)
        //{
        //    Session["MyCart"] = MyCart;
        //}

        //protected void addToCartButton_Click(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    RepeaterItem item = (RepeaterItem)btn.NamingContainer;

        //    TextBox txtQTY = (TextBox)item.FindControl("txtQTY");

        //    if (int.TryParse(txtQTY.Text, out int quantity))
        //    {
        //        clsCart cart = Session["Cart"] as clsCart;
        //        if (cart == null)
        //        {
        //            cart = new clsCart();
        //            Session["Cart"] = cart;
        //        }

        //        int tripID = Convert.ToInt32(btn.CommandArgument);

        //        clsTripCollection tripCollection = new clsTripCollection();
        //        clsTrip trip = tripCollection.GetTripByID(tripID);

        //        if (trip != null)
        //        {
        //            clsCartItem cartItem = new clsCartItem
        //            {
        //                ProductID = tripID,
        //                TripDestination = trip.TripDestination,
        //                TicketCost = trip.TicketCost,
        //                QTY = quantity,
        //                ItemType = "Trip"
        //            };

        //            cart.AddItem(cartItem);

        //            Response.Redirect(Request.RawUrl);

        //            ScriptManager.RegisterStartupScript(this, GetType(), "TripAddedScript", "alert('Trip has been Added to Cart');", true);
        //        }
        //    }
        //    else
        //    {
        //        Response.Write("Invalid quantity entered");
        //    }
        //}

        //protected void rptTrip_ItemCommand(object source, RepeaterCommandEventArgs e)
        //{
        //    if (e.CommandName == "AddToCart")
        //    {
        //        TextBox txtQTY = (TextBox)e.Item.FindControl("txtQTY");

        //        if (txtQTY == null)
        //        {
        //            Response.Write("Unable to find the quantity textbox.");
        //        }
        //    }
        //}
    }
}