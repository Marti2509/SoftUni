function main(array, startIndex, endIndex) {
    if (!Array.isArray(array)) {
        return NaN;
    }

    if (startIndex < 0) {
        startIndex = 0;
    }

    if (endIndex < 0 || endIndex > array.length - 1) {
        endIndex = array.length - 1;
    }

    let sum = 0;

    for (let i = startIndex; i <= endIndex; i++) {
        const element = Number(array[i]);
        
        sum += element;
    }

    return sum;
}
console.log(main('not arr', 1, 3));
console.log(main([1, 2, 3], 1, 3));
console.log(main([1, 2, 3], -1, 2));
console.log(main([1, 2, 3], 1, 2));