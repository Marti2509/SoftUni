function main(arr) {
    let outputArr = [];

    for (let i = 0; i < arr.length; i++) {
        const item = arr[i];
        
        if (i % 2 === 0) {
            outputArr.push(item);
        }
    }

    console.log(outputArr.join(' '));
}
main(['20', '30', '40', '50', '60']);