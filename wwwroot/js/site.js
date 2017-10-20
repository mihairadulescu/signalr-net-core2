// Write your Javascript code.

$(function() {
    var connection = new signalR.HubConnection('/notifications');
    connection.on("notify", function(message) {
        $("#content-notification").text(message);
    });
    connection.start();
});