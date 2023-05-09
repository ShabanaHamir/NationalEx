<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="UserDelete.aspx.cs" Inherits="FrontOffice.UserDelete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <div style="margin-left: 640px">
            <asp:Label ID="lblConfirmDelete" runat="server" Text="Are you sure you want to delete this user?"></asp:Label>
        </div>
        <br />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
        <br />
    </form>
</asp:Content>
