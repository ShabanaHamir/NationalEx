<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="FrontOffice.Confirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        Customer ID:<asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <br />
        Email:<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
    </form>
</asp:Content>
