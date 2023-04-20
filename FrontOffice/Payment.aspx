<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="FrontOffice.Payment" %>

<script runat="server">


 
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        Payment ID:
        <asp:TextBox ID="txtPaymentID" runat="server"></asp:TextBox>
        <br />
        Customer ID:<asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
        <br />
        Payment Amount:<asp:TextBox ID="txtPaymentAmount" runat="server"></asp:TextBox>
        <br />
        Payment Date:<asp:TextBox ID="txtPaymentDate" runat="server"></asp:TextBox>
        <br />
        Payment Type:<asp:DropDownList ID="txtPaymentType" runat="server">
        </asp:DropDownList>
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
    </form>
</asp:Content>
