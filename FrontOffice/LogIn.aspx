<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="FrontOffice.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    Last Name:<asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
    <br />
    Password:<asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="lblError"></asp:Label>
</form>
</asp:Content>
