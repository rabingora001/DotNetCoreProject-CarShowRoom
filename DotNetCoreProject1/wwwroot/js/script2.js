//**********************************************************************************************************************
//javascript for mouse hover display.
const mouseHoverActivity = document.getElementById("mouseHover");

//this funtion can also be done by addEventlistener or directly calling method from html attribute.
mouseHoverActivity.onmouseover = function () { mouseOver() };
mouseHoverActivity.onmouseout = function () { mouseOut() };

function mouseOver() {

    console.log(" mouse in thisisis sdf printning");
    document.getElementById("demo2").textContent = "**Note: Login and registration forms. The validation is " +
        "done in password matching in registration page (link is available below). Both forms are validated" +
        " to check the availability of email and usernames.";
}

function mouseOut() {
    console.log("thisisis sdf printning");
    document.getElementById("demo2").textContent = "";
}
