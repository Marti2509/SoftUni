function main(arrays) {
    let biggest = Number.MIN_SAFE_INTEGER;

    for (const currArray of arrays) {
        for (let i = 0; i < currArray.length; i++) {
            if (currArray[i] > biggest) {
                biggest = currArray[i];
            }
        }
    }

    console.log(biggest);
}
main([[12, 99, 2, 35, 4], [5, 76, 7, 8, 88], [98, 10, 110, 12, 13]]);