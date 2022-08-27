function main(input){
    // Roses Dahlias  Tulips Narcissus	Gladiolus
    //  5	 3.80	  2.80	     3	         2.50

    let typeOfFlower = input[0];
    let quantity = Number(input[1]);
    let budget = Number(input[2]);

    let price;

    if (typeOfFlower === "Roses") {
        if (quantity > 80) {
            price = (quantity * 5) - (quantity * 5) * 0.10;
        } else {
            price = quantity * 5; 
        }
    } else if (typeOfFlower === "Dahlias") {
        if (quantity > 90) {
            price = (quantity * 3.80) - (quantity * 3.80) * 0.15;
        } else {
            price = quantity * 3.80; 
        }
    } else if (typeOfFlower === "Tulips") {
        if (quantity > 80) {
            price = (quantity * 2.80) - (quantity * 2.80) * 0.15;
        } else {
            price = quantity * 2.80; 
        }
    } else if (typeOfFlower === "Narcissus") {
        if (quantity < 120) {
            price = (quantity * 3) + (quantity * 3) * 0.15;
        } else {
            price = quantity * 3; 
        }
    } else if (typeOfFlower === "Gladiolus") {
        if (quantity < 80) {
            price = (quantity * 2.50) + (quantity * 2.50) * 0.20;
        } else {
            price = quantity * 2.50; 
        }
    }

    if (budget >= price) {
        console.log(`Hey, you have a great garden with ${quantity} ${typeOfFlower} and ${(budget - price).toFixed(2)} leva left.`);
    } else {
        console.log(`Not enough money, you need ${(price - budget).toFixed(2)} leva more.`);
    }
}
main();