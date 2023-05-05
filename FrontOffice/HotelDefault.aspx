<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="HotelDefault.aspx.cs" Inherits="FrontOffice.HotelDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <asp:ListBox ID="lstHotels" runat="server" Width="421px"></asp:ListBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter a Hotel Post Code"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" Text="Apply" />
&nbsp;
        <asp:Button ID="btnDisplay" runat="server" Text="Show All" />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" Width="144px" />
&nbsp;
        <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="160px" />
&nbsp;
        <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="176px" />
    </form>
</asp:Content>
