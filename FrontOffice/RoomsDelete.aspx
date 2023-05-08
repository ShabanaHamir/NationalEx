<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="RoomsDelete.aspx.cs" Inherits="FrontOffice.RoomsDelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this Room from National Experience Database?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click1" />
        <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" />
    </form>
</asp:Content>
