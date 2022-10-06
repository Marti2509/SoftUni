function main(array) {
    let result = {};

    for (let i = 0; i < array.length; i++) {
        let currElement = array[i];
        
        if (i % 2 === 0) {
            result[currElement] = 0;
        } else {
            result[array[i - 1]] = currElement;
        }
    }

    let str = '{';

    for (let i = 0; i < Object.entries(result).length; i++) {
        const element = Object.entries(result)[i];
        
        str += ` ${element[0]}: ${element[1]}`;

        if (i + 1 !== Object.entries(result).length) {
            str += ','
        }
    }

    str += ' }';
    console.log(str);
}
main(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);