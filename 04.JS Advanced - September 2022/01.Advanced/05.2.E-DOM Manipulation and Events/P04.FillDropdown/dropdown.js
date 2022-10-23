function addItem() {

    let newItemText = document.getElementById('newItemText');
    let newItemValue = document.getElementById('newItemValue');

    let menu = document.getElementById('menu');
    let optionItem = document.createElement('option');

    optionItem.textContent = newItemText.value;
    optionItem.value = newItemValue.value;
    menu.appendChild(optionItem);

    newItemText.value = '';
    newItemValue.value = '';
}