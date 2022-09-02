function main(input) {
    let index = 0;
    let nameActor = input[index];
    index++;
    let pointsAcademy = Number(input[index]);
    index++;
    let n = Number(input[index]);
    index++;
  
    for (let i = 0; i < n; i++) {
      let currentName = input[index];
      index++;
      let currentPoints = Number(input[index]);
      index++;
  
      let totalPoints = currentName.length * currentPoints / 2;
      pointsAcademy += totalPoints;
  
      if (pointsAcademy > 1250.5) {
        console.log(`Congratulations, ${nameActor} got a nominee for leading role with ${pointsAcademy.toFixed(1)}!`);
        return;
      }
  
    }

    console.log(`Sorry, ${nameActor} you need ${(1250.5 - pointsAcademy).toFixed(1)} more!`);
}
main(["Zahari Baharov", "205", "4", "Johnny Depp", "45", "Will Smith", "29", "Jet Lee", "10", "Matthew Mcconaughey", "39"]);