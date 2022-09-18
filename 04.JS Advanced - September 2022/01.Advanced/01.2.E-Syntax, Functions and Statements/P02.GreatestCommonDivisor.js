function main(num1, num2) {
    let bigger = Math.max(num1, num2);

    for (let i = bigger; i >= 1; i--) {
        if (num1 % i == 0 && num2 % i == 0) {
            console.log(i);
            break;
        }
    }
}
main(15, 5);
main(2154, 458);