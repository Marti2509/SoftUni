import { logout } from "../api/user.js";
import { html, page, render } from "../lib.js";
import { getUserData } from "../util.js";

// get the nav element from the document
const nav = document.querySelector("nav");

const navTemp = (hasUser) => html`
    <div>
        <a href="/catalog">Products</a>
    </div>

    ${hasUser
        ? html`<div class="user">
        <a href="/create">Add Product</a>
        <a @click=${onLogout} href="javascript:void(0)">Logout</a>
    </div>`
        : html`<div class="guest">
        <a href="/login">Login</a>
        <a href="/register">Register</a>
    </div>`}
`;

export function updateNav() {
    const user = getUserData();

    render(navTemp(user), nav);
}

function onLogout() {
    logout();
    updateNav();
    page.redirect("/catalog");
}
