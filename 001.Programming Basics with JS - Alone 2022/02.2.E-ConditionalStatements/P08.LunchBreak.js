function main(input){
    let name = input[0];
    let episodeTime = Number(input[1]);
    let fullBreakTime = Number(input[2]);

    let eatingTime = fullBreakTime / 8;
    let breakTime = fullBreakTime / 4;

    let breakTimeLeft = fullBreakTime - (eatingTime + breakTime);

    if (breakTimeLeft >= episodeTime) {
        console.log(`You have enough time to watch ${name} and left with ${Math.ceil(breakTimeLeft - episodeTime)} minutes free time.`);
    } else {
        console.log(`You don't have enough time to watch ${name}, you need ${Math.ceil(episodeTime - breakTimeLeft)} more minutes.`);
    }
}

main(["Game of Thrones", 60, 96]);