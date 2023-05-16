$('.add-to-room-cart').click(function () {
    var roomId = parseInt($(this).data('room-id'));
    var roomType = $(this).data('room-type');
    var roomPrice = parseFloat($(this).data('room-price'));
    var quantity = parseInt($('#quantity-' + roomId).val());

    $.ajax({
        type: 'POST',
        url: 'AddToRoomCart.aspx/AddItemToCart',
        data: JSON.stringify({ roomId: roomId, roomType: roomType, roomPrice: roomPrice, quantity: quantity }),
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (response) {
            if (response.d) {
                window.location.href = 'Checkout.aspx';
            } else {
                alert('Error adding the room to the cart.');
            }
        },
        error: function (response) {
            alert('Error: ' + response.responseText);
        }
    });
});