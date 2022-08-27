function main(input){
    let num1 = Number(input[0]);
    let num2 = Number(input[1]);
    let op = input[2];
    let sum = 0;
    switch (op) {
        case "+":
            sum = num1 + num2;
            if (sum % 2 === 0) {
                console.log(`${num1} ${op} ${num2} = ${sum} - even`);
            } else {
                console.log(`${num1} ${op} ${num2} = ${sum} - odd`);
            }
            break;
        case "-":
            sum = num1 - num2;
            if (sum % 2 === 0) {
                console.log(`${num1} ${op} ${num2} = ${sum} - even`);
            } else {
                console.log(`${num1} ${op} ${num2} = ${sum} - odd`);
            }
            break;
        case "*":
            sum = num1 * num2;
            if (sum % 2 === 0) {
                console.log(`${num1} ${op} ${num2} = ${sum} - even`);
            } else {
                console.log(`${num1} ${op} ${num2} = ${sum} - odd`);
            }
            break;
        case "/":
            if (num2 === 0) {
                console.log(`Cannot divide ${num1} by zero`);
            } else {
                sum = num1 / num2;

                console.log(`${num1} ${op} ${num2} = ${sum.toFixed(2)}`);
            }
            break;
        case "%":
            if (num2 === 0) {
                console.log(`Cannot divide ${num1} by zero`);
            } else {
                sum = num1 % num2;
                console.log(`${num1} ${op} ${num2} = ${sum}`);
            }
            break;
    }
}
main();