using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class AnTripaspx : System.Web.UI.Page
    {
        Int32 TripID;
        protected void Page_Load(object sender, EventArgs e)
        {
            TripID = Convert.ToInt32(Session["TripID"]);
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update list box
                DisplayTripDestination();
                //if this is not a new record
                if (TripID != -1)
                {
                    //display current data for thr record
                    DisplayTripDestination();
                }

            }
        }




        protected void btnOK_Click(object sender, EventArgs e)
        {
            ////create a new instance of cls trip 
            //clsTrip AnTrip = new clsTrip();
            //// retrieve the trip date
            //string TripDate = txtDate.Text;
            ////retrieve the trip destination 
            //string TripDestination = txtTripDestination.Text;
            ////retrieve the vehicle trip 
            //string VehicleType = txtVehicleType.Text;
            //// create a variable to save erro messages 
            //string Error = "";
            ////create validation for presentation layer 
            //if (Error == "")
            //{
            //    //caputure the trip date 
            //    AnTrip.TripDate = Convert.ToDateTime(TripDate);
            //    //capture the trip destination 
            //    AnTrip.TripDestination = TripDestination;
            //    //capture the vehicle type 
            //    AnTrip.VehicleType = VehicleType;
            //    //save the trip in the session object 
            //    Session["AnTrip"] = AnTrip;
            //    //redirect to the viewer page 
            //    Response.Redirect("TripViewer.aspx");
            //}
            //else
            //{
            //    //pop up message says error
            //    lblError.Text = Error;
            //}
            //add the new record 
            if (TripID == -1)
            {
                Add();
            }
            else
            {
                Update();
            }
        }

        //protected void btnFind_Click(object sender, EventArgs e)
        //{
        //    //create an instance of the trip class 
        //    clsTrip AnTrip = new clsTrip();
        //    //variable to store the primary key
        //    Int32 TripID;
        //    Boolean Found = false;
        //    //get the primary key entered by the user 
        //    TripID = Convert.ToInt32(txtTripID.Text);
        //    //find the record 
        //    Found = AnTrip.Find(TripID);
        //    if (Found == true)
        //    {
        //        //display the values 
        //        txtTripID.Text = AnTrip.TripID.ToString();
        //        // clnTripDate.Text = AnTrip.TripDate.ToString();
        //        txtDate.Text = AnTrip.TripDate.ToString();
        //        txtTripDestination.Text = AnTrip.TripDestination;
        //        txtVehicleType.Text = AnTrip.VehicleType;
        //    }
        //}

        void Add()
        {
            //create an instance of the trip 
            Classes.clsTripCollection Trips = new Classes.clsTripCollection();
            //validate the data from the web form 
            String Error = Trips.ThisTrip.Valid(txtDate.Text, txtTripDestination.Text, txtVehicleType.Text, txtTripSource.Text, Convert.ToDecimal(txtTicketCost.Text), txtTripStartTime.Text, txtTripEndTime.Text);
            // if the data is ok then add it to the object 
            if (Error == "")
            {
                //get the daata entered by the user 
                Trips.ThisTrip.TripDate = Convert.ToDateTime(txtDate.Text);
                Trips.ThisTrip.TripDestination = txtTripDestination.Text;
                Trips.ThisTrip.VehicleType = txtVehicleType.Text;
                Trips.ThisTrip.TripSource = txtTripSource.Text;
                Trips.ThisTrip.TicketCost = Convert.ToDecimal(txtTicketCost.Text);
                Trips.ThisTrip.TripDate = Convert.ToDateTime(txtTripStartTime.Text);
                Trips.ThisTrip.TripDate = Convert.ToDateTime(txtTripEndTime.Text);


                //add the record 
                Trips.Add();
                //redirect to the home page 
                Response.Redirect("TripDefault.aspx");


            }
            else
            {
                //pop up message says error
                lblError.Text = "there was an error" + Error;
            }
        }

        void Update()
        {
            //create an instance of the trip 
            Classes.clsTripCollection Trips = new Classes.clsTripCollection();
            //validate the data from the web form 
            String Error = Trips.ThisTrip.Valid(txtDate.Text, txtTripDestination.Text, txtVehicleType.Text, txtTripSource.Text, Convert.ToDecimal(txtTicketCost.Text), txtTripStartTime.Text, txtTripEndTime.Text);
            // if the data is ok then add it to the object 
            if (Error == "")
            {
                //Find the record 
                Trips.ThisTrip.Find(TripID);
                //get the daata entered by the user 
                Trips.ThisTrip.TripDate = Convert.ToDateTime(txtDate.Text);
                Trips.ThisTrip.TripDestination = txtTripDestination.Text;
                Trips.ThisTrip.VehicleType = txtVehicleType.Text;
                //add the record 
                Trips.Update();
                //redirect to the home page 
                Response.Redirect("TripDefault.aspx");


            }
            else
            {
                //pop up message says error
                lblError.Text = "there was an error" + Error;
            }
        }

        void DisplayTripDestination()
        {
            { //create an instance of the trip collection 
                Classes.clsTripCollection Trip = new Classes.clsTripCollection();
                Trip.ThisTrip.Find(TripID);
                //set the data source to the list of trips in the collection
                txtDate.Text = Trip.ThisTrip.TripDate.ToString();
                txtTripDestination.Text = Trip.ThisTrip.TripDestination;
                txtVehicleType.Text = Trip.ThisTrip.VehicleType;
                txtTripSource.Text = Trip.ThisTrip.TripSource;
                txtTicketCost.Text = Trip.ThisTrip.TicketCost.ToString();
                txtTripStartTime.Text = Trip.ThisTrip.TripStartTime.ToString();
                txtTripEndTime.Text = Trip.ThisTrip.TripEndTime.ToString();
            }
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            //create a new instance of Trip
            clsTrip AnTrip = new clsTrip();
            //var to store the PK
            Int32 TripID;
            //var to save the result of the find operation
            Boolean Found = false;

            TripID = Convert.ToInt32(txtTripID.Text);
            //find record
            Found = AnTrip.Find(TripID);
            //if found
            if (Found == true)
            {
                //display values of the properties in the form
                txtDate.Text = AnTrip.TripDate.ToString();
                txtTripDestination.Text = AnTrip.TripDestination;
                txtVehicleType.Text = AnTrip.VehicleType;
                txtTripSource.Text = AnTrip.TripSource;
                txtTicketCost.Text = AnTrip.TicketCost.ToString();
                txtTripStartTime.Text = AnTrip.TripStartTime.ToString();
                txtTripEndTime.Text = AnTrip.TripEndTime.ToString();
            }

        }






    }
}










