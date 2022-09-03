function main(input) {
    let num = input.shift();
    let sum = 0;

    while (true) {
        let currNum = Number(input.shift());
        sum += currNum;

        if (sum >= num) {
            console.log(sum);
            break;
        }
    }
}
main(["100", "20", "30", "40", "50"]);