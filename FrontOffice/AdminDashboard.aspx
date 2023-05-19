<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="FrontOffice.AdminDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/StaffDashboard.aspx">Staff Dashboard</asp:HyperLink>
            <br />
            <asp:Button ID="btnUsers" runat="server" Height="53px" OnClick="btnUsers_Click" Text="Users" Width="608px" />
            <br />
        </div>
        <div style="margin-left: 40px">
            <asp:Button ID="btnHotels" runat="server" Height="49px" OnClick="btnHotels_Click" Text="Hotels" Width="608px" />
        </div>
        <div style="margin-left: 40px">
            <asp:Button ID="btnActivities" runat="server" Height="54px" OnClick="btnActivities_Click" Text="Activities" Width="608px" />
        </div>
        <div style="margin-left: 40px">
            <asp:Button ID="btnTrips" runat="server" Height="51px" OnClick="btnTrips_Click" Text="Trips" Width="608px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSignOut" runat="server" Text="Log Out" />
        </div>
    </form>
</asp:Content>
