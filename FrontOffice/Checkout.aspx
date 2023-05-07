<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="FrontOffice.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Checkout</h1>
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
                <asp:Label ID="lblTotalPrice" runat="server" Text=""></asp:Label>

            </tr>
        </tbody>
    </table>
    <button type="button" class="btn btn-primary">Proceed to Payment</button>

</asp:Content>
