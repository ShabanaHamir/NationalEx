<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="FrontOffice.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <h1>Checkout</h1>
    <form id="form1" runat="server">
    <table class="table">
        <thead>
            <tr>
                <th>Activity Name</th>
                <th>Price</th>
                <th>Quantity</th>
                <th>Total</th>
            </tr>
        </thead>
       <tbody>
    <% foreach (var item in CartItems) { %>
        <tr>
            <td><%= item.ActivityName %></td>
            <td><%= item.ActivityPrice.ToString("C") %></td>
            <td><%= item.Quantity %></td>
            <td><%= (item.ActivityPrice * item.Quantity).ToString("C") %></td>
        </tr>
    <% } %>
    <tr>
        <td colspan="3" class="text-right">Total:</td> 
        <td><asp:Label ID="lblTotalPrice" runat="server" Text=""></asp:Label></td>
    </tr>
</tbody>

    </table>
    <button type="button" class="btn btn-primary">Proceed to Payment</button>

    <asp:GridView ID="gvCartItems" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="ActivityName" HeaderText="Activity Name" />
            <asp:BoundField DataField="ActivityPrice" HeaderText="Price" DataFormatString="{0:C}" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            <asp:BoundField DataField="Total" HeaderText="Total" DataFormatString="{0:C}" />
        </Columns>
    </asp:GridView>
    </form>
</asp:Content>
