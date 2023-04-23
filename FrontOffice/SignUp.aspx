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
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnSignup" runat="server" OnClick="btnSignup_Click" Text="Sign Up" />
        &nbsp;<asp:Button ID="Button1" runat="server" Text="Done " />
        &nbsp;<asp:Button ID="btnResetPass" runat="server" Text="Re-set Password" />
        &nbsp;<asp:Button ID="btnViewEmail" runat="server" Text="View Email" />
    </form>
</asp:Content>
