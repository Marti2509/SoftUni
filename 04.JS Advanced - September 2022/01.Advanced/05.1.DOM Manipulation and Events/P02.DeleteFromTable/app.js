function deleteByEmail() {
    let emails = document.querySelectorAll('#customers td:nth-child(2)');
    let input = document.getElementsByName('email')[0];
    let result = document.getElementById('result');

    let arr = Array.from(emails);

    for (let i = 0; i < arr.length; i++) {
        if (arr[i].textContent === input.value) {
            emails[i].parentElement.remove();
            result.textContent = 'Deleted.'
            input.value = '';
            return;
        }
    }

    result.textContent = 'Not found.'
    input.value = '';
}