function main(input){
    let currRecord = Number(input[0]);
    let meters = Number(input[1]);
    let secsForOneMeter = Number(input[2]);

    let late = Math.floor(meters / 15);
    let lateTime = late * 12.5;
    let ivansTime = (meters * secsForOneMeter) + lateTime;
    
    if (ivansTime >= currRecord) {
        console.log(`No, he failed! He was ${(ivansTime - currRecord).toFixed(2)} seconds slower.`);
    } else {
        console.log(`Yes, he succeeded! The new world record is ${(ivansTime).toFixed(2)} seconds.`);
    }
}

main([10464, 1500, 20]);