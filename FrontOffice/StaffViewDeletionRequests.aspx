<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="StaffViewDeletionRequests.aspx.cs" Inherits="FrontOffice.StaffViewDeletionRequests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <h2>Account Deletion Requests</h2>
        <p>
            <asp:ListBox ID="lstDeletionRequests" runat="server"></asp:ListBox>
        </p>
   
        </form>
</asp:Content>
