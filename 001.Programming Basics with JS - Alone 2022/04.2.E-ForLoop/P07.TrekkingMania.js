function main(input) {
    let index = 0;
    let groupsInTtl = Number(input[index]);
    index++;
    let sum = 0;
    let counter5 = 0;
    let counter12 = 0;
    let counter25 = 0;
    let counter40 = 0;
    let counterMore = 0;
  
    for (let i = 0; i < groupsInTtl; i++) {
      let pplInGroup = Number(input[index]);
      index++;
      sum += pplInGroup;
  
  
      if (pplInGroup <= 5) {
        counter5 += pplInGroup;
      }
      else if (pplInGroup >= 6 && pplInGroup <= 12) {
        counter12 += pplInGroup;
      }
      else if (pplInGroup >= 13 && pplInGroup <= 25) {
        counter25 += pplInGroup;
      }
      else if (pplInGroup >= 26 && pplInGroup <= 40) {
        counter40 += pplInGroup;
      }
      else if (pplInGroup >= 41) {
        counterMore += pplInGroup;
      }
    }
  
    console.log(`${(counter5 / sum * 100).toFixed(2)}%`);
    console.log(`${(counter12 / sum * 100).toFixed(2)}%`);
    console.log(`${(counter25 / sum * 100).toFixed(2)}%`);
    console.log(`${(counter40 / sum * 100).toFixed(2)}%`);
    console.log(`${(counterMore / sum * 100).toFixed(2)}%`);
}
main(["5", "25", "41", "31", "250", "6"]);