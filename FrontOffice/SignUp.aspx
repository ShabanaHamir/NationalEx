﻿<%--<%@ Page Language="C#"  MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="SignUp" %>--%>
<%@ Page Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="SignUp" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>
<script runat="server">

  
</script>


<html>
<head>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div>
            <br />
            <h1>Account Sign Up</h1>
                <table style="width: 100%;">
                    <tr>
                        <td style="width: 182px">
                            <asp:Label ID="Label1" runat="server" Text="Fist Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFirstName" runat="server" Width="318px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 182px">
                            <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtLastName" runat="server" Width="315px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 182px">
            <asp:Label ID="lblEMail" runat="server" Text="E Mail Address"></asp:Label>
                        </td>
                        <td><asp:TextBox ID="txtEMail" runat="server" width="318px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 182px">
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                        </td>
                        <td><asp:TextBox ID="txtPassword1" runat="server" TextMode="Password" width="318px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 182px">
            <asp:Label ID="lblConfirm" runat="server" Text="Confirm Password"></asp:Label>
                        </td>
                        <td><asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" width="318px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                <br />
                <asp:Label ID="lblError" runat="server"></asp:Label>
                <br />
                <br />
        </div>
        <asp:Button ID="btnSignUp" runat="server" Text="Sign-up" OnClick="btnSignUp_Click" />
&nbsp;<asp:Button ID="btnDone" runat="server" Text="Done" OnClick="btnDone_Click" />
&nbsp;<asp:Button ID="btnReSend" runat="server" Text="Re-set Password" OnClick="btnReSend_Click" />
&nbsp;<asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="View Email" />
    </form>
</body>
</html>
    </asp:Content>