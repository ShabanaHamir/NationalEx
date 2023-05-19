using System;
using System.Collections.Generic;
using System.Linq;
using Classes;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class HotelDetails : System.Web.UI.Page
    {
        //property to store the list of hotels 
        public List<clsHotel> HotelList { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadHotels();
            }
        }

        private void LoadHotels()
        {
            // Create an instance of the HotelCollection class
            clsHotelCollection hotelCollection = new clsHotelCollection();

            // Get all hotels from the database
            HotelList = hotelCollection.GetAllHotels();
            // Bind the data to the Repeater control
            rptHotel.DataSource = HotelList;
            rptHotel.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            // Create an instance of the HotelCollection class
            clsHotelCollection hotelCollection = new clsHotelCollection();

            // Get all hotels from the database
            HotelList = hotelCollection.GetAllHotels();

            // Filter the HotelList based on the search term
            HotelList = HotelList.Where(h => h.HotelCity.ToLower().Contains(searchTerm.ToLower())).ToList();

            // Bind the data to the Repeater control
            rptHotel.DataSource = HotelList;
            rptHotel.DataBind();
        }

        protected void rptHotels_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            //
        }
        protected void bookNowButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RoomListing.aspx");
        }
    }
}
