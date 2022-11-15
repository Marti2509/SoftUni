async function loadRepos() {
	const inputElement = document.getElementById("username");
	const listElement = document.getElementById("repos");

	const url = `https://api.github.com/users/${inputElement.value}/repos`;

	listElement.innerHTML = "";
	inputElement.value = "";

	let response = await fetch(url);
	let data = await response.json();

	for (const item of data) {
		let li = document.createElement("li");

		let a = document.createElement("a");
		a.setAttribute("href", item.html_url);
		a.textContent = item.full_name;

		li.appendChild(a);
		listElement.appendChild(li);
	}
}

//<li>
//   <a href="{repo.html_url}">
//      {repo.full_name}
//   </a>
//</li>