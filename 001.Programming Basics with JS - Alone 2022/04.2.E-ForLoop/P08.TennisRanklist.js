function main(input) {
    index = 0;
    let tournamentsAll = Number(input[index]);
    index++;
    let startingPonts = Number(input[index]);
    index++;
    let currentPoints = 0;
    let winCounter = 0;
  
    for (let i = 0; i < tournamentsAll; i++) {
      let resultTournament = input[index];
      index++;
  
      switch (resultTournament) {
        case "W": winCounter++;
          currentPoints += 2000; break;
        case "F": currentPoints += 1200; break;
        case "SF": currentPoints += 720; break;
      }
  
    }
  
    let finalSumPoints = startingPonts + currentPoints;
    let averagePoints = currentPoints / tournamentsAll;
  
    let percentWin = winCounter / tournamentsAll * 100;
  
    console.log(`Final points: ${Math.floor(finalSumPoints)}`);
    console.log(`Average points: ${Math.floor(averagePoints)}`);
    console.log(`${percentWin.toFixed(2)}%`);
}
main(["5", "1400", "F", "SF", "W", "W", "SF"]);