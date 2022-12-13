import { editItem, getById } from "../api/data.js";
import { html } from "../lib.js";

const editTemp = (onEdit, product) => html`
    <section id="edit">
        <div class="form">
            <h2>Edit Product</h2>
            <form @submit=${onEdit} class="edit-form">
                <input type="text" name="name" id="name" placeholder="Product Name" .value="${product.name}" />
                <input type="text" name="imageUrl" id="product-image" placeholder="Product Image" .value="${product.imageUrl}" />
                <input type="text" name="category" id="product-category" placeholder="Category" .value="${product.category}" />
                <textarea id="product-description" name="description" placeholder="Description" .value="${product.description}" rows="5" cols="50"></textarea>
                <input type="text" name="price" id="product-price" placeholder="Price" .value="${product.price}" />
                <button type="submit">post</button>
            </form>
        </div>
    </section>
`;

export async function showEdit(ctx) {
    const id = ctx.params.id;
    const product = await getById(id);

    ctx.render(editTemp(onEdit, product));

    async function onEdit(e) {
        e.preventDefault();

        const data = new FormData(e.target);
        const { name, imageUrl, category, description, price } = Object.fromEntries(data);

        if (!name || !imageUrl || !category || !description || !price) {
            return alert("All fields ARE required!");
        }

        await editItem(id, { name, imageUrl, category, description, price });
        ctx.page.redirect(`/details/${id}`);
    }
}