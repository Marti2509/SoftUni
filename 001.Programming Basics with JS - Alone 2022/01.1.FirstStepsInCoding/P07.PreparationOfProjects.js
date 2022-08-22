function main(input){
    let name = input[0];
    let numOfProjects = Number(input[1]);

    let hours = numOfProjects * 3;

    console.log(`The architect ${name} will need ${hours} hours to complete ${numOfProjects} project/s.`);
}

main(["marto", 15]);