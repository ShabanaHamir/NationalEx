<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CustomerRequestDeletion.aspx.cs" Inherits="FrontOffice.CustomerRequestDeletion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <form id="form1" runat="server">
        <asp:Button ID="btnRequestDelete" runat="server" OnClick="btnRequestDelete_Click" Text="Send Request To Delete My Account" />
        <br />
        <asp:Label ID="lblFeedback" runat="server"></asp:Label>
    </form>
</asp:Content>
