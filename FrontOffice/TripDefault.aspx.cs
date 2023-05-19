using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Classes;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class TripDefault : System.Web.UI.Page
    {
        Int32 TripID;
        protected void Page_Load(object sender, EventArgs e)
        {
            TripID = Convert.ToInt32(Session["TripID"]);
            if (IsPostBack == false)
            {
                DisplayTrips();
                if (TripID != -1)
                {
                    DisplayTrips();
                }
            }

        }
        protected void lstTrips_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void DisplayTrips()
        {
            //create an instance of the trip collection 
            Classes.clsTripCollection Trips = new Classes.clsTripCollection();
            //set the data source to the list of trips in the collection
            lstTrips.DataSource = Trips.TripList;
            //set the name of the primary key 
            lstTrips.DataValueField = "TripID";
            //set the data to display 
            lstTrips.DataTextField = "TripDestination";
            // bind the data to the list 
            lstTrips.DataBind();
        }

        Int32 DisplayTrips(string TripDestinationFilter)
        {
            //set variables
            Int32 TripID;
            DateTime TripDate;
            string TripDestination;
            string VehicleType;
            string TripSource;
            decimal TicketCost;
            DateTime TripStartTime;
            DateTime TripEndTime;

            //create an imstance of the trips
            clsTripCollection Trips = new clsTripCollection();
            Trips.ReportByTripDestination(TripDestinationFilter);
            //var to store record count
            Int32 RecordCount;
            Int32 Index = 0;
            RecordCount = Trips.Count; //get the count of records in tblActivities
            lstTrips.Items.Clear();

            while (Index < RecordCount)//while there are records to procpes
            {
                //get these attributes
                TripID = Trips.TripList[Index].TripID;
                TripDate = Convert.ToDateTime(Trips.TripList[Index].TripDate);
                TripDestination = Trips.TripList[Index].TripDestination;
                VehicleType = Trips.TripList[Index].VehicleType;
                TripSource = Trips.TripList[Index].TripSource;
                TicketCost = Convert.ToDecimal(Trips.TripList[Index].TicketCost);
                TripStartTime = Convert.ToDateTime(Trips.TripList[Index].TripStartTime);
                TripEndTime = Convert.ToDateTime(Trips.TripList[Index].TripEndTime);
                //create the new entry for the list box
                ListItem NewEntry = new ListItem(TripDate + " " + TripDestination + " " + VehicleType + " " + TripSource + " " + TicketCost + " " + TripStartTime + " " + TripEndTime, TripID.ToString());
                lstTrips.Items.Add(NewEntry); //add activities to the list
                Index++;
            }


            //return no of records found
            return RecordCount;
        }


        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            Int32 RecordCount;
            RecordCount = DisplayTrips("");
            lblError.Text = RecordCount + "Records for trips ";
            txtTripDestination.Text = "";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate this is a new record 
            Session["TripID"] = -1;
            //redirect to the data entry 
            Response.Redirect("AnTripaspx.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //variable to store the primary key value 
            Int32 TripID;
            //if a record has been selected from the list
            if (lstTrips.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit 
                TripID = Convert.ToInt32(lstTrips.SelectedValue);
                //store the data in the session object 
                Session["TripID"] = TripID;
                Response.Redirect("AnTripaspx.aspx");
            }
            else
            {
                lblError.Text = "Please select a record";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //variable to store the primary key 
            Int32 TripID;
            // if a record has been selected from the list 
            if (lstTrips.SelectedIndex != -1)
            {
                //get the primary key value to delete 
                TripID = Convert.ToInt32(lstTrips.SelectedValue);
                //store the data in the session 
                Session["TripID"] = TripID;
                //redirect to the delete page
                Response.Redirect("AnTripaspx.aspx");
            }
            else
            {
                lblError.Text = "please select a record ";
            }
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            Int32 RecordCount;
            RecordCount = DisplayTrips(txtTripDestination.Text);
            lblError.Text = RecordCount + "Trips has been shown";
        }
    }











}
