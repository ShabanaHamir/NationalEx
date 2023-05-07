$('.add-to-cart').click(function () {
    var activityId = parseInt($(this).data('activity-id'));
    var activityName = $(this).data('activity-name');
    var activityPrice = parseFloat($(this).data('activity-price'));
    var quantity = parseInt($('#quantity-' + activityId).val());

    $.ajax({
        type: 'POST',
        url: 'AddToCart.aspx/AddItemToCart',
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
