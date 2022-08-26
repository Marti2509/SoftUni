function main(input){
    let town = input[0];
    let sales = Number(input[1]);
    let commission = 0;

    if (town === "Sofia" && sales > 0) {
      if (sales <= 500 && commission >= 0) {
        commission = sales * 0.05;
      } else if (sales <= 1000) {
        commission = sales * 0.07;
      } else if (sales <= 10000) {
        commission = sales * 0.08;
      } else if (sales > 10000) {
        commission = sales * 0.12;
      }
      console.log(commission.toFixed(2));
    } else if (town === "Varna" && sales > 0) {
      if (sales <= 500 && commission >= 0) {
        commission = sales * 0.045;
      } else if (sales <= 1000) {
        commission = sales * 0.075;
      } else if (sales <= 10000) {
        commission = sales * 0.1;
      } else if (sales > 10000) {
        commission = sales * 0.13;
      }
      console.log(commission.toFixed(2));
    } else if ((town === "Plovdiv") & (sales > 0)) {
      if (sales <= 500 && commission >= 0) {
        commission = sales * 0.055;
      } else if (sales <= 1000) {
        commission = sales * 0.08;
      } else if (sales <= 10000) {
        commission = sales * 0.12;
      } else if (sales > 10000) {
        commission = sales * 0.145;
      }
      console.log(commission.toFixed(2));
    } else {
      console.log("error");
    }
}
main();