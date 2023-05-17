<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookingDelete.aspx.cs" Inherits="FrontOffice.BookingDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 278px">
            <br />
            <br />
            <br />
            <asp:Label ID="lblConfirmDelete" runat="server" Text="Are you sure you want to delete this booking?"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
        </div>
    </form>
</body>
</html>
