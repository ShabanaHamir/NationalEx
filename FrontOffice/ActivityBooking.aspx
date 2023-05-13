<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ActivityBooking.aspx.cs" Inherits="FrontOffice.ActivityBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <head>
            <script src="activitiesCustomer.js"></script>
        </head>
        <div class="container">
            <h1>Activities</h1>
            <div class="row">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="ActivitiesCustomer.aspx">Activities</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Checkout.aspx">Checkout</a>
                    </li>
                </ul>
       <!-- Loop through activities and generate a card for each activity -->
            <% if (ActivitiesList != null && ActivitiesList.Count > 0) { %>
    <%# Eval("ActivityName") %>
                <asp:Repeater ID="rptActivities" runat="server" OnItemCommand="rptActivities_ItemCommand">
    <ItemTemplate>
    <div class="col-md-4">
        <div class="card" style="width: 18rem;">
            <div class="card-body">
                <h5 class="card-title"><%# Eval("ActivityName") %></h5>
                <h6 class="card-subtitle mb-2 text-muted"><%# Eval("ActivityCity") %></h6>
                <p class="card-text">Price: <%# Eval("ActivityPrice") %></p>
                <label for="txtQTY">Quantity:</label>
                <asp:TextBox ID="txtQTY" runat="server" CssClass="form-control" />
                <asp:Button ID="btnAdd" runat="server" Text="Add to Cart" CssClass="btn btn-primary mt-2" CommandName="AddToCart" CommandArgument='<%# Eval("ActivityID") %>' />
            </div>
        </div>
    </div>
</ItemTemplate>
</asp:Repeater>
                <%# Eval("ActivityCity") %><% } %>
</div>
</div>
<script>
  
</script>
</form>

</asp:Content>