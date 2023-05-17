using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Classes;

namespace FrontOffice
{
    public partial class ShowRoomQuantity : System.Web.UI.Page
    {
        clsCart Cart;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Cart"] == null)
            {
                Session["Cart"] = new clsCart();
            }

            Cart = (clsCart)Session["Cart"];

            if (!IsPostBack)
            {
                if (Request.QueryString["quantity"] != null)
                {
                    int quantity = Convert.ToInt32(Request.QueryString["quantity"]);
                    // Add code to update the cart item quantity here
                }

                BindCartItems();
                CalculateTotalPrice(); // Calculate and display the total price
            }
        }

        private void BindCartItems()
        {
            // Retrieve the cart from session
            clsCart cart = Session["Cart"] as clsCart;
            if (cart != null)
            {
                // Bind the cart items to the GridView
                gvCartItems.DataSource = cart.Products;
                gvCartItems.DataBind();
            }
        }

        private void CalculateTotalPrice()
        {
            // Retrieve the cart from session
            clsCart cart = Session["Cart"] as clsCart;
            if (cart != null)
            {
                // Calculate the total price of all items in the cart
                decimal totalPrice = cart.Products.Sum(item => item.Total);
                lblTotalPrice.Text = "Total Price: " + totalPrice.ToString("C");
            }
        }
    }
}
