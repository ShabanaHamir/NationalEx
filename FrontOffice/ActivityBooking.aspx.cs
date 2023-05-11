using System;
using System.Collections.Generic;
using System.Linq;
using Classes;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ActivityBooking : System.Web.UI.Page
    {
        //clsCart MyCart = new clsCart();
        Int32 ProductID;
        private clsCart MyCart;
        //property t store the list of activities 
        public List<clsActivities> ActivitiesList { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadActivities();

                //retrieve the cart object from session state
                MyCart = (clsCart)Session["MyCart"];
                //if the cart object is null, create a new instance
                if (MyCart == null)
                {
                    MyCart = new clsCart();
                }
            }
        }


        private void LoadActivities()
        {
            // Create an instance of the ActivitiesCollection class
            clsActivitiesCollection activitiesCollection = new clsActivitiesCollection();

            // Get all activities from the database
            ActivitiesList = activitiesCollection.GetAllActivities();
            // Bind the data to the Repeater control
            rptActivities.DataSource = ActivitiesList;
            rptActivities.DataBind();
        }


        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //save the cart object back to session state
            Session["MyCart"] = MyCart;
        }


        //protected void btnAdd_Click(object sender, EventArgs e)
        //{
        //    // Get the entered quantity
        //    int enteredQuantity = Convert.ToInt32(txtQTY.Text);

        //    // Redirect to the ShowQuantity page with the entered quantity as a query parameter
        //    Response.Redirect($"ShowQuantity.aspx?quantity={enteredQuantity}");
        //}
        protected void btnAdd_Click(object sender, EventArgs e)
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

                // Get the activity ID
                // Replace this line with your actual logic for getting the activity ID from the RepeaterItem
                int activityId = 0; // Placeholder value, use the actual activity ID

                // Add the selected activity and quantity to the cart
                // Replace the following lines with your actual logic for adding the item to the cart
                clsCartItem cartItem = new clsCartItem
                {
                    ProductID = activityId,
                    QTY = quantity
                };
                cart.Products.Add(cartItem);

                // Redirect to the ShowQuantity page
                Response.Redirect("ShowQuantity.aspx");
            }
            else
            {
                // Display an error message, e.g., using a Label control
                // lblError.Text = "Invalid quantity entered. Please enter a valid number.";
                Response.Write("Invalid quantity entered");
            }
        }

        //protected void rptActivities_ItemCommand(object source, RepeaterCommandEventArgs e)
        //{
        //    if (e.CommandName == "AddToCart")
        //    {
        //        TextBox txtQTY = (TextBox)e.Item.FindControl("txtQTY");

        //        if (txtQTY != null)
        //        {
        //            // Try to get the selected quantity from the txtQTY TextBox
        //            if (int.TryParse(txtQTY.Text, out int quantity))
        //            {
        //                // Get the activity ID from the CommandArgument property
        //                int activityId = Convert.ToInt32(e.CommandArgument);

        //                // Add the selected activity and quantity to the cart
        //                // Replace the following line with your actual logic for adding the item to the cart
        //                // MyCart.AddItem(activityId, quantity);

        //                // Store the updated cart back in the session
        //                Session["MyCart"] = MyCart;

        //                // Redirect to the ShowQuantity page, passing the selected quantity as a query string parameter
        //                Response.Redirect($"ShowQuantity.aspx?quantity={quantity}");
        //            }
        //            else
        //            {
        //                // Display an error message, e.g., using a Label control
        //                Response.Write("Invalid quantity entered. Please enter a valid number.");
        //            }
        //        }
        //        else
        //        {
        //            // Display an error message, e.g., using a Label control
        //            Response.Write("Unable to find the quantity textbox.");
        //        }
        //    }
        //}
        protected void rptActivities_ItemCommand(object source, RepeaterCommandEventArgs e)
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

                // Get the activity ID from the CommandArgument property
                int activityId = Convert.ToInt32(e.CommandArgument);

                // Retrieve the cart from session or create a new one if it doesn't exist
                clsCart cart = Session["Cart"] as clsCart;
                if (cart == null)
                {
                    cart = new clsCart();
                    Session["Cart"] = cart;
                }

                // Add the selected activity and quantity to the cart
                clsCartItem cartItem = new clsCartItem
                {
                    ProductID = activityId,
                    QTY = quantity
                };
                cart.Products.Add(cartItem);

                // Redirect to the ShowQuantity page
                Response.Redirect("ShowQuantity.aspx");
            }
        }




    }



}
