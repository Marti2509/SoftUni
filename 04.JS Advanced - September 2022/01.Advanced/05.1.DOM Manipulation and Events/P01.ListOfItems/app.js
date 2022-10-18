function addItem() {
    let input = document.getElementById('newItemText');
    let list = document.getElementById('items');

    let li = document.createElement('li');
    li.textContent = input.value;

    list.appendChild(li);

    input.value = '';
}