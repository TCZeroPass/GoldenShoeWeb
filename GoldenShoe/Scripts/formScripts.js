
// JQuery populate PRODUCT SELECTION
$(document).ready(function () {
    var products = $('#productSelection');

    $.ajax({
        type: "GET",
        url: "/Api/Product",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        data: {},
        success: function (data) {
            // alert(JSON.stringify(data));                                                                 //test to see the results
            products.empty();
            $.each(data, function (index, item) {
                $('#productSelection').append($('<option/>').val(item.productID).html(item.productName));
            });
        },
        failure: function () {
            alert("Error");
        }
    });

});

// VALIDATION OF THE FORM 

var form = document.querySelector('.needs-validation');

form.addEventListener('submit', function (event) {
    if (form.checkValidity() === false) {
        event.preventDefault();
        event.stopPropagation();
    }
    form.classList.add('was-validated');


});

//submit data in json form to web API
//$("#form1").submit(function () {
//    var jqxhr = $.post('/api/updates/complex', $('#form1').serialize())
//        .success(function () {
//            var loc = jqxhr.getResponseHeader('Location');
//            var a = $('<a/>', { href: loc, text: loc });
//            $('#message').html(a);
//        })
//        .error(function () {
//            $('#message').html("Error posting the update.");
//        });
//    return false;
//});