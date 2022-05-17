function main(input){
    let pensPackage = Number(input[0]);
    let markersPackage = Number(input[1]);
    let liters = Number(input[2]);
    let discount = Number(input[3]);

    let pensPrice = pensPackage * 5.80;
    let markersPrice = markersPackage * 7.20;
    let litersPrice = liters * 1.20;

    let price = (pensPrice + markersPrice + litersPrice) - (pensPrice + markersPrice + litersPrice) * (discount / 100);

    console.log(price);
}
main(["2 ",
"3 ",
"4 ",
"25 "]
);