var connection = new signalR.HubConnectionBuilder().withUrl("https://localhost:7294/SignalRHub").build();
document.getElementById("sendMessage").disabled = true;
connection.on("ReceiveMessage", function (user, message) {
    var currentTime = new Date();
    var currentHour = currentTime.getHours();
    var currentMinnute = currentTime.getMinutes();
    var li = document.createElement("li");
    var span = document.createElement("span");
    span.style.fontWeight = "bold";
    span.textContent = user;
    li.appendChild(span);
    li.innerHTML += `: ${message} - ${currentHour}:${currentMinnute}`;
    document.getElementById("messageList").appendChild(li);
});

connection.start().then(function () {
    document.getElementById("sendMessage").disabled = false;
}).catch(function (err) {
    return cosole.error(err.toString());
});

document.getElementById("sendMessage").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return cosole.error(err.toString());

    });
    event.preventDefault();
});