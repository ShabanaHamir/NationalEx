<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="HotelDetails.aspx.cs" Inherits="FrontOffice.Hotels" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <table class="w-100">
            <tr>
                <td style="width: 683px">
                    <a href="RoomBooking.aspx">
                    <img alt="" src="Images/Hotel1.jfif" style="width: 286px; height: 182px" /></td>
                <td style="width: 357px">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/RoomBooking.aspx">Skyline Hotel</asp:HyperLink>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" BackColor="#009999" BorderStyle="None" Font-Bold="True" ForeColor="White" OnClick="Button1_Click" Text="Select Hotel" />
                </td>
            </tr>
            <tr>
                <td style="width: 683px">
                    <a href="RoomBooking.aspx">
                    <img alt="" src="Images/Hotel2.jfif" style="width: 291px; height: 194px" /></td>
                <td style="width: 357px">
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/RoomBooking.aspx">Royal Breeze Hotel</asp:HyperLink>
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" BackColor="#009999" BorderStyle="None" Font-Bold="True" ForeColor="White" OnClick="Button2_Click" Text="Select Hotel" />
                </td>
            </tr>
            <tr>
                <td style="width: 683px">
                    <a href="RoomBooking.aspx">
                    <img alt="" src="Images/Hotel3.jfif" style="width: 290px; height: 254px" /></td>
                <td style="width: 357px">
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/RoomBooking.aspx">Retreat Inn</asp:HyperLink>
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" BackColor="#009999" BorderStyle="None" Font-Bold="True" ForeColor="White" OnClick="Button3_Click" Text="Select Hotel" />
                </td>
            </tr>
            <tr>
                <td style="width: 683px">
                    <a href="RoomBooking.aspx">
                    <img alt="" src="Images/Hotel4.jfif" style="width: 287px; height: 178px" /></td>
                <td style="width: 357px">
                    <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/RoomBooking.aspx">Buckingham Hotel</asp:HyperLink>
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" BackColor="#009999" BorderStyle="None" Font-Bold="True" ForeColor="White" OnClick="Button4_Click" Text="Select Hotel" />
                </td>
            </tr>
            <tr>
                <td style="width: 683px">&nbsp;</td>
                <td style="width: 357px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 683px">&nbsp;</td>
                <td style="width: 357px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 683px">&nbsp;</td>
                <td style="width: 357px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 683px">&nbsp;</td>
                <td style="width: 357px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 683px">&nbsp;</td>
                <td style="width: 357px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
