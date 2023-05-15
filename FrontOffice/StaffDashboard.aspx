<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="StaffDashboard.aspx.cs" Inherits="FrontOffice.StaffDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    StaffDashboard! :)



        <br />
        <br />
        <div style="margin-left: 40px">
            <asp:Button ID="btnCustomers" runat="server" Height="46px" OnClick="btnCustomers_Click" Text="Customers" Width="108px" />
        </div>
        <div style="margin-left: 40px">
            <asp:Button ID="btnBookings" runat="server" Height="46px" Text="Bookings" Width="108px" />
        </div>
        <div style="margin-left: 40px">
            <asp:Button ID="btnHotels" runat="server" Height="43px" Text="Hotels" Width="108px" />
        </div>
        <div style="margin-left: 40px">
            <asp:Button ID="btnActivities" runat="server" Height="45px" OnClick="btnActivities_Click" Text="Actvitiies" Width="108px" />
            <br />
            <asp:Button ID="btnTrips" runat="server" Height="45px" Text="Trips" Width="108px" />
            <br />
            <br />
        </div>
    </form>



</asp:Content>
