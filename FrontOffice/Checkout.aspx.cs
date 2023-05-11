﻿using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected List<clsCartItem> CartItems;
        protected decimal TotalPrice;

        protected void Page_Load(object sender, EventArgs e)
        {

            clsCart cart = Session["Cart"] as clsCart;

            if (cart != null)
            {
                CartItems = cart.CartItems;
                TotalPrice = cart.GetTotalPrice();

                gvCartItems.DataSource = CartItems;
                gvCartItems.DataBind();
            }
            else
            {
                CartItems = new List<clsCartItem>();
                TotalPrice = 0;
            }

            // Set the text of the Total Price label control
            lblTotalPrice.Text = TotalPrice.ToString("C");
        }

        protected void LoadCart()
        {
            // Retrieve the cart from the session (you may need to adjust this depending on how you store the cart)
            clsCart cart = Session["Cart"] as clsCart;

            if (cart != null)
            {
                CartItems = cart.CartItems;
                TotalPrice = cart.GetTotalPrice();

                // Bind the cart items to the gridview
                gvCartItems.DataSource = CartItems;
                gvCartItems.DataBind();
            }
            else
            {
                CartItems = new List<clsCartItem>();
                TotalPrice = 0;
            }

            // Set the text of the Total Price label control
            lblTotalPrice.Text = TotalPrice.ToString("C");

        }
    }
}