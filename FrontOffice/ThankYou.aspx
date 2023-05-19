<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ThankYou.aspx.cs" Inherits="FrontOffice.ThankYou" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <br />
        <asp:Label ID="Label1" runat="server" Text="Thank you for choosing National Ecperience services!
            We appreciate your trust in our system for your booking needs.
            We are delighted to have you as our valued customer, and we look forward to serving you again in the future.
           Please do not hesitate to reach out to our dedicated support team. 
            Thank you once again, and we wish you a pleasant experience with your upcoming booking! and most importantly Enjoy your journey"></asp:Label>
        <br />
        <strong>
        <br />
                    </strong>
                    <li class="nav-item" style="text-align: center">
                         <a class="nav-link" href="ActivityBooking.aspx">
                         <div class="text-center">
                             <strong>Book Activities</strong></div>
                         </a>
                         <strong>&nbsp;</strong></li>
            <li class="nav-item" style="text-align: center">
     <a class="nav-link" href="HotelDetails.aspx">
                <div class="text-center">
                    <strong>Book a Hotel</strong></div>
                </a>
                <strong>&nbsp;</strong></li>
    <li class="nav-item">
       <a class="nav-link" href="TripBooking.aspx">
        <div class="text-center">
            <strong>Book a Trip</strong></div>
        </a>
    &nbsp;</li><br />
    <asp:Button ID="btnSignOut" runat="server" Text="Sign Out" OnClick="btnSignOut_Click" Width="1445px" />
        </form>
</asp:Content>
