<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ActivitiesCustomer.aspx.cs" Inherits="FrontOffice.ActivitiesCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>
<html>
<head>
    <title>Activities</title>
    <!-- Add the required CSS and JavaScript files -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</head>
<body>
    <div class="container">
        <h1>Activities</h1>
        <div class="row">
            <!-- Loop through activities and generate a card for each activity -->
            <% foreach (var activity in ActivitiesList) { %>
                <div class="col-md-4">
                    <div class="card" style="width: 18rem;">
                        <div class="card-body">
                            <h5 class="card-title"><%= activity.ActivityName %></h5>
                            <h6 class="card-subtitle mb-2 text-muted"><%= activity.ActivityCity %></h6>
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
</body>
</html>
</asp:Content>
