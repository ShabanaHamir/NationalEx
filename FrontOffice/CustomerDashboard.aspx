﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CustomerDashboard.aspx.cs" Inherits="FrontOffice.CustomerDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <div style="margin-left: 80px">
            <asp:Button ID="btnMyDetails" runat="server" Height="49px" OnClick="btnMyDetails_Click" Text="My Details" Width="700px" />
        </div>
        <div style="margin-left: 80px">
            <asp:Button ID="btnBookings" runat="server" Height="54px" Text="My Bookings" Width="700px" OnClick="btnBookings_Click" />
        </div>
        <div style="margin-left: 80px">
            <asp:Button ID="btnAccountSettings" runat="server" Height="63px" Text="Account Settings" Width="700px" OnClick="btnAccountSettings_Click" />
        </div>
        <div style="margin-left: 80px">
            <asp:Button ID="btnChangePassword" runat="server" Height="53px" Text="Change Password" Width="700px" OnClick="btnChangePassword_Click" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <div style="margin-left: 80px">
        </div>
        <div style="margin-left: 80px">
            <asp:Button ID="btnSignOut" runat="server" Height="50px" Text="Sign Out" Width="110px" OnClick="btnSignOut_Click" />
        </div>
    </form>
</asp:Content>
