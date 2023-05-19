<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="StaffDashboard.aspx.cs" Inherits="FrontOffice.StaffDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <div class="text-center">
            <strong>Welcome to Staff Dashboard!
        <br/>
        Manage your daily tasks effectively.
        </strong>
        <br />
        <br />
        </div>
        <div style="margin-left: 40px">
            <asp:Button ID="btnCustomers" runat="server" Height="46px" OnClick="btnCustomers_Click" Text="Manage Customer Information" Width="746px" BackColor="#8BA6E9" />
        </div>
        <div style="margin-left: 40px">
            <asp:Button ID="btnBookings" runat="server" Height="46px" Text="Manage Bookings" Width="749px" BackColor="#BED0F4" OnClick="btnBookings_Click"/>
        </div>
        <div style="margin-left: 40px">
            <asp:Button ID="btnHotels" runat="server" Height="43px" Text="Manage Hotels" Width="747px" BackColor="#F7E4E0" OnClick="btnHotels_Click" />
        </div>
        <div style="margin-left: 40px">
            <asp:Button ID="btnActivities" runat="server" Height="45px" OnClick="btnActivities_Click" Text="Manage Activities" Width="747px" BackColor="#F7E4E0" />
            <br />
            <asp:Button ID="btnTrips" runat="server" Height="45px" Text="Manage Trips" Width="745px" BackColor="#F7E4E0" OnClick="btnTrips_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSignOut" runat="server" Text="LogOut" />
            <br />
            <br />
        </div>
    </form>
</asp:Content>
