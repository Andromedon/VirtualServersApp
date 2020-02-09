function fakeProgress(dotNet) {
    var button = document.getElementById("serverButton");
    var index = 0;
    if (button) {
        button.setAttribute("disabled", true);
        setInterval(function () {
            if (index < 100) {
                index++;
                button.innerHTML = index + "%";
            }
        }, 50);

        setTimeout(function () {
            button.innerHTML = "Done!";
            button.removeAttribute("disabled");
            console.log("Finished JS!");
            dotNet.invokeMethodAsync("BeforeCreateServer");
            dotNet.invokeMethodAsync("CreateNewServer");
            //.then(result => { console.log(result) });
        }, 5001);
    }
}    