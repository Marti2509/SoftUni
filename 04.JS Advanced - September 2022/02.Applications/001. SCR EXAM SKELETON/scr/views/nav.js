import { logout } from "../api/user.js";
import { html, page, render } from "../lib.js";
import { getUserData } from "../util.js";

// get the nav element from the document
const nav = document.querySelector('nav');

const navTemp = (hasUser) => html`
    // put the nav
    // hasUser is true or false!!
    // add logout btn!!
`;

export function updateNav() {
    const user = getUserData();

    render(navTemp(user), nav);
}

function onLogout() {
    logout();
    updateNav();
    page.redirect('/');
}