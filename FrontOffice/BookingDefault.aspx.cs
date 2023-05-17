using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class BookingDefault : System.Web.UI.Page
    {
        //variable to store PK with page levelscope
        Int32 BookingID;
        protected void Page_Load(object sender, EventArgs e)
        {
            BookingID = Convert.ToInt32(Session["BookingID"]);
            if (IsPostBack == false)
            {
                //update list box
                DisplayBookingDetails();
                //IF this is a new record 
                if (BookingID != -1)
                {
                    DisplayBookingDetails();
                }
            }
        }

        void DisplayBookingDetails()
        {
            
                //create an imstance of the activities
                clsBookingCollection Bookings = new clsBookingCollection();
                //set the data source to the list of activities in the collection
                lstBookings.DataSource = Bookings.BookingList;
                //set the name of the PK
                lstBookings.DataValueField = "BookingID";
                //set data field to display 
              //lstBookings.DataTextField = "BookingDate";
           
           //   lstBookings.DataTextField = "BookingDetails";
            //    lstBookings.DataTextField = "EMail";
                lstBookings.DataTextField = "FirstName";
              //  lstBookings.DataTextField = "UserID";
              //  lstBookings.DataTextField = "TotalCost";
                
               
               
                //bind the data to the list
                lstBookings.DataBind();
            
        }

        Int32 DisplayBookings(string EMailFilter)
        {
            //declare variables
            Int32 BookingID;
            DateTime BookingDate;
            string PaymentType;
            string BookingDetails;
            string EMail;
            string FirstName;
            int UserID;
            decimal TotalCost;
            //create an imstance of the activities
            clsBookingCollection MyBookings = new clsBookingCollection();
            MyBookings.ReportByEMail(EMailFilter);
            //var to store record count
            Int32 RecordCount;
            Int32 Index = 0;
            RecordCount = MyBookings.Count; //get the count of records in tblActivities
            lstBookings.Items.Clear();

            while (Index < RecordCount)//while there are records to procpes
            {
                //get these attributes
                BookingID = MyBookings.BookingList[Index].BookingID;
                BookingDate = MyBookings.BookingList[Index].BookingDate;
                PaymentType = MyBookings.BookingList[Index].PaymentType;
                BookingDetails = MyBookings.BookingList[Index].BookingDetails;
                EMail = MyBookings.BookingList[Index].EMail;
                FirstName = MyBookings.BookingList[Index].FirstName;
                UserID = MyBookings.BookingList[Index].UserID;
                TotalCost = MyBookings.BookingList[Index].TotalCost;
                //create the new entry for the list box
                ListItem NewEntry = new ListItem( BookingDate + " "+ PaymentType + " " + BookingDetails + " " + EMail + " " + FirstName + " " + UserID + " " + TotalCost + " ", BookingID.ToString());
               
                lstBookings.Items.Add(NewEntry); //add bookings to the list
                Index++;
            }
            
            //return no of records found
            return RecordCount;
        }
        protected void btnApply_Click(object sender, EventArgs e)
        {
            Int32 RecordCount;
            RecordCount = DisplayBookings(txtFirstName.Text);
            lblError.Text = RecordCount + " bookings found";
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            //  // Create an instance of the ActivitiesCollection class
            //  clsBookingCollection bookingCollection = new clsBookingCollection();

            //  // Get all activities from the database
            //  List<clsBooking> bookingList = bookingCollection.GetAllBookings();

            //  //   Bind the activities list to the ListBox control
            //  lstBookings.DataSource = bookingList;
            ////  lstBookings.DataTextField = "UserID";
            ////  lstBookings.DataTextField = "BookingDate";
            //  lstBookings.DataTextField = "FirstName";
            //  lstBookings.DataValueField = "BookingID";
            // // lstBookings.DataTextField = "EMail"; // This will help you to identify the selected activity later
            // lstBookings.DataBind();
            Int32 RecordCount;
            RecordCount = DisplayBookings("");
            lblError.Text = RecordCount + "Records of Bookings in our Database";
            txtFirstName.Text = "";



        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //store -1 into the session object to indicate it is a new record
            Session["BookingID"] = -1;
            //redirect to the data entry page
            Response.Redirect("ABooking.aspx");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //var to store pk
            Int32 BookingID;
            //if a record has been selected from the list
            if (lstBookings.SelectedIndex != -1)
            {
                //get pk value of record to edit
                BookingID = Convert.ToInt32(lstBookings.SelectedValue);
                //store the data in the session objecct
                Session["BookingID"] = BookingID;
                //redirect to the edit page
                Response.Redirect("ABooking.aspx");
            }
            else //if no record has been selected
            {
                //disaply error
                lblError.Text = "Please select a record you want to edit from the list ";
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //var to store pk for deleted record
            Int32 BookingID;
            //if record has been selected
            if (lstBookings.SelectedIndex != -1)
            {
                //get pk value of the record to delete
                BookingID = Convert.ToInt32(lstBookings.SelectedValue);
                //store data in the session object
                Session["BookingID"] = BookingID;
                //redirect to delete page
                Response.Redirect("BookingDelete.aspx");
            }
            else
            {
                //display error
                lblError.Text = "Please select a record to delete from the list";
            }
        }
    }
}