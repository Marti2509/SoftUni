import { logout } from "../api/user.js";
import { html, page, render } from "../lib.js";
import { getUserData } from "../util.js";

const nav = document.querySelector('header');

const template = (isUser) => html`
    <!-- Navigation -->
    <a id="logo" href="/"><img id="logo-img" src="./images/logo.png" alt="" /></a>

    <nav>
        <div>
            <a href="/catalog">Dashboard</a>
        </div>

        ${isUser ? html`
        <div class="user">
            <a class="user" href="/create">Add Album</a>
            <a class="user" @click=${onLogout} href="javascript:void(0)">Logout</a>
        </div>`
        : html`
        <div class="guest">
            <a class="guest" href="/login">Login</a>
            <a class="guest" href="/register">Register</a>
        </div>`}

    </nav>`;

export function updateNav(){
    const user = getUserData();
    render(template(user), nav);
}

async function onLogout(){
    await logout();
    updateNav();
    page.redirect('/catalog');
}