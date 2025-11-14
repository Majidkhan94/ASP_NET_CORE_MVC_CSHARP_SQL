document.addEventListener("DOMContentLoaded", function () {
    const login = document.querySelector(".login-wrapper");
    const register = document.querySelector(".register-wrapper");

    document.querySelector(".Registeration-link").addEventListener("click", function (e) {
        e.preventDefault();
        login.classList.add("hidden");
        register.classList.remove("hidden");
    });

    document.querySelector(".login-link").addEventListener("click", function (e) {
        e.preventDefault();
        register.classList.add("hidden");
        login.classList.remove("hidden");
    });
});