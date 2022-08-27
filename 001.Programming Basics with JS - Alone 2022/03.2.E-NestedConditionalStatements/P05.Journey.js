function main(input){
    let budget = Number(input[0]);
    let season = input[1];
    let cost;
    let location;
    let accommodation;
    if (budget <= 100) {
        location = "Bulgaria";
        if ((season === "summer")) {
            cost = budget * 0.3;
            accommodation = "Camp";
        } else {
            cost = budget * 0.7;
            accommodation = "Hotel";
        }
    } else if (budget <= 1000) {
        location = "Balkans";
        if ((season === "summer")) {
            accommodation = "Camp";
            cost = budget * 0.4;
        } else {
            accommodation = "Hotel";
            cost = budget * 0.8;
        }
    } else {
        location = "Europe";
        cost = budget * 0.9;
        accommodation = "Hotel";
    }

    console.log(`Somewhere in ${location}`);
    console.log(`${accommodation} - ${cost.toFixed(2)}`);
}
main();