<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="UserDefault.aspx.cs" Inherits="FrontOffice.UserDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <asp:ListBox ID="lstUser" runat="server"></asp:ListBox>
        <br />
        <asp:Label ID="lblEnterUser" runat="server" Text="Enter the Users Name"></asp:Label>
        <br />
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Button ID="btnDisplayAll" runat="server" Text="DisplayAll" OnClick="btnDisplayAll_Click" />
        <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
    </form>
</asp:Content>
