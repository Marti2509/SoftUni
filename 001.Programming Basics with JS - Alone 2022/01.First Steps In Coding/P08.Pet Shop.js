function main(input){
    let numberOfPackegesDogs = Number(input[0]);
    let numberOfPackegesCats = Number(input[1]);

    let priceForDogs = numberOfPackegesDogs * 2.50;
    let priceForCats = numberOfPackegesCats * 4;

    let sum = priceForCats + priceForDogs;

    console.log(`${sum} lv.`);
}
main();