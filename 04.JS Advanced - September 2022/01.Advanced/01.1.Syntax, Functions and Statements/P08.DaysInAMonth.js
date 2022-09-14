function main(month, year) {
    let days = new Date(year, month, 0).getDate();

    console.log(days);
}
main(1, 2012);
main(2, 2021);  