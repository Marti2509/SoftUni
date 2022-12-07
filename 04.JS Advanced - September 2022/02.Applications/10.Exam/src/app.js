import { page, render } from './lib.js';
import { getUserData } from './util.js';
import * as api from "./api/user.js";
import * as api2 from "./api/data.js";
window.api = api2;

import { createPage } from './views/create.js'
import { dashboardPage } from './views/dashboard.js'
import { detailsPage } from './views/details.js'
import { registerPage } from './views/register.js'
import { loginPage } from './views/login.js'
import { homePage } from './views/home.js';
import { editPage } from './views/edit.js';
import { updateNav } from './views/nav.js';

const main = document.querySelector("main");
//const logoutBth = document.getElementById("logoutBtn");
//logoutBth.addEventListener('click', onLogout);

page(decorateContext);
page('/', homePage);
page('/catalog', dashboardPage);
page('/catalog/:id', detailsPage);
page('/edit/:id', editPage);
page('/create', createPage);
page('/login', loginPage);
page('/register', registerPage);

updateNav();
page.start();

function decorateContext(ctx, next){
    ctx.render = renderMain;
    ctx.updateNav = updateNav;

    const user = getUserData();
    if (user) {
        ctx.user = user;
    }

    next();
}

function renderMain(content){
    render(content, main);
}