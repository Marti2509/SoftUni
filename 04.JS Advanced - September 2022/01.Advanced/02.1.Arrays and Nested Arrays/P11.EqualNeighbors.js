function main(matrix) {
    let matches = 0;

    for (let i = 0; i < matrix.length; i++) {
        let currArr = matrix[i];

        for (let j = 0; j < currArr.length; j++) {
            let currStr = currArr[j];

            if (i === matrix.length - 1) {
                if (matrix[i][j + 1] === currStr) {
                    matches++;
                }
            } else if (matrix[i + 1][j] === currStr || matrix[i][j + 1] === currStr) {
                if (matrix[i + 1][j] === currStr && matrix[i][j + 1] === currStr) {
                    matches += 2;
                } else {
                    matches++;
                }
            }
        }
    }

    return matches;
}
main([['test', 'yes', 'yo', 'ho'],
      ['well', 'done', 'yo', '6'],
      ['not', 'done', 'yet', '5']]);
main([['2', '3', '4', '7', '0'],
      ['4', '0', '5', '3', '4'],
      ['2', '3', '5', '4', '2'],
      ['9', '8', '7', '5', '4']]);