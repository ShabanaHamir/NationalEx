using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class AnTripaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create a new instance of cls trip 
            clsTrip AnTrip = new clsTrip();
            // retrieve the trip date
            string TripDate = txtDate.Text;
            //retrieve the trip destination 
            string TripDestination = txtTripDestination.Text;
            //retrieve the vehicle trip 
            string VehicleType = txtVehicleType.Text;
            // create a variable to save erro messages 
            string Error = "";
            //create validation for presentation layer 
            if (Error =="")
            {
                //caputure the trip date 
                AnTrip.TripDate = Convert.ToDateTime(TripDate);
                //capture the trip destination 
                AnTrip.TripDestination = TripDate;
                //capture the vehicle type 
                AnTrip.VehicleType = VehicleType;
                //save the trip in the session object 
                Session["AnTrip"] = AnTrip;
                //redirect to the viewer page 
                Response.Redirect("TripViewer.aspx");
            }
            else
            {
                //pop up message says error
                lblError.Text = Error;
            }
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            //create an instance of the trip class 
            clsTrip AnTrip = new clsTrip();
            //variable to store the primary key
            Int32 TripID;
            Boolean Found = false;
            //get the primary key entered by the user 
            TripID = Convert.ToInt32(txtTripID.Text);
            //find the record 
            Found = AnTrip.Find(TripID);
            if (Found == true)
            {
                //display the values 
                txtTripID.Text = AnTrip.TripID.ToString();
                // clnTripDate.Text = AnTrip.TripDate.ToString();
                txtDate.Text = AnTrip.TripDate.ToString();
                txtTripDestination.Text = AnTrip.TripDestination;
                txtVehicleType.Text = AnTrip.VehicleType;
            }
        }
    }
}