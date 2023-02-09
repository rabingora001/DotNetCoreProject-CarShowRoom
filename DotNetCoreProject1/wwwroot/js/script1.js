const userAccounts = [{
    "firstName": "rabin", "lastName": "Gora", "email": "rabin.gora@gmail.com", "username": "rabin001"
},
{
    "firstName": "Adam", "lastName": "Roger", "email": "rogers@gmail.com", "username": "roger"
},
{
    "firstName": "Nathan", "lastName": "stone", "email": "nathan@gmail.com", "username": "nathan"
},
{
    "firstName": "Jasmine", "lastName": "Lopez", "email": "lopez1@yahoo.com", "username": "jasmine"
},
{
    "firstName": "Kiara", "lastName": "valencia", "email": "valencia99@gmail.com", "username": "kiara"
}
];

//get placeholder for users form html id.
const list = document.getElementById("usersPlaceholder");

//get button id to click.
const usersButton = document.getElementById("usersButton");

//get button id to clear.

const clearButton = document.getElementById("usersClearButton");

//session create funtion from the Json uer data.

function createSessionElement(session) {
    const li = document.createElement("li");
    li.textContent = "Name: " + session.firstName + " " + session.lastName + "     Email: " + session.email + "     Username: " + session.username;
    return li;
};

//function to clear list.

function clearList() {
    while (list.firstChild) {
        list.removeChild(list.firstChild);
    }
};

//displya list of users
function displayUsers() {
    clearList();

    for (let i = 0; i < userAccounts.length; i++) {
        const li1 = createSessionElement(userAccounts[i]);
        list.appendChild(li1);
    }
    console.log("this is printint");
}

function voteYes() {
    document.getElementById("demo1").innerHTML = "Google.com";
};

function voteNo() {
    document.getElementById("demo1").innerHTML = "No";
};

//Event listeners for the buttons. they call the functions after events.
usersButton.addEventListener("click", displayUsers, false);
usersClearButton.addEventListener("click", clearList, false);
