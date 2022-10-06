function main(worker) {
    if (worker['dizziness'] === true) {
        let result = (worker['weight'] * worker['experience']) * 0.1;
        worker['levelOfHydrated'] += result;
    } 

    return worker;
}
console.log(main({ weight: 80, experience: 1, levelOfHydrated: 0, dizziness: true }));
console.log(main({ weight: 120, experience: 20, levelOfHydrated: 200, dizziness: true }));
console.log(main({ weight: 95, experience: 3, levelOfHydrated: 0, dizziness: false }));