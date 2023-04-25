<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                <div>
            <br />
            <h1>Change Password<br />
            </h1>
                    <table style="width:100%;">
                        <tr>
                            <td style="width: 185px">
                    <asp:Label ID="lblCurrentPassword" runat="server" Text="Current Password"></asp:Label>
                            </td>
                            <td><asp:TextBox ID="txtCurrentPassword" runat="server" TextMode="Password" style="margin-left: 0px" Width="283px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 185px">
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                            </td>
                            <td><asp:TextBox ID="txtPassword1" runat="server" TextMode="Password" width="283px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 185px">
            <asp:Label ID="lblConfirm" runat="server" Text="Confirm Password"></asp:Label>
                            </td>
                            <td><asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" width="283px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                    <br />
                    <br />
        </div>
        <asp:Button ID="btnChange" runat="server" Text="Change Password" OnClick="btnChange_Click" />
&nbsp;<asp:Button ID="btnDone" runat="server" Text="Done" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
