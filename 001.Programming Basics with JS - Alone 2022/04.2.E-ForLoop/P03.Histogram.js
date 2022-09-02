function main(input) {
    const count = input.shift();
    let p1 = 0;
    let p2 = 0;
    let p3 = 0;
    let p4 = 0;
    let p5 = 0;

    for (let i = 0; i < input.length; i++) {
        const element = input[i];
        
        if (element < 200) {
            p1++;
        } else if (element < 400) {
            p2++;
        } else if (element < 600) {
            p3++;
        } else if (element < 800) {
            p4++;
        } else {
            p5++;
        }
    }

    console.log(`${((p1 / count) * 100).toFixed(2)}%`);
    console.log(`${((p2 / count) * 100).toFixed(2)}%`);
    console.log(`${((p3 / count) * 100).toFixed(2)}%`);
    console.log(`${((p4 / count) * 100).toFixed(2)}%`);
    console.log(`${((p5 / count) * 100).toFixed(2)}%`);
}
main(["3", "1", "2", "999"]);