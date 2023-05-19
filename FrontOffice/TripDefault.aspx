<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="TripDefault.aspx.cs" Inherits="FrontOffice.TripDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">






    <form id="form1" runat="server">
        <asp:ListBox ID="lstTrips" runat="server" OnSelectedIndexChanged="lstTrips_SelectedIndexChanged" Width="1121px"></asp:ListBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Trip ID"></asp:Label>
        <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
        <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display All" />
        <br />
        <asp:TextBox ID="txtTripDestination" runat="server"></asp:TextBox>
&nbsp;<br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
&nbsp;<asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
&nbsp;<asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
    </form>






</asp:Content>
