<%@ Page Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FrontOffice.Default" %>



    <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 


    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerID" runat="server" Text="CustomerID"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblFillInBelow" runat="server" Font-Bold="True" Font-Overline="True" Font-Size="Large" Font-Strikeout="False" Text="Please Fill in Below!"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblCustomerFName" runat="server" Text="First Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerFName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblCustomerLName" runat="server" Text="Last Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerLName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblCustomerDOB" runat="server" Text="Date of Birth:"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerDOB" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblCustomerEmail" runat="server" Text="Email:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblCustomerAddress" runat="server" Text="Address:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="Let The Journey Begin!" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>

    </asp:Content>

