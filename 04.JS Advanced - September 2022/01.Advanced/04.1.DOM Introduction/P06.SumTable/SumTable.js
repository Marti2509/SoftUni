function sumTable() {
    let items = document.querySelectorAll('table tbody tr');

    let sum = 0;

    for (let i = 1; i < items.length - 1; i++) {
        sum += Number(items[i].children[1].innerText);
    }

    let sumBox = document.getElementById('sum');
    sumBox.textContent = sum;
}