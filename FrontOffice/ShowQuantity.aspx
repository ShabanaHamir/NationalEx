<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ShowQuantity.aspx.cs" Inherits="FrontOffice.ShowQuantity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <table class="table">
        <thead>
            <tr>
                <th>Activity Name</th>
                <th>Price</th>
                <th>Quantity</th>
                <th>Total</th>
            </tr>
        </thead>
        <tbody>
           <asp:GridView ID="gvCartItems" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="ActivityName" HeaderText="Activity Name" />
        <asp:BoundField DataField="ActivityPrice" HeaderText="Price" DataFormatString="{0:C}" />
        <asp:BoundField DataField="QTY" HeaderText="Quantity" />
        <asp:BoundField DataField="Total" HeaderText="Total" DataFormatString="{0:C}" />
    </Columns>
</asp:GridView>

        </tbody>
    </table>
    <asp:Label ID="lblTotalPrice" runat="server" Text=""></asp:Label>
     </form>
</asp:Content>
