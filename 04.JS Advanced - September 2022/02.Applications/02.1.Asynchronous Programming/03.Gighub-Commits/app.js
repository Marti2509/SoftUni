async function loadCommits() {
    const usernameElement = document.getElementById("username");
    const repoElement = document.getElementById("repo");
    const listElement = document.getElementById("commits");

    const url = `https://api.github.com/repos/${usernameElement.value}/${repoElement.value}/commits`;

    usernameElement.value = "";
    repoElement.value = "";
    listElement.innerHTML = "";

    try {
        let response = await fetch(url);

        if (response.ok == false) {
            throw new Error(`Error: ${response.status} (Not Found)`);
        }

        let data = await response.json();

        for (const item of data) {
            let li = document.createElement("li");
            li.textContent = `${item.author.login}: ${item.commit.message}`;

            listElement.appendChild(li);
        }
    } catch (e) {
        let li = document.createElement("li");
        li.textContent = e.message;

        listElement.appendChild(li);
    }
}