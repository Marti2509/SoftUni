import { get, post, put, del } from "./api.js";

// ADD URLs

export async function getAll() {
    return await get("");
}

export async function getById(id) {
    return await get(`${id}`);
}

export async function create(item) {
    return await post("", item);
}

export async function editItem(id, item) {
    return await put(`${id}`, item);
}

export async function deleteById(id) {
    return await del(`${id}`);
}