function main(input){
    let hours = Number(input[0]);
    let minutes = Number(input[1]);

    minutes += 15;

    if (minutes >= 60) {
        hours++;
        minutes -= 60;
    }

    if (hours >= 24) {
        hours = 0;
    }

    console.log(`${hours}:${minutes.toString().padStart(2, 0)}`);
}
main(["1", "46"]);