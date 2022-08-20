function main(input){
    if (input[0] == "square") {
        console.log(Number(input[1]) * Number(input[1]));
    } else if (input[0] == "rectangle") {
        console.log(Number(input[1]) * Number(input[2]));
    } else if (input[0] == "circle") {
        console.log(Number(input[1]) * Number(input[1]) * Math.PI );
    } else {
        console.log(Number(input[1]) * Number(input[2]) / 2);
    }
}
main();