import { register } from "../api/user.js";
import { html } from "../lib.js";
import { updateNav } from "./nav.js";

const registerTemp = (onRegister) => html`
<section id="register">
          <div class="form">
            <h2>Register</h2>
            <form @submit=${onRegister} class="login-form">
              <input type="text" name="email" id="register-email" placeholder="email"
              />
              <input type="password" name="password" id="register-password" placeholder="password"
              />
              <input type="password" name="re-password" id="repeat-password" placeholder="repeat password"
              />
              <button type="submit">login</button>
              <p class="message">Already registered? <a href="#">Login</a></p>
            </form>
          </div>
        </section>
`;

export function showRegister(ctx) {
  ctx.render(registerTemp(onRegister));

  async function onRegister(e) {
    e.preventDefault();

    const formData = new FormData(e.target);
    const { email, password, ['re-password']: rePassword } = Object.fromEntries(formData);

    if (!email || !password || !rePassword) {
      return alert("All field ARE required!");
    }
    if (password !== rePassword) {
        return alert("The passwords MUST be the same!")
    }

    await register(email, password);
    ctx.page.redirect("/catalog");
    updateNav();
  }
}
