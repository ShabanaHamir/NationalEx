using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FrontOffice
{
	public partial class Payment : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnOK_Click(object sender, EventArgs e)
        {
            //create a new instance of clsPayemnt
            clsPayment APayment = new clsPayment();
            //capture
            APayment.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            //store the hotel in the session object
            Session["APayment"] = APayment;
            //redirect to the viewer page
            Response.Redirect("PaymentViewer.aspx");
        }

        protected void txtPaymentType_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            //create a new instance of clsHotel
            clsPayment APayment = new clsPayment();
            //var to store the PK
            Int32 PaymentID;
            //var to store the result of the find operation
            Boolean Found = false;
            //get the PK entered by the user
            PaymentID = Convert.ToInt32(txtPaymentID.Text);
            //find record
            Found = APayment.Find(PaymentID);
            //if found
            if (Found == true)
            {
                //display values of the properties in the form
                txtCustomerID.Text = APayment.CustomerID.ToString();
                txtPaymentAmount.Text = APayment.PaymentAmount.ToString();
                txtPaymentDate.Text = APayment.PaymentDate.ToString();
                txtPaymentType.Text = APayment.PaymentType;


            }
        }
    }
}