async function loadRepos() {
   const divElement = document.getElementById("res");

   const url = "https://api.github.com/users/testnakov/repos";

   let response = await fetch(url);
   let data = await response.json();

   divElement.textContent = JSON.stringify(data);
}