<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="FrontOffice.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
       <asp:TextBox ID="txtFirstName" runat="server" Placeholder="First Name" />
        <asp:TextBox ID="txtEmail" runat="server" Placeholder="Email" />
        <asp:TextBox ID="txtCardNumber" runat="server" TextMode="Password" Placeholder="Card Number" />
        <asp:TextBox ID="txtNameOnCard" runat="server" Placeholder="Name on Card" />
        <asp:TextBox ID="txtExpiryDate" runat="server" Placeholder="Expiry Date (MM/YY)" />
        <asp:TextBox ID="txtCVV" runat="server" TextMode="Password" Placeholder="CVV" />
        <asp:DropDownList ID="ddlPaymentType" runat="server">
            <asp:ListItem Value="credit">Credit Card</asp:ListItem>
            <asp:ListItem Value="debit">Debit Card</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </form>
</asp:Content>
