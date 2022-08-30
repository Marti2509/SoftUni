function main(input) {
    let startNum = Number(input[0]);
    let endNum = Number(input[1]);

    let sum = 0;
    let text = "";

    for (let i = startNum; i <= endNum; i++) {
        if (i % 9 === 0) {
            sum += i;
            text += i + `\n`;
        }
    }

    console.log("The sum: " + sum);
    console.log(text);
}
main(["100", "200"]);