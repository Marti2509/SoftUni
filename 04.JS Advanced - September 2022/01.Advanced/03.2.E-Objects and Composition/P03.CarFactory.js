function main(object) {
    let resultCar = { model: object['model'], engine: { power: 0, volume: 0 }, carriage: { type: '', color: '' }, wheels: [] };

    if (object['power'] <= 90) {
        resultCar['engine']['power'] = 90;
        resultCar['engine']['volume'] = 1800;
    } else if (object['power'] <= 120) {
        resultCar['engine']['power'] = 120;
        resultCar['engine']['volume'] = 2400;
    } else {
        resultCar['engine']['power'] = 200;
        resultCar['engine']['volume'] = 3500;
    }

    if (object['carriage'] === 'hatchback') {
        resultCar['carriage']['type'] = 'hatchback';
    } else if (object['carriage'] === 'coupe') {
        resultCar['carriage']['type'] = 'coupe';
    }

    resultCar['carriage']['color'] = object['color'];

    if (object['wheelsize'] % 2 !== 0) {
        for (let i = 0; i < 4; i++) {
            resultCar['wheels'].push(object['wheelsize']);
        }
    } else {
        for (let i = 0; i < 4; i++) {
            resultCar['wheels'].push(object['wheelsize'] - 1);
        }
    }

    return resultCar;
}
console.log(main({ model: 'VW Golf II', power: 90, color: 'blue', carriage: 'hatchback', wheelsize: 14 }));
console.log(main({ model: 'Opel Vectra', power: 110, color: 'grey', carriage: 'coupe', wheelsize: 17 }));