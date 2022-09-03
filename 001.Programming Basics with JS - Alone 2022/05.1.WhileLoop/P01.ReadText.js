function main(input) {
    let index = 0;
    let text = input[index];
    index++;
    
    while (text !== "Stop") {
        console.log(text);

        text = input[index];
        index++;
    }
}
main(["marto", "simov", "emi", "Stop", "misho"]);