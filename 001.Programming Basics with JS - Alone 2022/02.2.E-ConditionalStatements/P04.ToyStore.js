function main(input){
    const puzzle = 2.60;
    const doll = 3.00;
    const bear = 4.10;
    const minion = 8.20;
    const truck = 2.00;

    let priceForTrip = Number(input[0]);
    let puzzlesCount = Number(input[1]);
    let dollsCount = Number(input[2]);
    let bearsCount = Number(input[3]);
    let minionsCount = Number(input[4]);
    let trucksCount = Number(input[5]);

    let puzzlesPrice = puzzle * puzzlesCount;
    let dollsPrice = doll * dollsCount;
    let bearsPrice = bear * bearsCount;
    let minionsPrice = minion * minionsCount;
    let trucksPrice = truck * trucksCount;

    let endPrice = puzzlesPrice + dollsPrice + bearsPrice + minionsPrice + trucksPrice;

    let withoutRent = endPrice - (endPrice * 0.1);

    if (priceForTrip >= withoutRent) {
        console.log(`Yes! ${(priceForTrip - withoutRent).toString().padStart(2, 0)} lv left.`);
    } else {
        console.log(`Not enough money! ${(withoutRent - priceForTrip).toString().padStart(2, 0)} lv needed`);
    }
}
main(["40.8",
"20",
"25",
"30",
"50",
"10"])
;