import { editItem, getById } from "../api/data.js";
import { html } from "../lib.js";

const editTemp = (shoe, onEdit) => html`
<section id="edit">
    <div class="form">
        <h2>Edit item</h2>
        <form @submit=${onEdit} class="edit-form">
            <input type="text" name="brand" id="shoe-brand" placeholder="Brand" .value="${shoe.brand}" />
            <input type="text" name="model" id="shoe-model" placeholder="Model" .value="${shoe.model}" />
            <input type="text" name="imageUrl" id="shoe-img" placeholder="Image url" .value="${shoe.imageUrl}" />
            <input type="text" name="release" id="shoe-release" placeholder="Release date" .value="${shoe.release}" />
            <input type="text" name="designer" id="shoe-designer" placeholder="Designer" .value="${shoe.designer}" />
            <input type="text" name="value" id="shoe-value" placeholder="Value" .value="${shoe.value}" />
            <button type="submit">post</button>
        </form>
    </div>
</section>
`;

export async function showEdit(ctx) {
    const id = ctx.params.id;
    const shoe = await getById(id);
    ctx.render(editTemp(shoe, onEdit));

    async function onEdit(e) {
        e.preventDefault();

        const formData = new FormData(e.target);
        const { brand, model, imageUrl, release, designer, value } = Object.fromEntries(formData);

        if (!brand || !model || !imageUrl || !release || !designer || !value) {
            return alert("All field are required!");
        }

        await editItem(id, { brand, model, imageUrl, release, designer, value });
        ctx.page.redirect(`/details/${id}`);
    }
}
