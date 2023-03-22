<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="FrontOffice.Payment" %>

<script runat="server">


    protected void btnOK_Click(object sender, EventArgs e)
    {
        ////create a new instance of clsHotel
        //    clsPayment APayment = new clsPayment();
        //    //capture
        //    APayment.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //    //store the hotel in the session object
        //    Session["APayment"] = APayment;
        //    //redirect to the viewer page
        //    Response.Redirect("PaymentViewer.aspx");
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        Payment ID:
        <asp:TextBox ID="txtPaymenID" runat="server"></asp:TextBox>
        <br />
        Customer ID:<asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <br />
        Payment Amount:<asp:TextBox ID="txtPaymentAmount" runat="server"></asp:TextBox>
        <br />
        Payment Date:<asp:TextBox ID="txtPaymentDate" runat="server"></asp:TextBox>
        <br />
        Payment Type:<asp:TextBox ID="txtPaymentType" runat="server"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
    </form>
</asp:Content>
