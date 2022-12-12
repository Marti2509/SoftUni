import { deleteById, getById } from "../api/data.js";
import { html, nothing } from "../lib.js";
import { getUserData } from "../util.js";

const detailsTemp = (shoe, isTheRightUser, onDelete) => html`
  <section id="details">
    <div id="details-wrapper">
      <p id="details-title">Shoe Details</p>
      <div id="img-wrapper">
        <img src="${shoe.imageUrl}" alt="example1" />
      </div>
      <div id="info-wrapper">
        <p>Brand: <span id="details-brand">${shoe.brand}</span></p>
        <p>Model: <span id="details-model">${shoe.model}</span></p>
        <p>Release date: <span id="details-release">${shoe.release}</span></p>
        <p>Designer: <span id="details-designer">${shoe.designer}</span></p>
        <p>Value: <span id="details-value">${shoe.value}</span></p>
      </div>

      ${isTheRightUser
        ? html`<div id="action-buttons">
            <a href="/edit/${shoe._id}" id="edit-btn">Edit</a>
            <a @click=${onDelete} href="javascript:void(0)" id="delete-btn">Delete</a>
          </div>`
        : nothing}
    </div>
  </section>
`;

export async function showDetails(ctx) {
  const id = ctx.params.id;
  const shoe = await getById(id);
  const isTheRightUser = await isCreator();
  ctx.render(detailsTemp(shoe, isTheRightUser, onDelete));

  async function isCreator() {
    const user = await getUserData();

    if (!user) {
        return false;
    }

    if (user._id === shoe._ownerId) {
      return true;
    }
    return false;
  }

  async function onDelete() {
    const conf = confirm("Are you sure you wanna delete this shoe from the catalog?");
    
    if (conf) {
        await deleteById(id);
        ctx.page.redirect('/catalog');
    }
  }
}
