using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Classes;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ShowQuantity : System.Web.UI.Page
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
            }
        }

        private void BindCartItems()
        {
            gvCartItems.DataSource = Cart.Products;
            gvCartItems.DataBind();
        }
    }
}
