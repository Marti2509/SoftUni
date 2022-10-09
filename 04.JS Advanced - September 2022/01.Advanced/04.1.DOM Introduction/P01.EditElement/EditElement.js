function editElement(element, match, replacer) {
    let text = element.textContent;

    let replace = new RegExp(match, 'g');

    let newText = text.replace(replace, replacer);

    element.textContent = newText;
}