function main(input){
    let name = input[0];
    let numberOfProjects = Number(input[1]);

    let hours = numberOfProjects * 3;

    console.log(`The architect ${name} will need ${hours} hours to complete ${numberOfProjects} project/s.`);
}
main();