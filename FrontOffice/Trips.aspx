<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Trips.aspx.cs" Inherits="FrontOffice.Trips" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" Height="329px">
            <asp:Panel ID="Panel2" runat="server" Height="259px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <h2 style="font-size: large"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; England&#39;s Number 2 Destination for bus and coaches tickets</strong></h2>
                &nbsp;Trips Available:<br /> <br />
                30/05/2023<br />
                From Derby to London&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £33<br /> 11:04 ---------12:09&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; only 6 Left
                <br />
                Duration:1H 5M&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnBook1" runat="server" Height="21px" Text="Book Now" OnClick="btnBook1_Click" />
                <br />
                <br />
               
                14/06/2023<br /> From London to Paris&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £220<br /> 13:12 ---------23:45&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; only 22 Left<br /> &nbsp;Duration:10H 38M&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnBook2" runat="server" Height="21px" Text="Book Now" OnClick="btnBook2_Click" />
                <asp:Panel ID="Panel3" runat="server" Height="229px">
                    15/06/2023<br /> From Birmingham to Leicester &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £20<br /> 09:35 ---------10:00&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; only 3 Left<br /> &nbsp;Duration:25M&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnBook3" runat="server" Height="21px" OnClick="btnBook3_Click" Text="Book Now" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp; 21/06/2023<br /> From Brighton to Portsmouth&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £23<br /> 17:09 ---------18:45&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; only 2 Left<br /> Duration:1H 36M&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnBook4" runat="server" Height="21px" OnClick="btnBook4_Click" Text="Book Now" />
                    <br />
                    &nbsp;<asp:Panel ID="Panel4" runat="server" Height="188px">
                        25/06/2023<br /> From Rome to London&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £253<br /> 19:00 ---------9:49&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; only 12 Left<br /> Duration:14H 49M&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnBook5" runat="server" Height="21px" OnClick="btnBook5_Click" Text="Book Now" />
                        <br />
                        <br />
                        27/06/2023<br /> From Leeds to Bath&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £21<br /> 11:22 ---------12:18&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; only 3 Left<br /> Duration: 56M&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnBook6" runat="server" Height="21px" OnClick="btnBook6_Click" Text="Book Now" />
                    </asp:Panel>
                    <br />
                    <br />
                    27/06/2023<br /> From London to Leicester&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £35<br /> 13:30 ---------16:55&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; only 19 Left<br /> Duration: 3H25M&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnBook7" runat="server" Height="21px" OnClick="btnBook7_Click" Text="Book Now" />
                    <br />
                    <asp:Panel ID="Panel5" runat="server" Height="366px">
                        28/06/2023<br /> From London to Leicester&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £35<br /> 13:30 ---------16:55&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; only 9 Left<br /> Duration: 3H25M&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnBook8" runat="server" Height="21px" OnClick="btnBook8_Click" Text="Book Now" />
                        <br />
                        <br />
                        28/06/2023<br /> From Southampton to Paris&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £190<br /> 6:00 ---------20:55&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; only 5 Left<br /> Duration: 14H55M&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnBook9" runat="server" Height="21px" OnClick="btnBook9_Click" Text="Book Now" />
                        <br />
                        <br />
                        30/06/2023<br /> From Oxford to Derby&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £19<br /> 12:25 ---------2:50&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; only 22 Left<br /> Duration: 2H25M&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnBook10" runat="server" Height="30px" OnClick="btnBook10_Click" Text="Book Now" />
                        <br />
                        <asp:Panel ID="Panel6" runat="server" Height="259px">
                            2/07/2023<br /> From Wolverhampton to Shiffield&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £54<br /> 17:15 ---------19:15&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; only 1 Left<br /> Duration: 2H&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnBook11" runat="server" Height="34px" OnClick="btnBook11_Click" Text="Book Now" />
                            <br />
                            <br />
                            02/07/2023<br /> From Liverpool to Manchester&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £20<br /> 10:45 ---------12:00&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; only 14 Left<br /> Duration: 1H&nbsp;45M&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnBook12" runat="server" Height="33px" OnClick="btnBook12_Click" Text="Book Now" />
                            <br />
                            <br />
                            03/07/2023<br /> From London to Portsmouth&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £45<br /> 20:10 ---------23:45&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; only 7 Left<br /> Duration: 3H&nbsp;35M&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnBook13" runat="server" Height="33px" OnClick="btnBook13_Click" Text="Book Now" />
                            <br />
                            <br />
                            04/07/2023<br /> From London to Masrsellie&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £320<br /> 11:10 ---------5:18&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; only 11 Left<br /> Duration: 18H&nbsp;18M&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnBook14" runat="server" Height="36px" OnClick="btnBook14_Click" Text="Book Now" />
                            <br />
                            <br />
                            05/07/2023<br /> From Rome to Portsmouth&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; £215<br /> 4:10 ---------19:00&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; only 4 Left<br /> Duration: 14H&nbsp;50M&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="btnBook15" runat="server" Height="39px" OnClick="btnBook15_Click" Text="Book Now" />
                            <asp:Panel ID="Panel7" runat="server" Height="134px">
                            </asp:Panel>
                        </asp:Panel>
                    </asp:Panel>
                </asp:Panel>
            </asp:Panel>
        </asp:Panel>
    </form>
</asp:Content>
