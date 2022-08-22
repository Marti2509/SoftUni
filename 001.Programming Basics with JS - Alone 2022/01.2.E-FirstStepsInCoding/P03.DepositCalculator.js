function main(input){
    let deposiranaSuma = Number(input[0]);
    let srok = Number(input[1]);
    let lihva = Number(input[2]);

    let suma = deposiranaSuma + srok * ((deposiranaSuma * (lihva / 100))/12);

    console.log(suma);
}
main(["200 ",
"3 ",
"5.7 "]
);