function main(speed, area) {
    if (area === 'city') {
        if (speed <= 50) {
            console.log(`Driving ${speed} km/h in a 50 zone`);
        } else if (speed <= 70) {
            console.log(`The speed is ${speed - 50} km/h faster than the allowed speed of 50 - speeding`);
        } else if (speed <= 90) {
            console.log(`The speed is ${speed - 50} km/h faster than the allowed speed of 50 - excessive speeding`);
        } else {
            console.log(`The speed is ${speed - 50} km/h faster than the allowed speed of 50 - reckless driving`);
        }
    } else if (area === 'residential') {
        if (speed <= 20) {
            console.log(`Driving ${speed} km/h in a 20 zone`);
        } else if (speed <= 40) {
            console.log(`The speed is ${speed - 20} km/h faster than the allowed speed of 20 - speeding`);
        } else if (speed <= 60) {
            console.log(`The speed is ${speed - 20} km/h faster than the allowed speed of 20 - excessive speeding`);
        } else {
            console.log(`The speed is ${speed - 20} km/h faster than the allowed speed of 20 - reckless driving`);
        }
    } else if (area === 'interstate') {
        if (speed <= 90) {
            console.log(`Driving ${speed} km/h in a 90 zone`);
        } else if (speed <= 110) {
            console.log(`The speed is ${speed - 90} km/h faster than the allowed speed of 90 - speeding`);
        } else if (speed <= 130) {
            console.log(`The speed is ${speed - 90} km/h faster than the allowed speed of 90 - excessive speeding`);
        } else {
            console.log(`The speed is ${speed - 90} km/h faster than the allowed speed of 90 - reckless driving`);
        }
    } else if (area === 'motorway') {
        if (speed <= 130) {
            console.log(`Driving ${speed} km/h in a 130 zone`);
        } else if (speed <= 150) {
            console.log(`The speed is ${speed - 130} km/h faster than the allowed speed of 130 - speeding`);
        } else if (speed <= 170) {
            console.log(`The speed is ${speed - 130} km/h faster than the allowed speed of 130 - excessive speeding`);
        } else {
            console.log(`The speed is ${speed - 130} km/h faster than the allowed speed of 130 - reckless driving`);
        }
    }
}
main(40, 'city'); // working
main(60, 'city'); // working
main(80, 'city'); // working
main(100, 'city'); // working

main(10, 'residential'); // working
main(30, 'residential'); // working
main(50, 'residential'); // working
main(70, 'residential'); // working

main(80, 'interstate'); // working
main(100, 'interstate'); // working
main(120, 'interstate'); // working
main(140, 'interstate'); // working

main(120, 'motorway'); // working
main(140, 'motorway'); // working
main(160, 'motorway'); // working
main(180, 'motorway'); // working