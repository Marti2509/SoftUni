function main(input){
    let volume = Number(input[0]) * Number(input[1]) * Number(input[2]);
    let volumeLiters = volume / 1000;
    let neededLeters = volumeLiters * (1 - Number(input[3]) / 100);

    console.log(neededLeters);
}
main(["85 ",
"75 ",
"47 ",
"17 "]
);