<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="RoomDefault.aspx.cs" Inherits="FrontOffice.RoomDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <form id="form1" runat="server">
        <asp:ListBox ID="lstRooms" runat="server" Width="421px"></asp:ListBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter a Hotel ID"></asp:Label>
        <br />
        <asp:TextBox ID="txtHotelName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
&nbsp;
        <asp:Button ID="btnDisplay" runat="server" Text="Show All" OnClick="btnDisplay_Click" />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" Width="144px" OnClick="btnAdd_Click" />
&nbsp;
        <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="160px" OnClick="btnEdit_Click" />
&nbsp;
        <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="176px" OnClick="btnDelete_Click" />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</asp:Content>
