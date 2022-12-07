import { html, nothing } from "../lib.js";
import { deleteById, getById } from "../api/data.js";
import { getUserData } from "../util.js";

export const detailsTemplate = (album, hasUser, isOwner, onDelete) =>  html`
<section id="details">
        <div id="details-wrapper">
          <p id="details-title">Album Details</p>
          <div id="img-wrapper">
            <img src="${album.imageUrl}" alt="example1" />
          </div>
          <div id="info-wrapper">
            <p><strong>Band:</strong><span id="details-singer">${album.singer}</span></p>
            <p>
              <strong>Album name:</strong><span id="details-album">${album.album}</span>
            </p>
            <p><strong>Release date:</strong><span id="details-release">${album.release}</span></p>
            <p><strong>Label:</strong><span id="details-label">${album.label}</span></p>
            <p><strong>Sales:</strong><span id="details-sales">${album.sales}</span></p>
          </div>
          <div id="likes">Likes: <span id="likes-count">0</span></div>

          <!--Edit and Delete are only for creator-->
          ${hasUser ? html`
            <div id="action-buttons">
            <a href="" id="like-btn">Like</a>
            
            ${isOwner ? html`<a href="/edit/${album._id}" id="edit-btn">Edit</a>
            <a @click=${onDelete} href="javascript:void(0)" id="delete-btn">Delete</a>` : nothing}

          </div>`: nothing}
        </div>
      </section>
`;

export async function detailsPage(ctx) {
    const album = await getById(ctx.params.id);

    const hasUser = Boolean(ctx.user);
    const isOwner = hasUser && ctx.user._id == album._ownerId;

    ctx.render(detailsTemplate(album, hasUser, isOwner, onDelete));

    async function onDelete() {
        const choice = confirm("Do you want to delete the album?");

        if (choice) {
            await deleteById(ctx.params.id);
            ctx.page.redirect("/catalog");
        }
    }
}