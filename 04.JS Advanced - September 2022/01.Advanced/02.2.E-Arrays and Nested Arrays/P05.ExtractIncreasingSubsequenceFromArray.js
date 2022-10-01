function main(array) {
    let outputArr = [array[0]];
    let biggestNum = array[0];

    for (let i = 1; i < array.length; i++) {
        const element = array[i];
        
        if (element >= biggestNum) {
            outputArr.push(element);
            biggestNum = element
        }
    }

    return outputArr;
}
console.log(main([1, 3, 8, 4, 10, 12, 3, 2, 24]));