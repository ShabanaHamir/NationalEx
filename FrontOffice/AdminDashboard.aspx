<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="FrontOffice.AdminDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:Button ID="btnUsers" runat="server" Height="53px" OnClick="btnUsers_Click" Text="Users" Width="106px" />
            <br />
        </div>
        <div style="margin-left: 40px">
            <asp:Button ID="btnHotels" runat="server" Height="49px" OnClick="btnHotels_Click" Text="Hotels" Width="106px" />
        </div>
        <div style="margin-left: 40px">
            <asp:Button ID="btnActivities" runat="server" Height="54px" OnClick="btnActivities_Click" Text="Activities" Width="105px" />
        </div>
        <div style="margin-left: 40px">
            <asp:Button ID="btnTrips" runat="server" Height="51px" OnClick="btnTrips_Click" Text="Trips" Width="106px" />
            <br />
        </div>
        <div style="margin-left: 40px">
            <asp:Button ID="btnReports" runat="server" Height="50px" OnClick="btnReports_Click" Text="Reports" Width="106px" />
        </div>
        <div style="margin-left: 40px">
            <asp:Button ID="btnCustomerFeedback" runat="server" Height="49px" OnClick="btnCustomerFeedback_Click" Text="Customer Feedback" Width="106px" />
        </div>
    </form>
</asp:Content>
