function add(a) {

    let sum = 0;

    function inner(b) {

        sum += b;
        return inner;
    }

    inner.toString = () => sum;
    return inner(a);
}

console.log(add(1).toString());
console.log(add(1)(6)(-3).toString());