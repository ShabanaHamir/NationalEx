using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ViewCart : System.Web.UI.Page
    {
        clsCart MyCart = new clsCart();

        protected void Page_Load(object sender, EventArgs e)
        {
            //upon loading the page you need to read in the cart from the session object
            MyCart = (clsCart)Session["MyCart"];
            //display the cart contents
            DisplayCart();
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //you must also save the cart every time the unload event takes place
            Session["MyCart"] = MyCart;
        }

        void DisplayCart()
        {
            Int32 Index = 0;
            Int32 Count = MyCart.Products.Count;
            Response.Write("<table border =\"1\">");
            Response.Write("<tr>");
            Response.Write("<td>");
            Response.Write("Product Id");
            Response.Write("</td>");
            Response.Write("<td>");
            Response.Write("Quantity");
            Response.Write("</td>");
            Response.Write("<td>");
            Response.Write("");
            Response.Write("</td>");
            Response.Write("</tr>");
            Response.Write("</tr>");
            while (Index < Count)
            {
                Response.Write("<tr>");
                Response.Write("<td>");
                Response.Write(MyCart.Products[Index].ProductID);
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write(MyCart.Products[Index].QTY);
                Response.Write("</td>");
                Response.Write("<td>");
                Response.Write("<a href=\"Remove.aspx?Index=" + Index + "\">Remove</a>");
                Response.Write("</td>");
                Response.Write("</tr>");
                Index++;
            }
            Response.Write("</table>");
        }
    }
}