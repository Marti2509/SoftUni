async function lockedProfile() {
    let mainDiv = document.querySelector('#main');
    mainDiv.innerHTML = '';

    const url = "http://localhost:3030/jsonstore/advanced/profiles";

    let response = await fetch(url);
    let data = await response.json();

    Object.values(data).forEach((user, i) => {
        let div = document.createElement("div");
        div.classList.add("profile");

        let counter = i + 1;

        div.innerHTML = `
            <img src="./iconProfile2.png" class="userIcon" />
            <label>Lock</label>
            <input type="radio" name="user${counter}Locked" value="lock" checked>
            <label>Unlock</label>
            <input type="radio" name="user${counter}Locked" value="unlock"><br>
            <hr>
            <label>Username</label>
            <input type="text" name="user${counter}Username" value="${user.username}" disabled readonly />
            <div class="user${counter}HiddenFields" style="display:none">
                <hr>
                <label>Email:</label>
                <input type="email" name="user${counter}Email" value="${user.email}" disabled readonly />
                <label>Age:</label>
                <input type="email" name="user${counter}Age" value="${user.age}" disabled readonly />
            </div>
				
			<button>Show more</button>
        `;

        mainDiv.appendChild(div);
    });

    let buttonElements = document.querySelectorAll('div button');
    for (let i = 0; i < buttonElements.length; i++) {
        let counter = i + 1;

        let button = buttonElements[i];
        let profileElement = button.parentElement;
        let lockedElement = profileElement.querySelector('input[value="lock"]');
        let hiddenInfoElement = profileElement.getElementsByClassName(`user${counter}HiddenFields`)[0];

        button.addEventListener('click', () => {

            if (!lockedElement.checked && button.textContent == 'Show more') {
                hiddenInfoElement.style.display = 'block';
                button.textContent = 'Hide it';
            } else if (!lockedElement.checked && button.textContent == 'Hide it') {
                hiddenInfoElement.style.display = 'none';
                button.textContent = 'Show more';
            }

        });
    }
}