<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ARoom.aspx.cs" Inherits="FrontOffice.ARoom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        Room ID:<asp:TextBox ID="txtRoomID" runat="server"></asp:TextBox>
        <br />
        Hotel ID:<asp:TextBox ID="txtHotelID" runat="server"></asp:TextBox>
        <br />
        Room Number:
        <asp:TextBox ID="txtRoomNumber" runat="server"></asp:TextBox>
        <br />
        Room Type:<asp:TextBox ID="txtRoomType" runat="server"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
    </form>
</asp:Content>
