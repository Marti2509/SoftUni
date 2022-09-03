function main(input) {
    let username = input.shift();
    let password = input.shift();
    let currGuess = input.shift();

    while (currGuess !== password) {
        currGuess = input.shift();
    }

    console.log(`Welcome ${username}!`);
}
main(["marto", "nisuk", "kk", "nisuk"]);