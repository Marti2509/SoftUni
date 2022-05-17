function main(input){
    let chikenMenuPrice = Number(input[0]) * 10.35;
    let fishMenuPrice = Number(input[1]) * 12.40;
    let veganMenuPrice = Number(input[2]) * 8.15;

    let price = chikenMenuPrice + fishMenuPrice + veganMenuPrice;
    let desertPrice = price * 0.2;
    let endPrice = price + desertPrice + 2.50;

    console.log(endPrice);
}
main(["2 ",
"4 ",
"3 "]
);