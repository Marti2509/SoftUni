function main(input){
    let dogFood = Number(input[0]);
    let catFood = Number(input[1]);

    let dogPrice = dogFood * 2.50;
    let catPrice = catFood * 4;

    console.log(dogPrice + catPrice + " lv.");
}

main(["3", "5"]);