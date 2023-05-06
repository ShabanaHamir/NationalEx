<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActivityDelete.aspx.cs" Inherits="FrontOffice.ActivityDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 360px">
            <br />
            <br />
            <br />
            <asp:Label ID="lblActivityDelete" runat="server" Text="Are you sure you want to delete this activity?"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Delete" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
