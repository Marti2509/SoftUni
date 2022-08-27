function main(input){
    let budget = Number(input[0]);
    let season = input[1];
    let people = Number(input[2]);

    let price;

    if (season === "Spring") {
        price = 3000;
    } else if (season === "Summer") {
        price = 4200;
    } else if (season === "Autumn") {
        price = 4200;
    } else if (season === "Winter") {
        price = 2600;
    }

    if (people <= 6) {
        price = price - price * 0.10;
    } else if (people >= 7 && people <= 11) {
        price = price - price * 0.15;
    } else if (people >= 12) {
        price = price - price * 0.25;
    }

    if (people % 2 == 0 && season !== "Autumn") {
        price = price - price * 0.05;
    }

    if (budget >= price) {
        console.log(`Yes! You have ${(budget - price).toFixed(2)} leva left.`);
    } else {
        console.log(`Not enough money! You need ${(price - budget).toFixed(2)} leva.`);
    }
}
main();