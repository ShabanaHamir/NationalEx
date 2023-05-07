using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ActivitiesCustomer : System.Web.UI.Page
    {
        // Property to store the list of activities y
        public List<clsActivities> ActivitiesList { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadActivities();
            }
        }

        private void LoadActivities()
        {
            // Create an instance of the ActivitiesCollection class
            clsActivitiesCollection activitiesCollection = new clsActivitiesCollection();

            // Get all activities from the database
            ActivitiesList = activitiesCollection.GetAllActivities();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int activityId = 1; // replace with the activity ID of the item you want to add to cart
            string activityName = "Activity Name"; // replace with the name of the activity
            decimal activityPrice = 10.99M; // replace with the price of the activity
            int quantity = 1; // replace with the quantity of the activity

            // Add the item to the cart
            clsCart cart = Session["Cart"] as clsCart;
            if (cart == null)
            {
                cart = new clsCart();
                Session["Cart"] = cart;
            }
            cart.AddItemToCart(activityId, activityName, activityPrice, quantity);

            // Redirect to the checkout page
            Response.Redirect("~/Checkout.aspx");
        }
    }


}