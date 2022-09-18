function main(num) {
    let numbersText = '' + num;
    let sum = 0;
    let bool = true;

    let firstChar = numbersText[0];
    sum += Number(numbersText[0]);

    for (let i = 1; i < numbersText.length; i++) {
        const currChar = numbersText[i];
        
        sum += Number(currChar);

        if (currChar != firstChar) {
            bool = false;
        }
    }

    console.log(bool);
    console.log(sum);
}
main(1234);