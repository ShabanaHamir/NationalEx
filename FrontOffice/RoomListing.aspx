<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="RoomListing.aspx.cs" Inherits="FrontOffice.RoomListing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <html>
    <head>
        <title>Room Listing</title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
               <%-- <asp:Repeater ID="roomRepeater" runat="server">--%>
                    <asp:Repeater ID="rptRoom" runat="server" OnItemCommand="rptRooms_ItemCommand">
                    <ItemTemplate>
                        <h2><%# Eval("RoomType") %></h2>
                        <p><strong>Price:</strong> <%# Eval("RoomPrice") %></p>
                        <p><strong>Description:</strong> <%# Eval("RoomDescription") %></p>
                        <p><strong>Facilities:</strong> <%# Eval("RoomFacilities") %></p>
                        <asp:TextBox ID="txtQTY" runat="server" Text=""></asp:TextBox>
                         <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" />
                        <asp:Button ID="addToCartButton" runat="server" Text="Add to Cart" CommandArgument='<%# Eval("RoomID") %>' OnClick="addToCartButton_Click" />
                        <hr />
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </form>
    </body>
    </html>
        </form>
</asp:Content>
