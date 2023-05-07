<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ActivitiesCustomer.aspx.cs" Inherits="FrontOffice.ActivitiesCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
            <% foreach (var activity in ActivitiesList) { %>
                <div class="col-md-4">
                    <div class="card" style="width: 18rem;">
                        <div class="card-body">
                            <h5 class="card-title"><%= activity.ActivityName %></h5>
                            <h6 class="card-subtitle mb-2 text-muted"><%= activity.ActivityCity %></h6>
                            <label for="quantity-<%= activity.ActivityID %>">Quantity:</label>
<input type="number" id="quantity-<%= activity.ActivityID %>" name="quantity" min="1" max="<%= activity.NoOfPeople %>" value="1">
<button class="btn btn-primary add-to-cart" data-activity-id="<%= activity.ActivityID %>" data-activity-name="<%= activity.ActivityName %>" data-activity-price="<%= activity.ActivityPrice %>">Add to Cart</button>
                            <p class="card-text">
                                <%= activity.ActivityAddress %><br>
                                <%= activity.ActivityPostCode %><br>
                                <%= activity.ActivityDescription %><br>
                                No of people: <%= activity.NoOfPeople %><br>
                                Price: <%= activity.ActivityPrice %>
                            </p>
                        </div>
                    </div>
                </div>
            <% } %>
        </div>
    </div>
    <script>
        $(document).ready(function () {
            $('.add-to-cart').click(function () {
                var activityId = parseInt($(this).data('activity-id'));
                var activityName = $(this).data('activity-name');
                var activityPrice = parseFloat($(this).data('activity-price'));
                var quantity = parseInt($('#quantity-' + activityId).val());

                $.ajax({
                    type: 'POST',
                    url: 'AddToCart.aspx/AddToCart',
                    data: JSON.stringify({ activityId: activityId, activityName: activityName, activityPrice: activityPrice, quantity: quantity }),
                    contentType: 'application/json; charset=utf-8',
                    dataType: 'json',
                    success: function (response) {
                        if (response.d) {
                            window.location.href = 'Checkout.aspx';
                        } else {
                            alert('Error adding the activity to the cart.');
                        }
                    },
                    error: function (response) {
                        alert('Error: ' + response.responseText);
                    }
                });
            });
        });
    </script>
</asp:Content>
