$('document').ready(() => {
    GetNewProducts();
});

function GetNewProducts() {
    $.ajax({
        type: 'POST',
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        url: 'WebServices.asmx/GetNewProducts',
        async: false,
        success: function (data) {
            const newProducts = jQuery.parseJSON(data.d);

            console.log(newProducts);

            DisplayNewProducts(newProducts);
        },
        error:() =>{
            alert('Web Service GetNewProducts Failure!');
        }
    });
}

function DisplayNewProducts(Data) {
    let x = ''

    for (i = 0; i < Data.length; i++) {

        if ((i % 3 ) == 0) {
            x += '<div class="row padding-bottom stretch">';
        }

        x += '<div class="col-md-4 card">';
        x += '<h2>'+ Data[i].Name +'</h2>';
        x += '<p>';
        x += Data[i].Description;
        x += '</p>';
        x += '</div>';

        if ((i % 3) == 2) {
            x += '</div>';
        }
    }

    $('#BodyContent').append(x);
}