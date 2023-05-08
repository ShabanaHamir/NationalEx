<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ARoom.aspx.cs" Inherits="FrontOffice.ARoom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <form id="form1" runat="server">
        <table class="w-100">
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server">HOTEL NAMES AND ID </asp:TextBox>
                </td>
            </tr>
        </table>
        Room ID:<asp:TextBox ID="txtRoomID" runat="server"></asp:TextBox>
        <br />
        Hotel ID:<asp:TextBox ID="txtHotelID" runat="server"></asp:TextBox>
         <br />
         <asp:Label ID="Label5" runat="server" Text="Hotel Name:"></asp:Label>
         <asp:TextBox ID="txtHotelName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Floor Number"></asp:Label>
        <asp:TextBox ID="txtFloorNumber" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Room Facilities"></asp:Label>
        <asp:CheckBoxList ID="FacilitiesCheckBoxList" runat="server" Height="295px">
            <asp:ListItem>TV</asp:ListItem>
            <asp:ListItem>Sofa / Extra Bedding</asp:ListItem>
            <asp:ListItem>Pool </asp:ListItem>
            <asp:ListItem>Spa Access</asp:ListItem>
            <asp:ListItem>Gym / Fitness Equipment</asp:ListItem>
            <asp:ListItem>Jacuzzi</asp:ListItem>
            <asp:ListItem>Balcony</asp:ListItem>
            <asp:ListItem>Terrace</asp:ListItem>
            <asp:ListItem>Room Service</asp:ListItem>
            <asp:ListItem>Safe Box</asp:ListItem>
            <asp:ListItem>Mini Fridge</asp:ListItem>
            <asp:ListItem>Free Wifi</asp:ListItem>
            <asp:ListItem>Work Station</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        Room Number:
        <asp:TextBox ID="txtRoomNumber" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Room Description"></asp:Label>
        <asp:TextBox ID="txtRoomDescription" runat="server"></asp:TextBox>
&nbsp;<br />
        <asp:Label ID="Label2" runat="server" Text="Number of Beds:"></asp:Label>
        <asp:TextBox ID="txtNumberOfBeds" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        Room Type:<asp:TextBox ID="txtRoomType" runat="server"></asp:TextBox>
        <br />
        Room Price:
        <asp:TextBox ID="txtRoomPrice" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Occupied" />
        <table class="w-100">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</asp:Content>
