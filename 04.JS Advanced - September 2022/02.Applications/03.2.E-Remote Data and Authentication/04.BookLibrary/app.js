function init() {
  let url = "http://localhost:3030/jsonstore/collections/books";
  let id = "";

  document.getElementById("loadBooks").addEventListener("click", onLoad);
  let submitBtn = document.querySelector("form button");
  submitBtn.addEventListener("click", onClick);

  let tbodyElement = document.getElementsByTagName("tbody")[0];
  let titleElement = document.getElementsByName("title")[0];
  let authorElement = document.getElementsByName("author")[0];
  let h3Element = document.getElementsByTagName("h3")[0];

  async function onLoad() {
    tbodyElement.innerHTML = "";

    let response = await fetch(url);
    let data = await response.json();

    Object.values(data).forEach((item) => {
      let tr = document.createElement("tr");
      tr.id = item._id;

      let tdBookName = document.createElement("td");
      tdBookName.textContent = item.title;

      let tdAuthorName = document.createElement("td");
      tdAuthorName.textContent = item.author;

      let tdBtns = document.createElement("td");

      let btnEdit = document.createElement("button");
      btnEdit.textContent = "Edit";
      btnEdit.addEventListener("click", onEdit);

      let btnDelete = document.createElement("button");
      btnDelete.textContent = "Delete";
      btnDelete.addEventListener("click", onDelete);

      tdBtns.appendChild(btnEdit);
      tdBtns.appendChild(btnDelete);

      tr.appendChild(tdBookName);
      tr.appendChild(tdAuthorName);
      tr.appendChild(tdBtns);

      tbodyElement.appendChild(tr);
    });
  }

  async function onClick(e) {
    e.preventDefault();

    if (e.target.textContent == "Submit") {
      if (titleElement.value == "" && typeof titleElement.value != String) {
        return;
      }
      if (authorElement.value == "" && typeof authorElement.value != String) {
        return;
      }

      await fetch(url, {
        method: "post",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          title: titleElement.value,
          author: authorElement.value,
        }),
      });
    } else {
      let putUrl = url + "/" + id;

      await fetch(putUrl, {
        method: "put",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({
          title: titleElement.value,
          author: authorElement.value,
        }),
      });

      h3Element.textContent = "FORM";
      submitBtn.textContent = "Submit";

      onLoad();
    }

    titleElement.value = "";
    authorElement.value = "";
  }

  async function onEdit(e) {
    h3Element.textContent = "Edit FORM";
    submitBtn.textContent = "Save";

    let response = await fetch(url);
    let data = await response.json();

    for (const currId in data) {
      if (
        data[currId].title ==
        e.target.parentElement.parentElement.childNodes[0].textContent
      ) {
        id = currId;
      }
    }

    titleElement.value =
      e.target.parentElement.parentElement.childNodes[0].textContent;
    authorElement.value =
      e.target.parentElement.parentElement.childNodes[1].textContent;
  }

  async function onDelete(e) {
    let response = await fetch(url);
    let data = await response.json();

    for (const currId in data) {
      if (
        data[currId].title ==
        e.target.parentElement.parentElement.childNodes[0].textContent
      ) {
        id = currId;
      }
    }

    let delUrl = url + "/" + id;

    await fetch(delUrl, {
      method: "delete",
    });

    e.target.parentElement.parentElement.remove();
  }
}

init();