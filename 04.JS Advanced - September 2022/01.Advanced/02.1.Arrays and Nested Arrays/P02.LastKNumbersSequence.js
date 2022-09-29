function main(n, k) {
    let arr = [1];

    for (let i = 1; i < n; i++) {
        let currSum = 0;
        let counter = k;
        
        for (let j = i - 1; counter > 0; j--) {
            if (j < 0) {
                break;
            }

            currSum += arr[j];
            counter--;
        }

        arr.push(currSum);
    }

    return arr;
}
main(6, 3);