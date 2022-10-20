function solve(area, vol, input) {
    let array = JSON.parse(input);

    let result = [];

    for (let i = 0; i < array.length; i++) {
        const currCoordinates = array[i];
        
        let resultArea = area.call(currCoordinates);
        let resultVol = vol.call(currCoordinates);

        let currResult = {
            'area': resultArea,
            'volume': resultVol
        }
        result.push(currResult);
    }

    return result;
}

function area() {
  return Math.abs(this.x * this.y);
}

function vol() {
  return Math.abs(this.x * this.y * this.z);
}

console.log(solve(area, vol,
    `[{"x":"1","y":"2","z":"10"},
    {"x":"7","y":"7","z":"10"},
    {"x":"5","y":"2","z":"10"}]`
));
