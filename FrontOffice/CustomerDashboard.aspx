<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CustomerDashboard.aspx.cs" Inherits="FrontOffice.CustomerDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <div style="margin-left: 80px">
            <asp:Button ID="btnMyDetails" runat="server" Height="49px" OnClick="btnMyDetails_Click" Text="My Details" Width="156px" />
        </div>
        <div style="margin-left: 80px">
            <asp:Button ID="btnBookings" runat="server" Height="54px" Text="My Bookings" Width="156px" OnClick="btnBookings_Click" />
        </div>
        <div style="margin-left: 80px">
            <asp:Button ID="btnAccountSettings" runat="server" Height="63px" Text="Account Settings" Width="156px" />
        </div>
        <div style="margin-left: 80px">
            <asp:Button ID="btnChangePassword" runat="server" Height="53px" Text="Change Password" Width="156px" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <div style="margin-left: 80px">
            <asp:Button ID="btnFeedback" runat="server" Height="53px" Text="Feedback" Width="110px" />
        </div>
        <div style="margin-left: 80px">
            <asp:Button ID="btnSignOut" runat="server" Height="50px" Text="Sign Out" Width="110px" />
        </div>
    </form>
</asp:Content>
