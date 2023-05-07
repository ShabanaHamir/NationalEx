using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static bool AddItemToCart(int activityId, string activityName, decimal activityPrice, int quantity)
        {
            // Retrieve the cart from the session (you may need to adjust this depending on how you store the cart)
            clsCart cart = HttpContext.Current.Session["Cart"] as clsCart;

            // If the cart doesn't exist, create a new one
            if (cart == null)
            {
                cart = new clsCart();
                HttpContext.Current.Session["Cart"] = cart;
            }

            // Add the activity to the cart
            cart.AddItemToCart(activityId, activityName, activityPrice, quantity);

            return true;
        }
    }
}