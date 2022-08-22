function main(input){
    let first = Number(input[0]);
    let second = Number(input[1]);
    let third = Number(input[2]);

    let sum = first + second + third;
    let mins = Math.floor(sum / 60);
    let secs = sum - mins * 60;
    
    if (sum < 60) {
        console.log(`0:${sum.toString().padStart(2, 0)}`);
    } else {
        console.log(`${mins}:${secs.toString().padStart(2, 0)}`);
    }
}
main(["50", "50", "50"]);