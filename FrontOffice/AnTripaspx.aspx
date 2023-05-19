<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AnTripaspx.aspx.cs" Inherits="FrontOffice.AnTripaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server" style="height: 524px">
        TripID:&nbsp;
        <asp:TextBox ID="txtTripID" runat="server" BackColor="White" BorderColor="#0066FF" ForeColor="#66CCFF"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
        <br />
        <br />
        Trip Destination :
        <asp:TextBox ID="txtTripDestination" runat="server" BorderColor="#0066FF"></asp:TextBox>
        <br />
        <br />
        Trip Source :
        <asp:TextBox ID="txtTripSource" runat="server" BorderColor="#0066FF"></asp:TextBox>
        <br />
        <br />
        Ticket Cost :
        <asp:TextBox ID="txtTicketCost" runat="server" BorderColor="#0066FF"></asp:TextBox>
        <br />
        <br />
        Trip Start Time :
        <asp:TextBox ID="txtTripStartTime" runat="server" BorderColor="#0066FF"></asp:TextBox>
        <br />
        <br />
        Trip End Time : <asp:TextBox ID="txtTripEndTime" runat="server" BorderColor="#0066FF"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        Vehicle Type:
        <asp:TextBox ID="txtVehicleType" runat="server" BorderColor="#0066FF"></asp:TextBox>
        <br />
        <br />
        Trip Date :
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <br />
        <br />
        <br />
        <br />
    </form>
</asp:Content>
