async function solution() {
  let main = document.getElementById("main");

  const url = "http://localhost:3030/jsonstore/advanced/articles/list";

  let response = await fetch(url);
  let data = await response.json();

  for (const item of data) {
    let currAccordion = document.createElement("div");
    currAccordion.classList.add("accordion");

    let currUrl = `http://localhost:3030/jsonstore/advanced/articles/details/${item._id}`;

    let currResponse = await fetch(currUrl);
    let currData = await currResponse.json();

    currAccordion.innerHTML = `
                <div class="head">
                    <span>${item.title}</span>
                    <button class="button" id="${item._id}">More</button>
                </div>
                <div class="extra">
                    <p>${currData.content}</p>
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
