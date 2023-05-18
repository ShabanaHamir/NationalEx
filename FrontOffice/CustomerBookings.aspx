<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CustomerBookings.aspx.cs" Inherits="FrontOffice.CustomerBookings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <div style="margin-left: 736px">
            <asp:GridView ID="bookingsGridView" runat="server" AutoGenerateColumns="True">
            </asp:GridView>
        </div>
        <asp:Label ID="lblInfo" runat="server" Text="For booking cancellations and/or adjustments, please email us at customerservice@ne.ac.uk. We cannot guarantee cancellations or adjustments. "></asp:Label>
    </form>

</asp:Content>
