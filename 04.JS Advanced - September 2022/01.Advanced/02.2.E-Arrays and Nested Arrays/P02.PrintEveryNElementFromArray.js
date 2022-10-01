function main(array, number) {
    let outputArr = [];
    
    for (let i = 0; i < array.length; i += number) {
        outputArr.push(array[i]);
    }

    return outputArr;
}
console.log(main(['5', '20', '31', '4', '20'], 2));