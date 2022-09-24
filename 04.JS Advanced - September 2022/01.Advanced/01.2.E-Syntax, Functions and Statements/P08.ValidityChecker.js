function main(x1, y1, x2, y2) {
    if (!Number.isInteger(Math.sqrt((0 - x1) ** 2 + (0 - y1) ** 2))) {
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);
    } else {
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    }

    if (!Number.isInteger(Math.sqrt((0 - x2) ** 2 + (0 - y2) ** 2))) {
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);
    } else {
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    }

    if (!Number.isInteger(Math.sqrt((x2 - x1) ** 2 + (y2 - y1) ** 2))) {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    } else {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    }
}
main(3, 0, 0, 4);
main(2, 1, 1, 1)