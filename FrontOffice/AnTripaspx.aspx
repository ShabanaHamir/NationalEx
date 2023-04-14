<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AnTripaspx.aspx.cs" Inherits="FrontOffice.AnTripaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server" style="height: 524px">
        TripID:&nbsp;
        <asp:TextBox ID="txtTripID" runat="server" BackColor="White" BorderColor="#0066FF" ForeColor="#66CCFF"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <br />
        Trip Destination :
        <asp:TextBox ID="txtTripDestination" runat="server" BorderColor="#0066FF"></asp:TextBox>
        <br />
        <br />
        Vehicle Type:
        <asp:TextBox ID="txtVehicleType" runat="server" BorderColor="#0066FF"></asp:TextBox>
        <br />
        <br />
        Trip Date :
        <asp:Calendar ID="clnTripDate" runat="server"></asp:Calendar>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel " />
        <br />
        <br />
        <br />
        <br />
    </form>
</asp:Content>
