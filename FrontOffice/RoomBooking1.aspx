<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="RoomBooking1.aspx.cs" Inherits="FrontOffice.RoomBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <form id="form1" runat="server" style="height: 556px">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/HotelDetails.aspx">Select a Different Hotel </asp:HyperLink>
    <div style="height: 234px">
      <title>Room Booking Form</title>

      <h1>Room Booking Form</h1>
      <label for="name">Name:</label>
      <input type="text" name="name" id="name" required><br><br>

      <label for="email">Email:</label>
      <input type="email" name="email" id="email" required><br><br>

      <label for="phone">Phone Number:</label>
      <input type="tel" name="phone" id="phone" required><br><br>

      <label for="check-in">Check-in Date:</label>
      <input type="date" name="check-in" id="check-in" required><br><br>

      <label for="check-out">Check-out Date:</label>
      <input type="date" name="check-out" id="check-out" required><br />
        <br />
        <br><br>

      <label for="room-type">Room Type:</label>
      <select name="room-type" id="room-type" required>
        <option value="">Select Room Type</option>
        <option value="single">Single</option>
        <option value="double">Double</option>
        <option value="suite">Suite</option>
      </select><br><br>

      <label for="comments">Comments:</label><br>
      <textarea name="comments" id="comments"></textarea><br><br>

      <input type="submit" value="Book Room">
    </div>
  </form>
</asp:Content>
