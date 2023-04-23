<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="FrontOffice.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        Email:
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        Password:
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        Confirm Password: <asp:TextBox ID="txtConfirmPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnSignup" runat="server" Text="Sign Up" />
    </form>
</asp:Content>
