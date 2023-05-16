using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Classes;
using System.Web.UI.HtmlControls;

using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class HotelDetails : System.Web.UI.Page

    {
        //list to store hyperlinks
        List<HyperLink> hotelLinks = new List<HyperLink>();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Add the HyperLinks to the List
            hotelLinks.Add(HyperLink1);
            hotelLinks.Add(HyperLink2);
            hotelLinks.Add(HyperLink3);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("RoomBooking.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("RoomBooking.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("RoomBooking.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("RoomBooking.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim().ToLower();

            // Loop through the HyperLinks
            foreach (HyperLink hotelLink in hotelLinks)
            {
                string hotelName = hotelLink.Text.Trim().ToLower();

                // Find the parent cell of the HyperLink
                HtmlTableCell cell = (HtmlTableCell)hotelLink.Parent;
                // Find the parent row of the cell
                TableRow row = (TableRow)cell.Parent;

                if (hotelName.Contains(searchQuery))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

    }

}
