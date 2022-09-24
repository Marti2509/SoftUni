function main(numberInText, op1, op2, op3, op4, op5) {
    let number = Number(numberInText);

    number = operate(number, op1);
    console.log(number);
    
    number = operate(number, op2);
    console.log(number);

    number = operate(number, op3);
    console.log(number);

    number = operate(number, op4);
    console.log(number);

    number = operate(number, op5);
    console.log(number);

    function operate(num, op) {
        if (op === 'dice') {
            num = Math.sqrt(num);
        } else if (op === 'spice') {
            num++;
        } else if (op === 'chop') {
            num /= 2;
        } else if (op === 'bake') {
            num *= 3;
        } else if (op === 'fillet') {
            num -= num * 0.20;
        } 

        return num;
    }
}
main('32', 'chop', 'chop', 'chop', 'chop', 'chop',); // working
main('9', 'dice', 'spice', 'chop', 'bake', 'fillet'); // working