// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {

    $('#b1').click(function () {
        var data = $('#txtData').val();

        $.get('/Home/MyAction', { inputData: data }, function (result) {

            $('#partialPlaceHolder').html(result).fadeIn('slow');
        });


    }
            

    );

});