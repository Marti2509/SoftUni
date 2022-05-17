function main(input){
    let nylon = Number(input[0]) + 2;
    let paint = Number(input[1]) + Number(input[1]) * 0.1;
    let thinner = Number(input[2]);
    let hours = Number(input[3]);

    let priceNylon = nylon * 1.50;
    let pricePaint = paint * 14.50;
    let priceThinner = thinner * 5.00;

    let materialsPrice = priceNylon + pricePaint + priceThinner + 0.40;

    let builderPrice = (materialsPrice * 0.3) * hours;

    let endPrice = materialsPrice + builderPrice;

    console.log(endPrice)
}
main(["10 ",
"11 ",
"4 ",
"8 "]
);