function main(input) {
    let badGrades = Number(input.shift());
    let badGradesCount = 0;
    let avGrade = 0;
    let count = 0;
    let name = "";

    while (true) {
        let name2 = input.shift();
        if (name2 === "Enough") {
            break;
        }
        name = name2;

        let grade = Number(input.shift());

        avGrade += grade;
        count++;

        if (grade <= 4) {
            badGradesCount++;

            if (badGradesCount === badGrades) {
                console.log(`You need a break, ${badGradesCount} poor grades.`);
                return;
            }
        }
    }

    avGrade = avGrade / count;

    console.log(`Average score: ${avGrade.toFixed(2)}`);
    console.log(`Number of problems: ${count}`);
    console.log(`Last problem: ${name}`);
}
main(["3", "Money", "6", "Story", "4", "Spring Time", "5", "Bus", "6", "Enough"]);