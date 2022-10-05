function main(towns) {
    towns = towns.map(town => town.split(' <-> '));

    let registry = {};

    for (let town of towns) {
        if (registry[town[0]] === undefined) {
            registry[town[0]] = 0;
        }

        registry[town[0]] += Number(town[1]);
    }

    for (let town in registry) {
        console.log(`${town} : ${registry[town]}`);
    }
}
main(['Sofia <-> 1200000', 'Montana <-> 20000', 'New York <-> 10000000', 'Washington <-> 2345000', 'Las Vegas <-> 1000000', 'Las Vegas <-> 1']);