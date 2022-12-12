import { login } from "../api/user.js";
import { html } from "../lib.js";
import { updateNav } from "./nav.js";

const loginTemp = (onLogin) => html`
  <section id="login">
    <div class="form">
      <h2>Login</h2>
      <form @submit=${onLogin} class="login-form">
        <input type="text" name="email" id="email" placeholder="email" />
        <input type="password" name="password" id="password" placeholder="password" />
        <button type="submit">login</button>
        <p class="message">
          Not registered? <a href="/register">Create an account</a>
        </p>
      </form>
    </div>
  </section>
`;

export function showLogin(ctx) {
  ctx.render(loginTemp(onLogin));

  async function onLogin(e) {
    e.preventDefault();

    const formData = new FormData(e.target);
    const { email, password } = Object.fromEntries(formData);

    if (!email || !password) {
      return alert("All field are required!");
    }

    await login(email, password);
    
    updateNav();
    e.target.reset();
    ctx.page.redirect("/catalog");
  }
}