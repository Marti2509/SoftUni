function main(input){
    let nights = Number(input[0]) - 1;
    let roomType = input[1];
    let review = input[2];
    let cost = 0;

    switch (roomType) {
        case "room for one person":
            cost = nights * 18;
            break;
        case "apartment":
            cost = nights * 25;
            if (nights > 15) {
                cost = cost * 0.5;
            } else if (nights >= 10) {
                cost = cost * 0.65;
            } else {
                cost = cost * 0.7;
            }
            break;
        case "president apartment":
            cost = nights * 35;
            if (nights > 15) {
                cost = cost * 0.8;
            } else if (nights >= 10) {
                cost = cost * 0.85;
            } else {
                cost = cost * 0.9;
            }
    }

    if (review === "positive") {
        cost = cost * 1.25;
    } else {
        cost = cost * 0.9;
    }

    console.log(`${cost.toFixed(2)}`);
}
main(["5", "apartment", "positive"]);