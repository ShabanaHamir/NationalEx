﻿<%@ Page Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AnHotel.aspx.cs" Inherits="FrontOffice.AnHotel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <div>
            Hotel ID<asp:TextBox ID="txtHotelID" runat="server"></asp:TextBox>
            <br />
            Hotel Name<asp:TextBox ID="txtHotelName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Hotel City"></asp:Label>
            <asp:TextBox ID="txtHotelCity" runat="server"></asp:TextBox>
            <br />
            Hotel Phone Number<asp:TextBox ID="txtHotelPhoneNumber" runat="server"></asp:TextBox>
            <br />
            Hotel Post Code<asp:TextBox ID="txtHotelPostCode" runat="server"></asp:TextBox>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
    </form>
    
    </asp:Content>
