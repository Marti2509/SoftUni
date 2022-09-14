function main(num1, num2, operator) {
    let result;

    if (operator === '+') {
        result = num1 + num2;
    } else if (operator === '-') {
        result = num1 - num2;
    } else if (operator === '*') {
        result = num1 * num2;
    } else if (operator === '/') {
        result = num1 / num2;
    } else if (operator === '%') {
        result = num1 % num2;
    } else if (operator === '**') {
        result = num1 ** num2;
    } 

    console.log(result);
}
main(2, 2, '+'); // 4
main(2, 2, '-'); // 0
main(2, 2, '*'); // 4
main(2, 2, '/'); // 1
main(2, 2, '%'); // 0
main(2, 2, '**'); // 4