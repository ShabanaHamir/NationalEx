using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Classes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace BackOffice
{
 
    public partial class HotelForm : Form
    {
        private TextBox txtHotelID;
        private TextBox txtHotelName;
        private TextBox txtHotelPhoneNumber;
        private TextBox txtHotelPostCode;
        private Button btnOK;
        private Button btnFind;
        private Label lblError;

        public HotelForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // create a new instance of clsHotel
            clsHotel AnHotel = new clsHotel();

            string HotelName = txtHotelName.Text;
            string HotelPhoneNumber = txtHotelPhoneNumber.Text;
            string HotelPostCode = txtHotelPostCode.Text;

            // var to store any error messages
            string Error = "";

            // validate data
            Error = AnHotel.Valid(HotelName, HotelPhoneNumber, HotelPostCode);

            if (Error == "")
            {
                AnHotel.HotelName = HotelName;
                //    AnHotel.HotelPhoneNumber = HotelPhoneNumber;                      ERROR
                AnHotel.HotelPostCode = HotelPostCode;

                // store the hotel in the session object
            //   Session["AnHotel"] = AnHotel;
                // create an instance of the HotelViewer form
                HotelViewer hotelViewer = new HotelViewer();

                // show the form
                hotelViewer.Show();

                // hide the current form
                this.Hide();
            }
            else
            {
                // error
                lblError.Text = Error;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        //private void InitializeComponent()
        //{
        //    this.txtHotelID = new System.Windows.Forms.TextBox();
        //    this.txtHotelName = new System.Windows.Forms.TextBox();
        //    this.txtHotelPhoneNumber = new System.Windows.Forms.TextBox();
        //    this.txtHotelPostCode = new System.Windows.Forms.TextBox();
        //    this.btnOK = new System.Windows.Forms.Button();
        //    this.btnFind = new System.Windows.Forms.Button();
        //    this.lblError = new System.Windows.Forms.Label();
        //    this.SuspendLayout();
        //    // 
        //    // txtHotelID
        //    // 
        //    this.txtHotelID.Location = new System.Drawing.Point(12, 12);
        //    this.txtHotelID.Name = "txtHotelID";
        //    this.txtHotelID.Size = new System.Drawing.Size(100, 20);
        //    this.txtHotelID.TabIndex = 0;
        //    // 
        //    // txtHotelName
        //    // 
        //    this.txtHotelName.Location = new System.Drawing.Point(12, 38);
        //    this.txtHotelName.Name = "txtHotelName";
        //    this.txtHotelName.Size = new System.Drawing.Size(100, 20);
        //    this.txtHotelName.TabIndex = 1;
        //    // 
        //    // txtHotelPhoneNumber
        //    // 
        //    this.txtHotelPhoneNumber.Location = new System.Drawing.Point(12, 64);
        //    this.txtHotelPhoneNumber.Name = "txtHotelPhoneNumber";
        //    this.txtHotelPhoneNumber.Size = new System.Drawing.Size(100, 20);
        //    this.txtHotelPhoneNumber.TabIndex = 2;
        //    // 
        //    // txtHotelPostCode
        //    // 
        //    this.txtHotelPostCode.Location = new System.Drawing.Point(12, 90);
        //    this.txtHotelPostCode.Name = "txtHotelPostCode";
        //    this.txtHotelPostCode.Size = new System.Drawing.Size(100, 20);
        //    this.txtHotelPostCode.TabIndex = 3;
        //    // 
        //    // btnOK
        //    // 
        //    this.btnOK.Location = new System.Drawing.Point(12, 116);
        //    this.btnOK.Name = "btnOK";
        //    this.btnOK.Size = new System.Drawing.Size(75, 23);
        //    this.btnOK.TabIndex = 4;
        //    this.btnOK.Text = "OK";
        //    this.btnOK.UseVisualStyleBackColor = true;
        //    this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
        //    // 
        //    // btnFind
        //    // 
        //    this.btnFind.Location = new System.Drawing.Point(93, 116);
        //    this.btnFind.Name = "btnFind";
        //    this.btnFind.Size = new System.Drawing.Size(75, 23);
        //    this.btnFind.TabIndex = 5;
        //    this.btnFind.Text = "Find";
        //    this.btnFind.UseVisualStyleBackColor = true;
        //    this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
        //    // 
        //    // lblError
        //    // 
        //    this.lblError.AutoSize = true;
        //    this.lblError.Location = new System.Drawing.Point(12, 142);
        //    this.lblError.Name = "lblError";
        //    this.lblError.Size = new System.Drawing.Size(0, 13);
        //    this.lblError.TabIndex = 6;
        //    // 
        //    // HotelForm
        //    // 

    }
    }
