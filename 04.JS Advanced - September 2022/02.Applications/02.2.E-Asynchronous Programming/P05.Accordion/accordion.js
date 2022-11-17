async function solution() {
  let main = document.getElementById("main");

  const url = "http://localhost:3030/jsonstore/advanced/articles/list";

  let response = await fetch(url);
  let data = await response.json();

  for (const item of data) {
    let currAccordion = document.createElement("div");
    currAccordion.classList.add("accordion");

    currAccordion.innerHTML = `
                <div class="head">
                    <span>${item.title}</span>
                    <button class="button" id="${item._id}">More</button>
                </div>
                <div class="extra">
                    <p></p>
            </div>
        `;

    main.appendChild(currAccordion);
  }

  let btnElements = document.getElementsByClassName("button");

  for (const btn of btnElements) {
    btn.addEventListener("click", click);
  }

  async function click(e) {
    let btn = e.target;

    let currUrl = `http://localhost:3030/jsonstore/advanced/articles/details/${btn.id}`;

    let currResponse = await fetch(currUrl);
    let currData = await currResponse.json();

    btn.parentElement.parentElement.childNodes[3].textContent =
      currData.content;

    if (btn.textContent === "More") {
      btn.textContent = "Less";
      btn.parentElement.parentElement.childNodes[3].classList.remove("extra");
    } else if (btn.textContent === "Less") {
      btn.textContent = "More";
      btn.parentElement.parentElement.childNodes[3].classList.add("extra");
    }
  }
}

solution();
