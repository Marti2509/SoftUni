function main(input){
    let product = input[0];
    let city = input[1];
    let quantity = Number(input[2]);

    let price;

    if (product === "coffee") {
        if (city === "Sofia") {
            price = 0.50 * quantity;
        } else if (city === "Plovdiv") {
            price = 0.40 * quantity;
        } else if (city === "Varna") {
            price = 0.45 * quantity;
        }
    } else if (product === "water") {
        if (city === "Sofia") {
            price = 0.80 * quantity;
        } else if (city === "Plovdiv") {
            price = 0.70 * quantity;
        } else if (city === "Varna") {
            price = 0.70 * quantity;
        }
    } else if (product === "beer") {
        if (city === "Sofia") {
            price = 1.20 * quantity;
        } else if (city === "Plovdiv") {
            price = 1.15 * quantity;
        } else if (city === "Varna") {
            price = 1.10 * quantity;
        }
    } else if (product === "sweets") {
        if (city === "Sofia") {
            price = 1.45 * quantity;
        } else if (city === "Plovdiv") {
            price = 1.30 * quantity;
        } else if (city === "Varna") {
            price = 1.35 * quantity;
        }
    } else if (product === "peanuts") {
        if (city === "Sofia") {
            price = 1.60 * quantity;
        } else if (city === "Plovdiv") {
            price = 1.50 * quantity;
        } else if (city === "Varna") {
            price = 1.55 * quantity;
        }
    }

    console.log(price);
}
main();