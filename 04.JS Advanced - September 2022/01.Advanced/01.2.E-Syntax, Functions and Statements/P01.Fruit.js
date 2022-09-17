function main(fruit, grams, pricePerKg) {
    let kilos = grams / 1000;
    let price = kilos * pricePerKg;

    console.log(`I need $${price.toFixed(2)} to buy ${kilos.toFixed(2)} kilograms ${fruit}.`);
}
main('orange', 2500, 1.80);
main('apple', 1563, 2.35);