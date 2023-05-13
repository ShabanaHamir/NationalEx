<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="RoomBooking.aspx.cs" Inherits="FrontOffice.RoomBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <head>
            <script src="roomCustomer.js"></script>
        </head>
        <div class="container">
            <h1>Rooms</h1>
            <div class="row">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="RoomCustomer.aspx">Rooms</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Checkout.aspx">Checkout</a>
                    </li>
                </ul>
       <!-- Loop through rooms and generate a card for each room -->
            <% if (RoomList != null && RoomList.Count > 0) { %>
                <asp:Repeater ID="rptRooms" runat="server" OnItemCommand="rptRooms_ItemCommand">
                    <ItemTemplate>
                        <div class="col-md-4">
                            <div class="card" style="width: 18rem;">
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("RoomType") %></h5>
                                    <p class="card-text">Price: <%# Eval("RoomPrice") %></p>
                                    <label for="txtQTY">Quantity:</label>
                                    <asp:TextBox ID="txtQTY" runat="server" CssClass="form-control" />
                                    <asp:Button ID="btnAdd" runat="server" Text="Add to Cart" CssClass="btn btn-primary mt-2" CommandName="AddToCart" CommandArgument='<%# Eval("RoomID") %>' />
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            <% } %>
        </div>
    </div>
</form>
</asp:Content>
