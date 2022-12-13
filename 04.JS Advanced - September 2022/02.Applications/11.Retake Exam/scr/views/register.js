import { register } from "../api/user.js";
import { html } from "../lib.js";
import { updateNav } from "./nav.js";


const registerTemp = (onRegister) => html`
    <section id="register">
        <div @submit=${onRegister} class="form">
            <h2>Register</h2>
            <form class="register-form">
                <input type="text" name="email" id="register-email" placeholder="email" />
                <input type="password" name="password" id="register-password" placeholder="password" />
                <input type="password" name="re-password" id="repeat-password" placeholder="repeat password" />
                <button type="submit">register</button>
                <p class="message">Already registered? <a href="#">Login</a></p>
            </form>
        </div>
    </section>
`;

export async function showRegister(ctx) {
    ctx.render(registerTemp(onRegister));

    async function onRegister(e) {
        e.preventDefault();

        const data = new FormData(e.target);
        const { email, password, ["re-password"] : rePassword } = Object.fromEntries(data);

        if (!email || !password || !rePassword) {
            return alert("All fields ARE required!");
        }

        if (password !== rePassword) {
            return alert("The passwords MUST be the same!");
        }

        await register(email, password);
        updateNav()
        ctx.page.redirect('/catalog');
    }
}