document.getElementById("form").addEventListener('submit', onSubmit);

export function showHome() {
    [...document.querySelectorAll("section")].forEach(x => x.style.display = "none");
    document.getElementById("home-view").style.display = "block";    
}

function onSubmit(e) {
    e.preventDefault();

    const formData = new FormData(e.target);
    const { topicName, username, postText } = Object.fromEntries(formData);
    
}