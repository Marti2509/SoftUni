function main(arr) {
    arr.sort((a, b) => a - b);

    let firstNum = arr[0];
    let secondNum = arr[1];

    console.log(firstNum + ' ' + secondNum);
}
main([30, 40, 100, 1, 19, 54, 17, 16]);