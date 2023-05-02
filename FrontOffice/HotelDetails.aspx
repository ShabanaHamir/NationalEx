<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="HotelDetails.aspx.cs" Inherits="FrontOffice.Hotels" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server" style="font-size: medium">
        <h2><span class="initialism">Select a Hotel</span></h2>
        <table class="w-100">
            <tr>
                <a href="booking.aspx">
  <img alt="" src="Images/Hotel1.jfif" style="width: 287px; height: 182px" />
</a>

                <td style="width: 292px" rowspan="2"><span class="initialism">
                    <img alt="" src="Images/Hotel1.jfif" style="width: 291px; height: 182px" /></span></td>
                <td style="width: 698px">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/RoomBooking.aspx">Skyline Hotel</asp:HyperLink>
                </td>
                <td rowspan="2">
                    <asp:Label ID="Label1" runat="server" Text="From"></asp:Label>
                    <br />
                    150 £
                    <br />
                    <strong>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="color: #CCCCCC; font-weight: bold; background-color: #0099CC" Text="Select Hotel" Width="150px" />
                    </strong></td>
            </tr>
            <tr>
                <td style="width: 698px">London</td>
            </tr>
            <tr>
                <td style="width: 292px" rowspan="2">
                    <img alt="" src="Images/Hotel2.jfif" style="width: 291px; height: 194px" /></td>
                <td style="width: 698px">
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/RoomBooking.aspx">Sunset Inn Hotel</asp:HyperLink>
                </td>
                <td rowspan="2">
                    <asp:Label ID="Label2" runat="server" Text="From"></asp:Label>
                    <br />
                    150 £<br />
                    <strong>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="color: #CCCCCC; font-weight: bold; background-color: #0099CC" Text="Select Hotel" Width="166px" />
                    </strong></td>
            </tr>
            <tr>
                <td style="width: 698px">Birm</td>
            </tr>
            <tr>
                <td style="width: 292px" rowspan="2">
                    <img alt="" src="Images/Hotel3.jfif" style="width: 291px; height: 211px" /></td>
                <td style="width: 698px">
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/RoomBooking.aspx">Royal Breeze Hotel</asp:HyperLink>
&nbsp;</td>
                <td rowspan="2">
                    <asp:Label ID="Label3" runat="server" Text="From"></asp:Label>
                    <br />
                    150 £<br />
                    <strong>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="color: #CCCCCC; font-weight: bold; background-color: #0099CC" Text="Select Hotel" Width="158px" />
                    </strong></td>
            </tr>
            <tr>
                <td style="width: 698px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 292px" rowspan="2">&nbsp;</td>
                <td style="width: 698px">&nbsp;</td>
                <td rowspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 698px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 292px" rowspan="2">&nbsp;</td>
                <td style="width: 698px">&nbsp;</td>
                <td rowspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 698px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 292px" rowspan="2">&nbsp;</td>
                <td style="width: 698px">&nbsp;</td>
                <td rowspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 698px">&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
