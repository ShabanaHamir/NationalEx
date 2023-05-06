<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="HotelsDelete.aspx.cs" Inherits="FrontOffice.HotelsDelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this Hotel?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" OnClick="Button2_Click" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" Text="No" />
    </form>
</asp:Content>
