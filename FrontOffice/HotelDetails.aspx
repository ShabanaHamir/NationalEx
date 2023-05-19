<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="HotelDetails.aspx.cs" Inherits="FrontOffice.HotelDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <html>
    <head>
        <title>Hotel Details</title>
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

                <asp:Repeater ID="rptHotel" runat="server" OnItemCommand="rptHotels_ItemCommand">
                    <ItemTemplate>
                        <h2><%# Eval("HotelName") %></h2>
                        <p><strong>City:</strong> <%# Eval("HotelCity") %></p>
                        <p><strong>Postcode:</strong> <%# Eval("HotelPostcode") %></p>
                        <p><strong>Phone Number:</strong> <%# Eval("HotelPhoneNumber") %></p>
                        <asp:Button ID="bookNowButton" runat="server" Text="Book Now" CommandArgument='<%# Eval("HotelId") %>' OnClick="bookNowButton_Click" CssClass="btn btn-primary" />
                        <hr />
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </form>
    </body>
    </html>
</form>
</asp:Content>
