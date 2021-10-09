// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    console.log("Page is ready");
    //Prevent a right click from presenting a menu
    $(document).bind("contextmenu", function (e) {
        e.preventDefault();
    });


    $(document).on("mousedown", ".game-button", function (event) {
        switch (event.which) {
            case 1:
                //Left click
                event.preventDefault();
                var tileN = $(this).val();
                console.log(tileN);
                updateBoard(tileN, "/game/showOneCell");
                break;
            case 2:
                break;
            case 3:
                //Right click
                event.preventDefault();
                var tileN = $(this).val();
                console.log(tileN);
                updateBoard(tileN, "/game/rightClickOneCell");
                break;
            default:
                break;
        }
        
    })
    
});

function updateBoard(tileN, urlString) {
    $.ajax({
        datatype: "json",
        method: 'POST',
        url: urlString,
        data: {
            "tileNumber": tileN
        },
        success: function (data) {
            console.log(data);
            $("#" + tileN).html(data);
        }
    });

}