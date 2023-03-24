<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ABooking.aspx.cs" Inherits="FrontOffice.ABooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server" style="height: 507px">
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblBookingID" runat="server" Font-Bold="True" Text="BookingID:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtBookingID" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblBookingDate" runat="server" Font-Bold="True" Text="Booking Date:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtBookingDate" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblUserFName" runat="server" Font-Bold="True" Text="First Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtUserFName" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblBookingDetails" runat="server" Font-Bold="True" Text="Booking Details:"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtBookingDetails" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblTotalCost" runat="server" Font-Bold="True" Text="Total Cost:"></asp:Label>
&nbsp;<asp:TextBox ID="txtTotalCost" runat="server"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblPaymentType" runat="server" Text="Payment Type:"></asp:Label>
&nbsp;<asp:TextBox ID="txtPaymentType" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <br />
&nbsp;
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnOK" runat="server" Height="22px" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnCancel" runat="server" Height="23px" Text="Cancel" />
    </form>
</asp:Content>
