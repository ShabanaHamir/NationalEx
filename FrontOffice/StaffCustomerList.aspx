<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="StaffCustomerList.aspx.cs" Inherits="FrontOffice.StaffCustomerList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <div style="margin-left: 80px">
            <asp:ListBox ID="lstUser" runat="server" Height="295px" Width="406px"></asp:ListBox>
            <br />
            <asp:Label ID="lblUserName" runat="server" Text="Enter a user's name:"></asp:Label>
            <br />
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" Text="Display All" />
        </div>
        <br />
        <br />
    </form>
</asp:Content>
