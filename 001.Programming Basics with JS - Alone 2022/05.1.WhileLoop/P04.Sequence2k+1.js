function main(input) {
    let num = Number(input.shift());
    let currNum = 1;
    while (currNum <= num) {
        console.log(currNum);

        currNum = currNum * 2 + 1;
    }
}
main(["8"]);