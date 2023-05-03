<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="StaffHome.aspx.cs" Inherits="FrontOffice.StaffHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
   
    <form id="form1" runat="server">
           
      
            <h1>Sign-in<br />
            </h1>
            <table style="width: 100%;">
                <tr>
                    <td style="width: 498px; height: 26px;">
                    </td>
                    <td class="text-center" style="height: 26px; width: 506px">
            <asp:Label ID="lblUsername" runat="server" Text="User Name:"></asp:Label>
                    </td>
                    <td style="height: 26px; width: 937px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 498px">
                        &nbsp;</td>
                    <td style="width: 506px">
                        <asp:TextBox ID="txtUsername" runat="server" Width="405px"></asp:TextBox>
                    </td>
                    <td style="width: 937px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 498px; height: 26px;"></td>
                    <td class="text-center" style="height: 26px; width: 506px">
            <asp:Label ID="lblPin" runat="server" Text="Pin:"></asp:Label>
                    </td>
                    <td class="text-left" style="height: 26px; width: 937px"></td>
                </tr>
                <tr>
                    <td style="width: 498px">&nbsp;</td>
                    <td style="width: 506px">
                        <asp:TextBox ID="txtPin" runat="server" Width="377px"></asp:TextBox>
                    </td>
                    <td style="width: 937px">&nbsp;</td>
                </tr>
            </table>
            <div class="text-center">
&nbsp;&nbsp;<br />
                <br />
                <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <br />
&nbsp;</div>
        <asp:Button ID="btnSignIn" runat="server" Text="Sign-in" OnClick="btnSignIn_Click" />
<%--&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
&nbsp;</div>--%>
    </form>

</asp:Content>
