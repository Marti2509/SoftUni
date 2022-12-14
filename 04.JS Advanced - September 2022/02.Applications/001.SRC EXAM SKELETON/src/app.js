import { page, render } from "./lib.js";
import { getUserData } from "./util.js";

// Import views!!
import { updateNav } from "./views/nav.js";

// get main element for renderer
const main = document.querySelector('');

// middle ware
page(decorateContext);

// create pages
page('/', () => console.log('homeView'));
page('/home', () => console.log('homeView'));
//..

updateNav();
page.start();

function decorateContext(ctx, next) {
    ctx.render = renderMain;
    ctx.updateNav = updateNav;

    const user = getUserData();
    if (user) {
        ctx.user = user;
    }
    
    next();
}

function renderMain(content) {
    render(content, main);
}