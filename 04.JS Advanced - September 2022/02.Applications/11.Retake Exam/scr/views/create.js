import { create } from "../api/data.js";
import { html } from "../lib.js";

const createTemp = (onCreate) => html`
<section id="create">
    <div class="form">
        <h2>Add Product</h2>
        <form @submit=${onCreate} class="create-form">
            <input type="text" name="name" id="name" placeholder="Product Name" />
            <input type="text" name="imageUrl" id="product-image" placeholder="Product Image" />
            <input type="text" name="category" id="product-category" placeholder="Category" />
            <textarea id="product-description" name="description" placeholder="Description" rows="5" cols="50"></textarea>
            <input type="text" name="price" id="product-price" placeholder="Price" />
            <button type="submit">Add</button>
        </form>
    </div>
</section>
`;

export function showCreate(ctx) {
    ctx.render(createTemp(onCreate));

    async function onCreate(e) {
        e.preventDefault();

        const data = new FormData(e.target);
        const { name, imageUrl, category, description, price } = Object.fromEntries(data);

        if (!name || !imageUrl || !category || !description || !price) {
            return alert("All fields ARE required!");
        }

        await create({ name, imageUrl, category, description, price });
        ctx.page.redirect('/catalog');
    }
}