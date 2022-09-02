function main(input) {
    let n = Number(input.shift());
    let salary = Number(input.shift());
    
    let lost = 0;

    for (let i = 0; i < input.length; i++) {
        const site = input[i];
        
        if (site === "Facebook") {
            lost += 150;
        } else if (site === "Instagram") {
            lost += 100;
        } else if (site === "Reddit") {
            lost += 50;
        }
    }

    salary -= lost;

    if (salary <= 0) {
        console.log("You have lost your salary.");
    } else {
        console.log(salary);
    }
}
main(["10", "750", "Facebook", "Dev.bg", "Instagram", "Facebook", "Reddit", "Facebook", "Facebook"]);