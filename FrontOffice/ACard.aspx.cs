using System;
using Classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
    public partial class ACard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //Create an instance of clsCard
            clsCard ACard = new clsCard();
            //capture cardno
            ACard.CardNo = txtCardNo.Text;
            //store the cardno in the session object
            Session["ACard"] = ACard;
            //redirect to the viewer page
            Response.Redirect("CardViewer.aspx");
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            //create a new instance of clsactivity
            clsCard ACard = new clsCard();
            //var to store the PK
            Int32 CardID;
            //var to store the result of the find operation
            Boolean Found = false;
            //get the PK entered by the user
            CardID = Convert.ToInt32(txtCardID.Text);
            //find record
            Found = ACard.Find(CardID);
            //if found
            if (Found == true)
            {
                //display values of the properties in the form
                txtCardNo.Text = ACard.CardNo;
                txtCardName.Text = ACard.CardName;
                txtCardExpiry.Text = ACard.ExpiryDate;

            }
        }
    }
}