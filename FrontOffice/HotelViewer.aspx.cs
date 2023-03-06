using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class HotelViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //new instance 
            clsHotel AnHotel = new clsHotel();
            AnHotel = (clsHotel)Session["AnHotel"];
            Response.Write(AnHotel.HotelName);
        }
    }
}