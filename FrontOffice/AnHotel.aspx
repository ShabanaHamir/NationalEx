<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnHotel.aspx.cs" Inherits="FrontOffice.AnHotel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hotel ID<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Hotel Name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Hotel Post Code<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
        </div>
    </form>
</body>
</html>
