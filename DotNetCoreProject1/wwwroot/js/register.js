//**********************************************************************************
//javascript to check password and confirm password matching.

const passwordInput = document.getElementById("Password");
const confirmPasswordInput = document.getElementById("ConfirmPassword");


//check if the password and confirm password matches. If matches do nothing. else display password not matched.

const checkPasswords = function () {
    passwordMatched = passwordInput.value === confirmPasswordInput.value;

    if (passwordMatched) {
        confirmPasswordInput.setCustomValidity("");
    } else {
        confirmPasswordInput.setCustomValidity("confirm password did not match with password.")
    }
}

//event listener for the inputs in passwords
const addPasswordInputEventListeners = function () {
    //Listen for the "input" event on passwordInput and confirmPasswordInput.

    passwordInput.addEventListener("input", checkPasswords, false);
    confirmPasswordInput.addEventListener("input", checkPasswords, false);
};

//call the listener function
addPasswordInputEventListeners();
