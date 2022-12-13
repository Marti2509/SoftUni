import { get, post, put, del } from "./api.js";

export async function getAll() {
    return await get("/data/products?sortBy=_createdOn%20desc");
}

export async function getById(id) {
    return await get(`/data/products/${id}`);
}

export async function create(item) {
    return await post("/data/products", item);
}

export async function editItem(id, item) {
    return await put(`/data/products/${id}`, item);
}

export async function deleteById(id) {
    return await del(`/data/products/${id}`);
}