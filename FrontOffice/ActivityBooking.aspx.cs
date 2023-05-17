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
        Int32 ProductID; //activityID
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
                // Check if an item has been added to the cart
                if (Session["ItemAdded"] != null && (bool)Session["ItemAdded"])
                {
                    // Display the "Activity Added to Cart" message
                    ScriptManager.RegisterStartupScript(this, GetType(), "ActivityAddedScript", "alert('Activity Added to Cart');", true);

                    // Clear the flag
                    Session["ItemAdded"] = null;
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
         
                int activityId = 0; // Placeholder value, use the actual activity ID

                // Add the selected activity and quantity to the cart
               
                clsCartItem cartItem = new clsCartItem
                {
                    ProductID = activityId,
                    QTY = quantity
                };
                cart.Products.Add(cartItem);

                // Redirect to the ShowQuantity page
                //Response.Redirect("ShowQuantity.aspx");
               
            }
            else
            {
                // Display an error message, e.g., using a Label control
                // lblError.Text = "Invalid quantity entered. Please enter a valid number.";
                Response.Write("Invalid quantity entered");
            }
        }



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
                int activityID = Convert.ToInt32(e.CommandArgument);
                clsActivitiesCollection activitiesCollection = new clsActivitiesCollection();

                // Get the activity details
                clsActivities activity = activitiesCollection.GetActivityByID(activityID);
                string activityName = activity.ActivityName;
                decimal activityPrice = activity.ActivityPrice;

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
                    ProductID = activityID,
                    ActivityName = activityName,
                    ActivityPrice = activityPrice,
                    QTY = quantity
                };
                cart.Products.Add(cartItem);


                Session["ItemAdded"] = true;

                // Redirect to the ShowQuantity page
                //Response.Redirect("ShowQuantity.aspx");
                // Refresh the current page instead of redirecting to the ShowQuantity page
                Response.Redirect(Request.RawUrl);

                // Display the "Activity Added to Cart" message
                ScriptManager.RegisterStartupScript(this, GetType(), "ActivityAddedScript", "alert('Activity Added to Cart');", true);
            }
        }



    }



}
