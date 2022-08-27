function main(input){
    let type = input[0];
    let rows = Number(input[1]);
    let colloms = Number(input[2]);

    let income = 0;

    if (type === "Premiere") {
        income = (rows * colloms) * 12;
    } else if (type === "Normal") {
        income = (rows * colloms) * 7.50;
    } else if (type === "Discount") {
        income = (rows * colloms) * 5.00;
    }

    console.log(`${income.toFixed(2)} leva`);
}
main();