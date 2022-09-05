function main(input) {
    let book = input.shift();
    let count = 0;

    while (true) {
        let currBook = input.shift();

        if (currBook === "No More Books") {
            console.log("The book you search is not here!");
            console.log(`You checked ${count} books.`);
            break;
        } else if (currBook === book) {
            console.log(`You checked ${count} books and found it.`);
            break;
        } else {
            count++;
        }
    }
}
main(["Troy", "Stronger", "Life Style", "Troy"]);