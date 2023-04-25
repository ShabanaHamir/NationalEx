<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AccountActivation.aspx.cs" Inherits="FrontOffice.AccountActivation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
<asp:Label ID="lblTo" runat="server"></asp:Label>
<br />
<asp:Label ID="lblFrom" runat="server"></asp:Label>
<br />
<asp:Label ID="lblSubject" runat="server"></asp:Label>

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the email address from the query string
        string email = Request.QueryString["email"];

        // Set the email details in the label controls
        lblTo.Text = "To: " + email;
        lblFrom.Text = "From: noreply@nationalexperience.uk";
        lblSubject.Text = "Subject: Account Activation";
    }
</script>
</asp:Content>
