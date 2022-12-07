import * as api from './api.js';

export async function getAll() {
  return await api.get("/data/albums/?sortBy=_createdOn%20desc");
}

export async function getById(id) {
  return await api.get(`/data/albums/${id}`);
}

export async function create(item) {
  return await api.post(`/data/albums`, item);
}

export async function editItem(id, item) {
  return await api.put(`/data/albums/${id}`, item);
}

export async function deleteById(id) {
  return await api.del(`/data/albums/${id}`);
}