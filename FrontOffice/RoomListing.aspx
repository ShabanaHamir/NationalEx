<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="RoomListing.aspx.cs" Inherits="FrontOffice.RoomListing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <html>
    <head>
        <title>Room Listing</title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:TextBox ID="txtSearch" runat="server" CssClass="form-control" />
<asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" CssClass="btn btn-primary" />
                     <li class="nav-item">
                         <a class="nav-link" href="ActivityBooking.aspx">Book Activities</a>
    </li>
    <li class="nav-item">
       <a class="nav-link" href="TripBooking.aspx">Book a Trip</a>
    </li>

                <div class="container">
            <h1 class="text-center">Avaialable Hotel Rooms</h1>

             <a class="nav-link" href="ShowRoomQuantity.aspx">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; View Cart</a>
               <%-- <asp:Repeater ID="roomRepeater" runat="server">--%>
                    <asp:Repeater ID="rptRoom" runat="server" OnItemCommand="rptRooms_ItemCommand">
                    <ItemTemplate>
                        <h2><%# Eval("RoomType") %></h2>
                        <p><strong>Price:</strong> <%# Eval("RoomPrice") %></p>
                        <p><strong>Description:</strong> <%# Eval("RoomDescription") %></p>
                        <p><strong>Facilities:</strong> <%# Eval("RoomFacilities") %></p>
                        <asp:TextBox ID="txtQTY" runat="server" Text=""></asp:TextBox>
                         <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" />
                        <asp:Button ID="addToCartButton" runat="server" Text="Add to Cart" CommandArgument='<%# Eval("RoomID") %>' OnClick="addToCartButton_Click" />
                        <hr />
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </form>
    </body>
    </html>
        </form>
</asp:Content>
