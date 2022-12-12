import { get, post, put, del } from "./api.js";

export async function getAll() {
    return await get("/data/shoes?sortBy=_createdOn%20desc");
}

export async function getById(id) {
    return await get(`/data/shoes/${id}`);
}

export async function create(item) {
    return await post("/data/shoes", item);
}

export async function editItem(id, item) {
    return await put(`/data/shoes/${id}`, item);
}

export async function deleteById(id) {
    return await del(`/data/shoes/${id}`);
}