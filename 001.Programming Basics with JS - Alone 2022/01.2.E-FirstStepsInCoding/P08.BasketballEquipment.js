function main(input){
    let shoes = Number(input) * 0.6;
    let outfit =  shoes * 0.8;
    let ball = outfit / 4;
    let accessories = ball / 5;

    let endPrice = shoes + outfit + ball + accessories + Number(input)

    console.log(endPrice)
}
main(["365 "]);