function main(array, times) {
    for (let i = 0; i < times; i++) {
        let element = array.pop();
        array.unshift(element);
    }

    console.log(array.join(' '));
}
main(['1', '2', '3', '4'], 2);