using System;
using System.Collections.Generic;
using System.Linq;
using Classes;
using System.Text;
using System.Web;
using System.Configuration;
using System.Security.Cryptography;
using System.Threading.Tasks;

public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

       // string connectionString = GetConnectionString();
        // Use the connectionString variable to connect to the database



    }
   // private string GetConnectionString()
    //{
       // return ConfigurationManager.ConnectionStrings["IMAT3903ConnectionString"].ConnectionString;
    //}


    protected void btnSignUp_Click(object sender, EventArgs e)
    {

        clsDataConnection dataConnection = new clsDataConnection();
        // Use dataConnection.ConnectionString to connect to the database and save the user's information



        ////create a new instance of the security class
        //clsSecurity Sec = new clsSecurity();
        ////try to sign up using the supplied credentials
        //string Outcome = Sec.SignUp(txtEMail.Text, txtPassword1.Text, txtPassword2.Text, false);
        ////report the outcome of the operation
        //lblError.Text = Outcome;
        ////store the object in the session objec for other pages to access
        //Session["Sec"] = Sec;

        //create a new instance of the security class
        clsSecurity Sec = new clsSecurity();
        //try to sign up using the supplied credentials
        string Outcome = Sec.SignUp(txtEMail.Text, txtPassword1.Text, txtPassword2.Text, false);
        //report the outcome of the operation
        lblError.Text = Outcome;

        if (Outcome == "Account Created")
        {
            //create a new instance of the data connection class
            clsDataConnection SignUp = new clsDataConnection();
            //pass the connection string to the data connection class
            //    dataConnection.ConnectionString = GetConnectionString();
            //use the data connection class to insert a new user into the database
            dataConnection.Execute("INSERT INTO Users (Email, Password) VALUES ('" + txtEMail.Text + "', '" + txtPassword1.Text + "')");
        }

        //store the object in the session object for other pages to access
        Session["Sec"] = Sec;


    }


    //    }

    //    protected void btnSignUp_Click(object sender, EventArgs e)
    //    {
    //        //create a new instance of the security class
    //        clsSecurity Sec = new clsSecurity();
    //        //try to sign up using the supplied credentials
    //        string Outcome = Sec.SignUp(txtEMail.Text, txtPassword1.Text, txtPassword2.Text, false);
    //        //report the outcome of the operation
    //        lblError.Text = Outcome;
    //        //store the object in the session objec for other pages to access
    //        Session["Sec"] = Sec;
    //    }

    protected void btnDone_Click(object sender, EventArgs e)
    {
        //if done redirect to main page

        Response.Redirect("Default2.aspx");
    }

    protected void btnView_Click(object sender, EventArgs e)
    {
        //view the email
        Response.Redirect("EMailViewer.aspx");
    }

    protected void btnReSend_Click(object sender, EventArgs e)
    {
        //display re-set password form
        Response.Redirect("Default2.aspx");
    }



}