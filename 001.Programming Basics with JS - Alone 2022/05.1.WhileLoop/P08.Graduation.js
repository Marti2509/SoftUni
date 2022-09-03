function main(input) {
    let name = input.shift();
    let avGrade = 0;
    let currClass = 1;
    let isBeenOff = false;

    while (true) {
        if (currClass === 13) {
            break;
        }

        let grade = Number(input.shift());

        if (grade >= 4.00) {
            currClass++;
            avGrade += grade;
            continue;
        } else {
            if (isBeenOff === true) {
                console.log(`${name} has been excluded at ${currClass} grade`);
                return;
            } else {
                isBeenOff = true
            }
        }
    }

    avGrade = avGrade / 12;

    console.log(`${name} graduated. Average grade: ${avGrade.toFixed(2)}`);
}
main(["Mimi", "5", "6", "5", "6", "5", "6", "6", "2", "3"]);