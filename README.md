# phoneGapWebApi
Simple test PhoneGap using WebApi Get Ajax
// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkID=397704
// To debug code on page load in Ripple or on Android devices/emulators: launch your app, set breakpoints,
// and then run "window.location.reload()" in the JavaScript Console.
(function () {
    "use strict";

    document.addEventListener('deviceready', onDeviceReady.bind(this), false);

    function onDeviceReady() {
        // Handle the Cordova pause and resume events
        document.addEventListener('pause', onPause.bind(this), false);
        document.addEventListener('resume', onResume.bind(this), false);

        var botaoObter = document.querySelector('#btnObter');
        botaoObter.addEventListener("click", Obtem, false);
    };

    function onPause() {
        // TODO: This application has been suspended. Save application state here.
    };

    function onResume() {
        // TODO: This application has been reactivated. Restore application state here.
    };

    function Obtem() {
        $.ajax({
            url: 'http://localhost:44408/api/Cordova',
            type: "GET",
            crossDomain: true,
            contentType: "application/json; charset=utf-8",
            dataType: "jsonp",
            error: function (xhr, textStatus, errorThrown) {
                alert("xhr.status: " + xhr.status);
            },
            timeout: 60000,
            success: function (data) {
                $("#result").html("");
                for (var i in data) {
                    $("#result").append("<li>" + data[i] + "</li>");
                }
            },
            cache: false
        });
    }
})();
