function main(arg) {
    let type = typeof(arg);

    if (type != 'number') {
        console.log(`We can not calculate the circle area, because we receive a ${type}.`);
        return;
    }

    let result = arg * arg * Math.PI;
    console.log(result.toFixed(2));
}
main(5);
main('name');