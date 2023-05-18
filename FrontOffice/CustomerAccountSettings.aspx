<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CustomerAccountSettings.aspx.cs" Inherits="FrontOffice.CustomerAccountSettings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <asp:Button ID="btnAccountDelete" runat="server" OnClick="btnAccountDelete_Click" Text="Delete My Account" />
    </form>
</asp:Content>
