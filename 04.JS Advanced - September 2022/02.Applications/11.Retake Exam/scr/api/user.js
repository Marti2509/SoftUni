import { setUserData, clearUserData } from "../util.js";
import { get, post } from "./api.js";

const loginUrl = '/users/login';
const registerUrl = '/users/register';
const logoutUrl = '/users/logout';

export async function login(email, password) {
    const { _id, email: resultEmail, accessToken } = await post(loginUrl, { email, password });

    setUserData({
        _id,
        email: resultEmail,
        accessToken
    });
}

export async function register(email, password) {
    const { _id, email: resultEmail, accessToken } = await post(registerUrl, { email, password });

    setUserData({
        _id,
        email: resultEmail,
        accessToken
    });
}

export async function logout() {
    get(logoutUrl);
    clearUserData();
}