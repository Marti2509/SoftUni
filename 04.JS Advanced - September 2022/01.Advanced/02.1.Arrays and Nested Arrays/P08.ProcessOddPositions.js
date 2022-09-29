function main(arr) {
    let outputArr = [];

    for (let i = 0; i < arr.length; i++) {
        const item = arr[i];
        
        if (i % 2 === 1) {
            outputArr.push(item);
        }
    }
    
    console.log(outputArr.reverse().map((x) => x * 2).join(' '))
}
main([10, 15, 20, 25]);