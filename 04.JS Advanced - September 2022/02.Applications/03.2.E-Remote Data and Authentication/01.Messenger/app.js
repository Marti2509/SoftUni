function attachEvents() {
    const authorElement = document.getElementsByName("author")[0];
    const contentElement = document.getElementsByName("content")[0];
    const messagesElement = document.getElementById("messages");

    document.getElementById("submit").addEventListener("click", onSubmit);
    document.getElementById("refresh").addEventListener("click", onRefresh);

    const url = "http://localhost:3030/jsonstore/messenger";

    async function onSubmit() {
        await fetch(url, {
            method: 'post',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ author: authorElement.value, content: contentElement.value })
        });

        authorElement.value = "";
        contentElement.value = "";

        //onRefresh(); -> it will automatically update the text area
    }

    async function onRefresh() {
        let response = await fetch(url);
        let data = await response.json();

        messagesElement.textContent = "";

        messagesElement.textContent = Object.values(data).map(el => `${el.author}: ${el.content}`).join('\n');
    }
}

attachEvents();

/*
{
    author: authorName,
    content: msgText,
}

`${el.author}: ${el.content}`
*/