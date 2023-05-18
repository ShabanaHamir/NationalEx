<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ShowRoomQuantity.aspx.cs" Inherits="FrontOffice.ShowRoomQuantity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
                         <a class="nav-link" href="Checkout.aspx">Checkout</a>

   <asp:GridView ID="gvCartItems" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="RoomType" HeaderText="Room Type" />
        <asp:BoundField DataField="RoomPrice" HeaderText="Price" DataFormatString="{0:C}" />
        <asp:BoundField DataField="QTY" HeaderText="Quantity" />
        <asp:BoundField DataField="Total" HeaderText="Total" DataFormatString="{0:C}" />
    </Columns>
</asp:GridView>


        <asp:Label ID="lblTotalPrice" runat="server"></asp:Label> 
    </form>

</asp:Content>
