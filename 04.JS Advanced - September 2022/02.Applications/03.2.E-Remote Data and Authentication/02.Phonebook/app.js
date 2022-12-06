function attachEvents() {
    const phonebookElement = document.getElementById("phonebook");
    const personElement = document.getElementById("person");
    const phoneElement = document.getElementById("phone");

    document.getElementById("btnLoad").addEventListener("click", onLoad);
    document.getElementById("btnCreate").addEventListener("click", onCreate);

    const url = "http://localhost:3030/jsonstore/phonebook";

    async function onLoad() {
        let response = await fetch(url);
        let data = await response.json();

        phonebookElement.innerHTML = "";

        for (const person in data) {
            let li = document.createElement("li");
            li.setAttribute('data-id', person._id);
            li.textContent = data[person].person + ": " + data[person].phone;

            let deleteBtn = document.createElement("button")
            deleteBtn.textContent = "Delete";
            deleteBtn.addEventListener("click", onDelete);

            li.appendChild(deleteBtn);
            phonebookElement.appendChild(li);
        }
    }

    async function onCreate() {
        await fetch(url, {
            method: 'post',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ person: personElement.value, phone: phoneElement.value })
        });

        personElement.value = "";
        phoneElement.value = "";

        onLoad(); // it will automatically update the text area
    }

    async function onDelete(e) {
        const delUrl = url + '/' + e.target.parentElement.id;

        await fetch(delUrl, {
            method: 'delete'
        });
        e.target.parentElement.remove();
    }
}

attachEvents();