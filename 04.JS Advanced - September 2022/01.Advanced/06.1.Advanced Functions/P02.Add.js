function solution(counter) {
    return (num) => counter + num;
}

let add5 = solution(5);
console.log(add5(2));
console.log(add5(3));