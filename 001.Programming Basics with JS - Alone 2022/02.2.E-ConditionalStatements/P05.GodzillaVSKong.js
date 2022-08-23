function main(input){
    let budget = Number(input[0]);
    let statists = Number(input[1]);
    let priceForClothingForOne = Number(input[2]);

    let decorPrice = budget * 0.10;
    let clothingPrice;

    if (statists > 150) {
        clothingPrice = (statists * priceForClothingForOne) - (statists * priceForClothingForOne) * 0.10;
    } else {
        clothingPrice = statists * priceForClothingForOne;
    }

    let endPrice = decorPrice + clothingPrice;

    if (endPrice <= budget) {
        console.log("Action!");
        console.log(`Wingard starts filming with ${(budget - endPrice).toFixed(2)} leva left.`);
    } else {
        console.log("Not enough money!");
        console.log(`Wingard needs ${(endPrice - budget).toFixed(2)} leva more.`);
    }
}

main((["9587.88", "222", "55.68"]));