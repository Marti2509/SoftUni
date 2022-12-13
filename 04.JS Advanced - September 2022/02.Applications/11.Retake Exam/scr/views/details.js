import { deleteById, getById } from "../api/data.js";
import { html, nothing } from "../lib.js";
import { getUserData } from "../util.js";

const detailsTemp = (onDelete, product, isCreator, hasUser) => html`
    <section id="details">
        <div id="details-wrapper">
            <img id="details-img" src="${product.imageUrl}" alt="example1" />
            <p id="details-title">${product.name}</p>
            <p id="details-category">
                Category: <span id="categories">${product.category}</span>
            </p>
            <p id="details-price">
                Price: <span id="price-number">${product.price}</span>$
            </p>
            <div id="info-wrapper">
                <div id="details-description">
                    <h4>Bought: <span id="buys">0</span> times.</h4>
                    <span>${product.description}</span>
                </div>
            </div>

            ${isCreator
            ? html`<div id="action-buttons">
                <a href="/edit/${product._id}" id="edit-btn">Edit</a>
                <a @click=${onDelete} href="javascript:void(0)" id="delete-btn">Delete</a>
            </div>`
            : html`${hasUser
            ? html`<div id="action-buttons"> <a href="/buy" id="buy-btn">Buy</a> </div>`
            : nothing}`}
        </div>
    </section>
`;

export async function showDetails(ctx) {
    const id = ctx.params.id;
    const product = await getById(id);

    const hasUser = await getUserData();

    let isCreator = false;
    if (product._ownerId === hasUser._id) {
        isCreator = true;
    }

    ctx.render(detailsTemp(onDelete, product, isCreator, hasUser));

    async function onDelete() {
        const conf = confirm("Are you sure you want to delete this product from the catalog?");

        if (conf) {
            await deleteById(id);
            ctx.page.redirect('/catalog');
        }
    }
}
