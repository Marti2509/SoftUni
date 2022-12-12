import { logout } from "../api/user.js";
import { html, page, render } from "../lib.js";
import { getUserData } from "../util.js";

const nav = document.querySelector("nav");

const navTemp = (hasUser) => html`
  <div>
    <a href="/catalog">Dashboard</a>
    <a href="/search">Search</a>
  </div>

  ${hasUser
    ? html`
        <div class="user">
          <a href="/create">Add Pair</a>
          <a href="javascript:void(0)" @click=${onLogout}>Logout</a>
        </div>
      `
    : html`
        <div class="guest">
          <a href="/login">Login</a>
          <a href="/register">Register</a>
        </div>
      `}
`;

export function updateNav() {
  const user = getUserData();

  render(navTemp(user), nav);
}

function onLogout() {
  logout();
  updateNav();
  page.redirect("/");
}
