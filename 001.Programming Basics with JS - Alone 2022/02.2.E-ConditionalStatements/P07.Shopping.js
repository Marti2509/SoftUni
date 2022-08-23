function main(input){
    let budget = Number(input[0]);
    let videoCards = Number(input[1]);
    let CPUs = Number(input[2]);
    let RamCards = Number(input[3]);

    const videoCardPriceConst = 250;
    
    let videoCardsPrice = videoCards * videoCardPriceConst;
    let CPUsPrice = CPUs * (videoCardsPrice * 0.35);
    let RamCardsPrice = RamCards * (videoCardsPrice * 0.10);

    let endPrice;

    if (videoCards > CPUs) {
        endPrice = (videoCardsPrice + CPUsPrice + RamCardsPrice) - (videoCardsPrice + CPUsPrice + RamCardsPrice) * 0.15;
    } else {
        endPrice = videoCardsPrice + CPUsPrice + RamCardsPrice;
    }

    if (endPrice <= budget) {
        console.log(`You have ${(budget - endPrice).toFixed(2)} leva left!`);
    } else {
        console.log(`Not enough money! You need ${(endPrice - budget).toFixed(2)} leva more!`);
    }
}

main([900, 2, 1, 3]);