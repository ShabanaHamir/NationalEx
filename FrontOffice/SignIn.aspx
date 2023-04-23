<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="FrontOffice.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        Last Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Password:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" Text="Login" />
    </form>
</asp:Content>
