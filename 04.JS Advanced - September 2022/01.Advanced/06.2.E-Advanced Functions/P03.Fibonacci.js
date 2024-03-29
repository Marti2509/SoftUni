function solve() {

    let a = 0;
    let b = 1;

    return function () {
        let c = a + b;
        a = b;
        b = c;
        return a;
    }
}

let fib = solve();
console.log(fib()); // 1
console.log(fib()); // 1
console.log(fib()); // 2
console.log(fib()); // 3
console.log(fib()); // 5
console.log(fib()); // 8
console.log(fib()); // 13