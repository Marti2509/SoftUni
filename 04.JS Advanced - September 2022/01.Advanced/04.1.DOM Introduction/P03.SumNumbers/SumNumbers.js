function calc() {
    let num1 = document.getElementById('num1');
    let num2 = document.getElementById('num2');
    let box = document.getElementById('sum');

    let sum = Number(num1.value) + Number(num2.value);

    box.value = sum;
}
