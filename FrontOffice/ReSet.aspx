<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ReSet.aspx.cs" Inherits="FrontOffice.ReSet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div>
            <br />
            <h1>Re-Set Password<br />
            </h1>
            <asp:Label ID="lblEMail" runat="server" Text="E Mail Address"></asp:Label>
&nbsp;<asp:TextBox ID="txtEMail" runat="server" Width="283px"></asp:TextBox>
            <br />
                <br />
                <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
&nbsp;</div>
&nbsp;<asp:Button ID="btnReSet" runat="server" Text="Re-set Password" OnClick="btnReSet_Click" />
&nbsp;<asp:Button ID="btnDone" runat="server" Text="Done" OnClick="btnDone_Click" />
&nbsp;<asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="View Email" />    </form>
</body>
</html>

</asp:Content>
