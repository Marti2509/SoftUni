function addItem() {
    let input = document.getElementById('newItemText');
    let list = document.getElementById('items');

    if (input === '') {
        return;
    }

    let li = document.createElement('li');
    let a = document.createElement('a');

    a.setAttribute('href', '#')
    a.textContent = '[Delete]';

    li.innerHTML = input.value;

    a.addEventListener('click', (event) => {
        event.target.parentElement.remove();
    });

    li.appendChild(a);

    list.appendChild(li);

    input.value = '';
}