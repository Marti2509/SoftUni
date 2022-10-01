function main(names) {
    names.sort((a, b) => a.localeCompare(b));

    let counter = 1;

    for (const name of names) {
        console.log(`${counter++}.${name}`);
    }
}
main(["John", "Bob", "Christina", "Ema"]);