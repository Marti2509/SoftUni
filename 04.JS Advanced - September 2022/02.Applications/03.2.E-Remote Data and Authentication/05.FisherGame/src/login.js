let url = "http://localhost:3030/users/login";

document.getElementById('login').addEventListener('submit', onLogin);
document.querySelectorAll('a').forEach(x => x.classList.remove('active'));
document.getElementById('login').classList.add('active');
document.getElementById('user').style.display = 'none';

let emailElement = document.getElementsByName("email")[0];
let passwordElement = document.getElementsByName("password")[0];

async function onLogin(e) {
    e.preventDefault();

    let email = emailElement.value;
    let password = passwordElement.value;

    let response = await fetch(url, {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
            email: email,
            password: password
        })
    });
    let data = response.json();

    console.log(data);
}