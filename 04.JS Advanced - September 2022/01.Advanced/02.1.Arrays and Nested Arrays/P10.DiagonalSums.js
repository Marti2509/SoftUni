function main(array) {
    let mainSum = 0;
    let secondSum = 0;

    for (let i = 0; i < array.length; i++) {
        mainSum += array[i][i];
    }

    let counter = 0;

    for (let j = array.length - 1; j >= 0; j--) {
        secondSum += array[j][counter];
        counter++;
    }

    console.log(mainSum + ' ' + secondSum);
}
main([[1, 2], [2, 1]]); // 2 4
main([[1, 2, 3], [2, 1, 3], [3, 2, 1]]); // 3 7