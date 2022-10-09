function extract(content) {
    let text = document.getElementById(content).textContent;

    let pattern = /\(([^)]+)\)/g;

    let items = text.matchAll(pattern);

    let result = [];

    for (const item of items) {
        result.push(item[1]);
    }

    return result.join('; ');
}