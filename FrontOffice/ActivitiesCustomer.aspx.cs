using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ActivitiesCustomer : System.Web.UI.Page
    {
        // Property to store the list of activities y
        public List<clsActivities> ActivitiesList { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
//                LoadActivities();
            }
        }
    }
}