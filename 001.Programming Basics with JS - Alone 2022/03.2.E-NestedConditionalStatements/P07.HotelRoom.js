function main(input){
    let month = input[0];
    let nights = Number(input[1]);
    let apartment = 0;
    let studio = 0;
    let total = 0;
    if (month === "May" || month === "October") {
        studio = nights * 50;
        apartment = nights * 65;
        if (nights > 14) {
          studio = studio * 0.7;
        } else if (nights > 7) {
          studio = studio * 0.95;
        }
    } else if (month === "June" || month === "September") {
        studio = nights * 75.2;
        apartment = nights * 68.7;
        if (nights > 14) {
            studio = studio * 0.8;
        }
    } else {
        studio = nights * 76;
        apartment = nights * 77;
    }
    if (nights > 14) {
    apartment = apartment * 0.9;
    }
    console.log(`Apartment: ${apartment.toFixed(2)} lv.`);
    console.log(`Studio: ${studio.toFixed(2)} lv.`);
}
main();