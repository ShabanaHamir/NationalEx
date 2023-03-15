<%@ Page Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AnActivity.aspx.cs" Inherits="FrontOffice.AnActivity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <form id="form1" runat="server" style="height: 411px">
        <p>
            &nbsp;</p>
        <asp:Label ID="lblAName" runat="server" Font-Bold="True" Text="Activity:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAName" runat="server" Height="17px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblACity" runat="server" Font-Bold="True" Font-Overline="False" Text="City:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtACity" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblADescription" runat="server" Font-Bold="True" Text="Description:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtADescription" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblAPrice" runat="server" Font-Bold="True" Text="Price:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAPrice" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblAPostcode" runat="server" Font-Bold="True" Text="Postcode:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAPostcode" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Height="22px" OnClick="btnOK_Click1" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Height="23px" Text="Cancel" />
    </form>


</asp:Content>
