function main(input) {
    let maxNum = Number(input.shift());
    let text = input.shift();

    while (text !== "Stop") {
        let currNum = Number(text);

        if (currNum > maxNum) {
            maxNum = currNum;
        }

        text = input.shift();
    }

    console.log(maxNum);
}
main(["-1", "2", "Stop"]);