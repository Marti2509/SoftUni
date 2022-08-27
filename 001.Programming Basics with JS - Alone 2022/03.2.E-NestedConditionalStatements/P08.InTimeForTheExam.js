function main(input){
    let hExam = Number(input[0]);
    let mExam = Number(input[1]);
    let hArrive = Number(input[2]);
    let mArrive = Number(input[3]);
  
    let timeExam = hExam * 60 + mExam;
    let timeArrive = hArrive * 60 + mArrive;
    let diff = Math.abs(timeArrive - timeExam);
    let h = Math.floor(diff / 60);
    let m = diff % 60;
  
    if (timeArrive > timeExam) {
      console.log("Late");
      if (h > 0) {
        if (m < 10) {
          console.log(`${h}:0${m} hours after the start`);
        } else {
          console.log(`${h}:${m} hours after the start`);
        }
      } else {
        console.log(`${m} minutes after the start`);
      }
    } else if (timeArrive >= timeExam - 30 && timeArrive != timeExam) {
      console.log("On time");
      console.log(`${m} minutes before the start`);
    } else if (timeArrive < timeExam - 30) {
      console.log("Early");
      if (h > 0) {
        if (m < 10) {
          console.log(`${h}:0${m} hours before the start`);
        } else {
          console.log(`${h}:${m} hours before the start`);
        }
      } else {
        console.log(`${m} minutes before the start`);
      }
    } else {
      console.log("On time");
    }
}
main();