function extractText() {
    let elements = document.querySelectorAll('ul#items li');
    let box = document.querySelector('#result');

    for (const item of elements) {
        box.textContent += item.innerText + '\n';
    }
}