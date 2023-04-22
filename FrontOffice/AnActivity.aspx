<%@ Page Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AnActivity.aspx.cs" Inherits="FrontOffice.AnActivity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<%--    //file --%>
    <form id="form1" runat="server" style="height: 947px">
        <p>
            &nbsp;</p>
        <p style="height: 1107px; margin-left: 40px">
        &nbsp;&nbsp;<asp:Label ID="lblActivityID" runat="server" Enabled="False" Font-Bold="True" Text="Activity ID:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtActivityID" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblAName" runat="server" Font-Bold="True" Text="Activity:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAName" runat="server" ></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <br style="margin-left: 40px" />
        <br style="margin-left: 40px" />
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Label ID="lblACity" runat="server" Font-Bold="True" Font-Overline="False" Text="City:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtACity" runat="server"></asp:TextBox>
        <br style="margin-left: 40px" />
        <br style="margin-left: 40px" />
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Label ID="lblADescription" runat="server" Font-Bold="True" Text="Description:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtADescription" runat="server"></asp:TextBox>
        <br style="margin-left: 40px" />
        <br style="margin-left: 40px" />
        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Label ID="lblAPrice" runat="server" Font-Bold="True" Text="Price:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAPrice" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblAAddress" runat="server" Font-Bold="True" Text="Address:"></asp:Label>
            <asp:TextBox ID="txtAAddress" runat="server"></asp:TextBox>
        <br style="margin-left: 40px" />
        <br style="margin-left: 40px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Label ID="lblAPostcode" runat="server" Font-Bold="True" Text="Postcode:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtAPostcode" runat="server"></asp:TextBox>
        <br style="margin-left: 40px" />
        <br style="margin-left: 40px" />
        &nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblError" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
        <br style="margin-left: 40px" />
        <br style="margin-left: 40px" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAOK" runat="server" Height="51px" OnClick="btnAOK_Click" Text="OK" Width="103px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnACancel" runat="server" Height="51px" Text="Cancel" Width="183px" />
        &nbsp;</p>
    </form>


</asp:Content>
