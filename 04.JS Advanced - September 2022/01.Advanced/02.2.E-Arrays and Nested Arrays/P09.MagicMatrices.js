function main(matrix) {
    let sumRow1 = 0;

    for (let i = 0; i < matrix[0].length; i++) {
        sumRow1 += matrix[0][i];
    }

    for (let i = 1; i < matrix.length; i++) {
        let sumCurrRow = 0;

        for (let j = 0; j < matrix[i].length; j++) {
            sumCurrRow += matrix[i][j];
        }

        if (sumRow1 !== sumCurrRow) {
            return false;
        }
    }

    for (let i = 0; i < matrix.length; i++) {
        let sumCurrCol = 0;

        for (let j = 0; j < matrix.length; j++) {
            sumCurrCol += matrix[j][i];
        }

        if (sumRow1 !== sumCurrCol) {
            return false;
        }
    }

    return true;
}
main([[4, 5, 6], [6, 5, 4], [5, 5, 5]]);
main([[11, 32, 45], [21, 0, 1], [21, 1, 1]]);