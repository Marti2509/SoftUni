function main(array) {
    let result = [];

    for (let item of array.slice(1)) {
        item = item.substring(1, item.length - 2)
        .split(' | ')
        .map(x => x.trim());

        let town = item[0];
        let latitude = Number(Number(item[1]).toFixed(2));
        let longitude = Number(Number(item[2]).toFixed(2));

        result.push({
            'Town': town,
            'Latitude': latitude,
            'Longitude': longitude
        })
    }

    return JSON.stringify(result);
}
console.log(main(['| Town | Latitude | Longitude |', '| Sofia | 42.696552 | 23.32601 |', '| Beijing | 39.913818 | 116.363625 |']));