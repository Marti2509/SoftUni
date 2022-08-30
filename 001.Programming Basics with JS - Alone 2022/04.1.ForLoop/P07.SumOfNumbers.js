function main(input) {
    let num = input[0];
    let sum = 0;

    for (let i = 0; i < num.length; i++) {
        let currNum = Number(num[i]);
        
        sum += currNum;
    }

    console.log(`The sum of the digits is:${sum}`);
}
main(["1234"]);