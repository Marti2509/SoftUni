function main(input) {
    let age = Number(input[0]);
    let neededPrice = Number(input[1]);
    let priceForDoll = Number(input[2]);

    let savings = 0;
    let lastSave = 10;
    let dollCount = 0;

    for (let i = 1; i <= age; i++) {
        if (i % 2 === 1) {
            dollCount++;
        } else {
            savings += lastSave - 1;
            lastSave += 10;
        }
    }

    let dollPrice = dollCount * priceForDoll;
    savings += dollPrice;

    if (savings >= neededPrice) {
        console.log(`Yes! ${(savings - neededPrice).toFixed(2)}`);
    } else {
        console.log(`No! ${(neededPrice - savings).toFixed(2)}`);
    }
}
main(["10", "170.00", "6"]);