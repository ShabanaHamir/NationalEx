using System;
using System.Collections.Generic;
using Classes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class HotelsDelete : System.Web.UI.Page
    {
        //var to store PK
        Int32 HotelID;
        protected void Page_Load(object sender, EventArgs e)
        {
            //GET NUMBER OF THE HOTEL TO BE DELETED FROM THE SESSION OBJECT
            HotelID = Convert.ToInt32(Session["HotelID"]);
        }

        void DeleteHotel()
        {
            //function to delete the selected record
            //create a new instance of the hotel
            clsHotelCollection Hotels = new clsHotelCollection();
            //find the record to delete
            Hotels.ThisHotel.Find(HotelID);
            Hotels.Delete();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            //delete record
            DeleteHotel();
            //redirect
            Response.Redirect("StaffDashboard.aspx");
        }

        protected void btnYes_Click1(object sender, EventArgs e)
        {
            //delete record
            DeleteHotel();
            //redirect
            Response.Redirect("StaffDashboard.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("HotelDefault.aspx");
        }
    }
}