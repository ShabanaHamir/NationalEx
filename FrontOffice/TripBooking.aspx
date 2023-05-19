<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="TripBooking.aspx.cs" Inherits="FrontOffice.TripBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <html>
    <head>
        <title>Trip Listing</title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" />
                <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" CssClass="btn btn-primary" />

                <li class="nav-item">
                    <a class="nav-link" href="RoomListing.aspx">Book a Room</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="ActivityBooking.aspx">Book Activities</a>
                </li>
                
                <div class="container">
                    <h1 class="text-center">Available Trips</h1>
                    <a class="nav-link" href="ShowTripQuantity.aspx">View Cart</a>
                    
                    <asp:Repeater ID="rptTrip" runat="server" OnItemCommand="rptTrip_ItemCommand">
                        <ItemTemplate>
                            <h2><%# Eval("TripDestination") %></h2>
                            <p><strong>Date:</strong> <%# Eval("TripDate") %></p>
                            <p><strong>Start Time:</strong> <%# Eval("TripStartTime") %></p>
                            <p><strong>End Time:</strong> <%# Eval("TripEndTime") %></p>
                            <p><strong>Vehicle:</strong> <%# Eval("VehicleType") %></p>
                            <p><strong>Source:</strong> <%# Eval("TripSource") %></p>
                            <p><strong>Cost:</strong> <%# Eval("TicketCost") %></p>
                            <asp:TextBox ID="txtQTY" runat="server" Text=""></asp:TextBox>
                            <asp:Button ID="addToCartButton" runat="server" Text="Add to Cart" CommandArgument='<%# Eval("TripID") %>' OnClick="addToCartButton_Click" />
                            <hr />
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </form>
    </body>
    </html>
</asp:Content>
