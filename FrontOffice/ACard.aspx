<%@ Page Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ACard.aspx.cs" Inherits="FrontOffice.ACard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <form id="form1" runat="server" style="height: 901px">
        <p>
            &nbsp;</p>
        &nbsp;&nbsp;<asp:Label ID="lblCardID" runat="server" Text="CardID:"></asp:Label>
        <asp:TextBox ID="txtCardID" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp; <asp:Label ID="lblCardNo" runat="server" Font-Bold="True" Text="Card No:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCardNo" runat="server" ></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCardExpiry" runat="server" Font-Bold="True" Font-Overline="False" Text="Expiry Date:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCardExpiry" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCardName" runat="server" Font-Bold="True" Text="Name on Card:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCardName" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnOK" runat="server" Height="43px" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Height="44px" Text="Cancel" />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>


</asp:Content>
