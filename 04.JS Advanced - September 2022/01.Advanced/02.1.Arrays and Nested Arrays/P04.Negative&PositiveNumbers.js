function main(arr) {
    let outputArr = [];

    for (const item of arr) {
        if (item >= 0) {
            outputArr.push(item);
        } else {
            outputArr.splice(0, 0, item);
        }
    }

    console.log(outputArr.join('\n'));
}
main([7, -2, 8, 9]);