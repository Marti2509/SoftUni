function main(array) {
    let catalog = {};

    for (const item of array) {
        let info = item.split(' : ');
        let name = info[0];
        let price = Number(info[1]);
        
        if (!catalog.hasOwnProperty(name[0])) {
            catalog[name[0]] = [{
                name,
                price
            }]
        } else {
            catalog[name[0]].push({
                name,
                price
            })
        }
    }

    let sorted = Object.keys(catalog)
    .sort((a, b) => a.localeCompare(b))
    .reduce((accumulator, key) => {
    accumulator[key] = catalog[key];

    return accumulator;
    }, {});

    
    for (let product in sorted) {
        console.log(product);

        for (const el of catalog[product].sort((a, b) => a.name.localeCompare(b.name))) {
            console.log(`  ${el.name}: ${el.price}`)
        }
    }
}
main()['Appricot : 20.4',
'Fridge : 1500',
'TV : 1499',
'Deodorant : 10',
'Boiler : 300',
'Apple : 1.25',
'Anti-Bug Spray : 15',
'T-Shirt : 10'];