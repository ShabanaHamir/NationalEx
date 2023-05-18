<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="FrontOffice.Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <h1 class="auto-style1">Let the journey begin!</h1>
    <p>
       <asp:Button ID="btnTrips" CssClass="btn" runat="server" OnClick="btnTrips_Click" Text="Book your Trip NOW!" style="background-color: #E6CDAE; color: #000;" />
&nbsp;<asp:Button ID="btnHotels" CssClass="btn" runat="server" OnClick="btnHotels_Click" Text="Book a Hotel Now!" Width="363px" style="background-color: #495F75; color: #fff;" />
&nbsp;<asp:Button ID="btnActivities" CssClass="btn" runat="server" OnClick="btnActivities_Click" Text="Book your Activities NOW!" style="background-color: #AFE1CE; color: #000;" />


        </p>
    
    <p class="text-center">Your ultimate destination for hassle-free travel planning in England! We understand that planning a trip can be overwhelming,
        and that's why we offer a comprehensive range of services to make your travel experience as smooth and enjoyable as possible.
        Whether you're looking for a cozy hotel room, exciting excursions, or reliable transportation options, we've got you covered.
        Our team of travel experts has carefully curated a selection of top-rated hotels, activities, and transport providers across 
        England, so you can easily find and book the best options for your budget and preferences. So sit back, relax, and let us take are of all your travel needs and let the Journey Begin!</p>
        <p class="text-center">&nbsp;</p>
    </form>
</asp:Content>