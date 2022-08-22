function main(input){
    let numberPages = Number(input[0]);
    let pagesForHour = Number(input[1]);
    let days = Number(input[2]);

    let hoursForBook = numberPages / pagesForHour;
    let hoursForDay = hoursForBook / days;

    console.log(hoursForDay);
}
main(["212 ",
"20 ",
"2 "]
);