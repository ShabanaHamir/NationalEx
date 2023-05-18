using System;
using Classes;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace FrontOffice
{
    public partial class Checkout : System.Web.UI.Page
    {
        protected List<clsCartItem> CartItems;
        protected decimal TotalPrice;

        protected void Page_Load(object sender, EventArgs e)
        {
            // If the page is not being loaded in response to a postback...
            if (!IsPostBack)
            {
                // Load the cart from the session
                var cart = Session["Cart"] as clsCart;
                if (cart == null || cart.Products.Count == 0)
                {
                    // If there's no cart in the session, or if the cart is empty,
                    // redirect the user back to the Activities page
                    Response.Redirect("ActivityBooking.aspx");
                }
            }
        }

        //protected void LoadCart()
        //{
        //    // Retrieve the cart from the session (you may need to adjust this depending on how you store the cart)
        //    clsCart cart = Session["Cart"] as clsCart;

        //    if (cart != null)
        //    {
        //        CartItems = cart.CartItems;
        //        TotalPrice = cart.GetTotalPrice();

        //        // Bind the cart items to the gridview
        //        gvCartItems.DataSource = CartItems;
        //        gvCartItems.DataBind();
        //    }
        //    else
        //    {
        //        CartItems = new List<clsCartItem>();
        //        TotalPrice = 0;
        //    }

        //    // Set the text of the Total Price label control
        //    lblTotalPrice.Text = TotalPrice.ToString("C");

        //}
        private string GenerateBookingDetails(clsCart cart)
        {
            var details = new StringBuilder();

            foreach (var item in cart.Products)
            {
                if (item.ItemType == "Room")
                {
                    details.Append($"{item.QTY} x {item.RoomType} ({item.RoomPrice:C}), ");
                }
                else if (item.ItemType == "Activity")
                {
                    // replace with correct properties for the activity type
                    details.Append($"{item.QTY} x {item.ActivityName} ({item.ActivityPrice:C}), ");
                }
            }

            // Remove the trailing comma and space
            if (details.Length > 2)
            {
                details.Length -= 2;
            }

            return details.ToString();
            //var details = new StringBuilder();

            //foreach (var item in cart.Products)
            //{
            //    details.Append($"{item.QTY} x {item.ActivityName} ({item.ActivityPrice:C}), ");
            //}

            //// Remove the trailing comma and space
            //if (details.Length > 2)
            //{
            //    details.Length -= 2;
            //}

            //return details.ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            clsCart cart = Session["Cart"] as clsCart;
            // Validate the user's input...
            string firstName = txtFirstName.Text;
            string email = txtEmail.Text;
            string paymentType = ddlPaymentType.SelectedValue; // Assuming you have a DropDownList for payment type
            string bookingDetails = GenerateBookingDetails(cart);
            decimal totalCost = cart.GetTotalPrice();
            // Validate more fields...

            // Process the payment...

            

            

            if (cart != null)
            {
                totalCost = cart.GetTotalPrice();
            }

            // If the payment is successful, create a booking
            clsBooking booking = new clsBooking
            {
                // Set the booking properties...
                FirstName = firstName,
                EMail = email,
                PaymentType = paymentType,
                BookingDetails = bookingDetails,
                TotalCost = totalCost,
                BookingDate = DateTime.Now
                // Set more properties...
            };

            // Insert the booking into the database...
            clsBookingCollection bookingCollection = new clsBookingCollection();
            bookingCollection.ThisBooking = booking;
            bookingCollection.Add();

            // Clear the cart
            Session["Cart"] = null;

            // Redirect the user to a "Thank You" page
            Response.Redirect("ThankYou.aspx");
        }

        private void CreateBooking(string firstName, string email, string paymentType, string bookingDetails, decimal totalCost)
        {
            // Create a connection to your database
            using (SqlConnection conn = new SqlConnection("YourConnectionStringHere"))
            {
                // Create a command to insert a new booking
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO tblBooking (BookingDate, PaymentType, BookingDetails, Email, FirstName, TotalCost) " +
                    "VALUES (@BookingDate, @PaymentType, @BookingDetails, @Email, @FirstName, @TotalCost)", conn))
                {
                    // Add the parameter values
                    cmd.Parameters.AddWithValue("@BookingDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@PaymentType", paymentType);
                    cmd.Parameters.AddWithValue("@BookingDetails", bookingDetails);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@TotalCost", totalCost);

                    // Open the connection and execute the command
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
