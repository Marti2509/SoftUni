function main(text1, text2, text3) {
    let text1Length = text1.length;
    let text2Length = text2.length;
    let text3Length = text3.length;

    let sumOfLength = text1Length + text2Length + text3Length
    let avLength = Math.floor(sumOfLength / 3);

    console.log(sumOfLength);
    console.log(avLength);
}
main('pasta', '5', '22.3');