<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="StaffCustomers.aspx.cs" Inherits="FrontOffice.StaffCustomers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <div style="margin-left: 80px">
            <asp:Button ID="btnCustomers" runat="server" Height="96px" OnClick="btnCustomers_Click" Text="Customers" Width="194px" />
        </div>
        <br />
        <div style="margin-left: 80px">
            <asp:Button ID="btnCustomerRequests" runat="server" Height="97px" OnClick="btnCustomerRequests_Click" Text="Customer Requests" Width="191px" />
        </div>
    </form>
</asp:Content>
