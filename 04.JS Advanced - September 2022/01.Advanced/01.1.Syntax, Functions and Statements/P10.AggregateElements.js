function main(elements) {
    let sum = 0;
    let secondSum = 0;
    let text = `${elements[0]}`;

    for (let index = 0; index < elements.length; index++) {
        sum += elements[index];
    }

    for (let index = 0; index < elements.length; index++) {
        secondSum += 1 / elements[index];
    }
    
    for (let index = 1; index < elements.length; index++) {
        text += `${elements[index]}`;
    }
    
    console.log(sum);
    console.log(secondSum);
    console.log(text);
}
main([1, 2, 3]);