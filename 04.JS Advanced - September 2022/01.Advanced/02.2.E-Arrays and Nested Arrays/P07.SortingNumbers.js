function main(numbers) {
    let outputNumbers = [];
    let count = numbers.length;

    numbers.sort((a, b) => a - b);

    for (let i = 1; i <= count; i++) {
        if (i % 2 === 1) {
            let currElement = numbers.shift();
            outputNumbers.push(currElement);
        } else {
            let currElement = numbers.pop();
            outputNumbers.push(currElement);
        }
    }

    return outputNumbers;
}
main([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);