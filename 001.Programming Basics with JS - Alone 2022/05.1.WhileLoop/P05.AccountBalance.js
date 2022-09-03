function main(input) {
    let balance = 0;

    while (true) {
        let text = input.shift();

        if (text === "NoMoreMoney") {
            break;
        } else {
            let currMoney = Number(text);

            if (currMoney < 0) {
                console.log("Invalid operation!");
                break;
            } else {
                balance += currMoney;

                console.log(`Increase: ${currMoney.toFixed(2)}`);
            }
        }
    }

    console.log(`Total: ${balance.toFixed(2)}`);
}
main(["12", "-2"]);