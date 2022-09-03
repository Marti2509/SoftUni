function main(input) {
    let minNum = Number(input.shift());
    let text = input.shift();

    while (text !== "Stop") {
        let currNum = Number(text);

        if (currNum < minNum) {
            minNum = currNum;
        }

        text = input.shift();
    }

    console.log(minNum);
}
main(["-1", "2", "Stop"]);